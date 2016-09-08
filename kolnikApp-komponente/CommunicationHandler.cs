using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace kolnikApp_komponente
{
    /// <summary>
    /// Klasa koja sadrži podlogu za jednostavnu mrežnu komunikaciju putem UDP-a
    /// </summary>
    public class CommunicationHandler
    {
        /// <summary>
        /// Mrežna utičnica koja osluškuje mrežni promet
        /// </summary>
        private static Socket netSocket;
        /// <summary>
        /// Objekt za asinkronu mrežnu komunikaciju
        /// </summary>
        private static SocketAsyncEventArgs netSocketServerArgs;
        /// <summary>
        /// Spremnik za pohranu primljenog sadržaja putem mreže
        /// </summary>
        private static byte[] netSocketBuffer;
        /// <summary>
        /// Stanje koje identificira da li je riječ o serverskoj aplikaciji ili klijentskoj
        /// </summary>
        private bool isServer;
        /// <summary>
        /// Objekt za postizanje međusobnog isključavanja kod višedretvenosti (najčešće kod asinkronih operacija)
        /// </summary>
        private static object thisLock = new object();
        /// <summary>
        /// Tvornički predviđen port na kojem bi aplikacija osluškivala mrežni promet i koristila za slanje
        /// </summary>
        private const ushort defaultPortNumber = 8087;
        /// <summary>
        /// Vremenski period između 2 testiranja prisutnosti korisnika
        /// </summary>
        private const int intervalLengthBetweenTimeoutChecksInMsec = 30000;
        /// <summary>
        /// Vremenski period nakon kojeg se korisnici smatraju neaktivnima (dropped out) ako ne odgovore na test prisutnosti
        /// </summary>
        private const short numOfMsecToWaitForTimeoutResponse = 2000;
        /// <summary>
        /// Broj pokušaja slanja prethodno prvotno poslane poruke za koju nije primljen odgovor
        /// </summary>
        private const byte numOfRepeatsOfTimeoutChecksIfClientDoesNotResponse = 3;
        /// <summary>
        /// Adresa poslužitelja kojem se šalju zahtjevi za rad s podacima na strani korisnika
        /// </summary>
        private IPEndPoint serverAddress = null;

        /// <summary>
        /// Inicijalizira osnovna svojstva za uobičajenu komunikaciju putem UDP-a
        /// </summary>
        private void InitializeObjectsForIPv4NetworkCommunication()
        {
            netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            netSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, true);
            netSocketServerArgs = new SocketAsyncEventArgs();
            netSocketBuffer = new byte[102400];
            netSocket.ExclusiveAddressUse = false;
            netSocketServerArgs.Completed += netSocketServerArgs_Completed;
            netSocketServerArgs.SetBuffer(netSocketBuffer, 0, 102400);
            StartListening();
            if (this.isServer)
            {
                ClientsAddressesList.addressList = new List<ClientsAddress>();
                Thread HeartbeatCheckingThreadHandle = new Thread(new ThreadStart(CheckIfAnyUserHasTimedOut));
                //HeartbeatCheckingThreadHandle.Start();
            }
        }

        /// <summary>
        /// Konvertira hostname (URI) odredišta u IP adresu korištenjem DNS protokola
        /// </summary>
        /// <param name="hostname">Hostname (URI) odredišta</param>
        /// <returns>IP adresa koju je vratio DNS server</returns>
        private IPAddress GetIPFromHostnameViaDNS(string hostname)
        {
            IPHostEntry hostEntry;

            hostEntry = Dns.GetHostEntry(hostname);

            if (hostEntry.AddressList.Length > 0)
            {
                return hostEntry.AddressList[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Provjera da li je proslijeđena IPv4 adresa valjana
        /// </summary>
        /// <param name="ipAddress">IPv4 adresa</param>
        /// <returns></returns>
        private bool IsValidIPAddress(string ipAddress)
        {
            return Regex.IsMatch(ipAddress, @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }

        /// <summary>
        /// Ispituje da li je koji korisnik u međuvremenu neregularno odjavljen od servera
        /// </summary>
        private void CheckIfAnyUserHasTimedOut()
        {
            string checkAvailabilityMessageContent;
            using (DataHandler obj = new DataHandler())
            {
                checkAvailabilityMessageContent = obj.CreateMessageForAvailabilityChecking();
            }

            while (true)
            {
                foreach (var zapis in ClientsAddressesList.addressList)
                {
                    MessageSend(checkAvailabilityMessageContent, zapis.EndPoint);
                }
                Thread.Sleep(numOfMsecToWaitForTimeoutResponse);
                //dunno why this sleep call prevents async function calls and main thread from execution -> therefore 1 extra second is added at comparison in condition in following if statement
                for (byte i = 0; i<ClientsAddressesList.addressList.Count(); i++)
                {
                    if ((DateTime.Now - ClientsAddressesList.addressList[i].TimeOfLastAnswer).TotalMilliseconds > (numOfMsecToWaitForTimeoutResponse + 1000))
                    {
                        ClientsAddressesList.UnregisterUserWithCertainIPAddress(ClientsAddressesList.addressList[i].EndPoint);
                    }
                }
                Thread.Sleep(intervalLengthBetweenTimeoutChecksInMsec - numOfMsecToWaitForTimeoutResponse);
            }
        }

        /// <summary>
        /// konstruktor klase za rad s prijenosom podataka
        /// </summary>
        /// <param name="isServer">Je li aplikacija serverska ili klijentska</param>
        /// <param name="remoteServerIdentifier">IPv4 adresa ili hostname (URI) računala vlastitog računala</param>
        /// <param name="portNum">Port sa kojeg će se slati poruke putem mreže i sa kojeg će se on osluškivati</param>
        public CommunicationHandler(bool isServer = true, string remoteServerIdentifier = null, ushort portNum = defaultPortNumber)
        {
            this.isServer = isServer;
            IPEndPoint remoteIPAddress = null;
            if (remoteServerIdentifier != null)
            {
                if (IsValidIPAddress(remoteServerIdentifier))
                {
                    remoteIPAddress = new IPEndPoint(IPAddress.Parse(remoteServerIdentifier), portNum);
                }
                else
                {
                    try
                    {
                        remoteIPAddress = new IPEndPoint(GetIPFromHostnameViaDNS(remoteServerIdentifier), portNum);
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show(e.Message);
                        return;
                    }
                }
            }
            if (remoteIPAddress != null)
            {
                serverAddress = remoteIPAddress;
            }
            InitializeObjectsForIPv4NetworkCommunication();
        }

        private void StartListening()
        {
            bool success = false;
            for (ushort i = defaultPortNumber; !success; i++)
            {
                success = true;
                try
                {
                    netSocket.Bind(new IPEndPoint(IPAddress.Any, i));
                }
                catch
                {
                    success = false;
                }
            }
            netSocketServerArgs.RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            netSocket.ReceiveMessageFromAsync(netSocketServerArgs);
        }

        /// <summary>
        /// Asinkrono upravlja primljenim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void netSocketServerArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (netSocketServerArgs.LastOperation == SocketAsyncOperation.ReceiveMessageFrom)
            {
                string receivedContent = UTF8Encoding.UTF8.GetString(netSocketServerArgs.Buffer, 0, e.BytesTransferred);
                netSocket.ReceiveMessageFromAsync(netSocketServerArgs);
                DataHandler dataHandlerInstance = new DataHandler();
                string response;
                lock (thisLock)
                {
                    dataHandlerInstance.InitializeDataContext();
                    IPEndPoint ipAddress = (e.RemoteEndPoint as IPEndPoint);
                    dataHandlerInstance.InterpretXMLData(receivedContent, ipAddress, !isServer);
                    dataHandlerInstance.ClearCurrentDataContext();
                    if (dataHandlerInstance.HasErrorOccurred)
                    {
                        response = dataHandlerInstance.ConstructErrorMessageContent();
                    }
                    else if (dataHandlerInstance.IsConfirmationOfPreviousRequest)
                    {
                        return;
                    }
                    else if (dataHandlerInstance.SendWhenMessageWillBeReceivedFromMicrocontroller)
                    {
                        return;
                    }
                    else
                    {
                        response = dataHandlerInstance.ResponseForSending;
                        if (response == null)
                        {
                            return;
                        }
                        response = DataHandler.AddWrapperOverXMLDatagroups(response);
                    }
                }

                foreach (var ipAddress in dataHandlerInstance.IPAddressesOfDestinations)
                {
                    MessageSend(response, ipAddress);
                }
            }
        }

        /// <summary>
        /// Šalje specifičnu poruku na definirano odredište koristeći inicijalno definiranu mrežnu utičnicu
        /// </summary>
        /// <param name="message">Sadržaj za slanje</param>
        /// <param name="destinationIPAddress">Odredište na koje se poruka šalje</param>
        private static void MessageSend(string message, EndPoint destinationIPAddress)
        {
            netSocketBuffer = UTF8Encoding.UTF8.GetBytes(message);
            netSocket.SendTo(netSocketBuffer, destinationIPAddress);
        }

        /// <summary>
        /// Upravlja podacima zaprimljenim putem serijske komunikacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DataThroughSerialCommunicationHasBeenReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string primljenaPoruka = ((SerialPort)sender).ReadLine();
            lock (thisLock)
            {
                DataHandler dataHandlerInstance = new DataHandler();
                dataHandlerInstance.InitializeDataContext();
                dataHandlerInstance.ProcessReceivedDataOverSerialCommunication(primljenaPoruka);
                dataHandlerInstance.ClearCurrentDataContext();
                string response = null;
                if (dataHandlerInstance.HasErrorOccurred)
                {
                    response = dataHandlerInstance.ConstructErrorMessageContent();
                }
                else
                {
                    response = DataHandler.AddWrapperOverXMLDatagroups(dataHandlerInstance.ResponseForSending);
                }
                if (dataHandlerInstance.IPAddressesOfDestinations != null)
                {
                    foreach (var ipAddress in dataHandlerInstance.IPAddressesOfDestinations)
                    {
                        MessageSend(response, ipAddress);
                    }
                }
            }
        }

        /// <summary>
        /// Šalje zahtjev za dohvaćanje svih podataka svih vrsti entiteta kojima pošiljatelj ima pristup
        /// </summary>
        public void SendRequestForSendingUsedData()
        {
            using (DataHandler obj = new DataHandler())
            {
                MessageSend(obj.ConstructMessageWithRequestForSendingInstancesOfUsedEntities(), serverAddress);
            }
        }

        /// <summary>
        /// Šalje podatke za prijavu u sustav
        /// </summary>
        /// <param name="userIdentity">OIB korisnika ili korisničko ime</param>
        /// <param name="password">Pripadajuća lozinka za navedeni korisnički račun</param>
        /// <param name="isIdentityUsername">Je li riječ o OIB-u ili korisničkom imenu</param>
        public void SendLoginCredentials(string userIdentity, string password, bool isIdentityUsername)
        {
            DataHandler instance = new DataHandler();
            MessageSend(instance.ConstructLoginMessageContent(userIdentity, password, isIdentityUsername), serverAddress);
        }

        /// <summary>
        /// Šalje zahtjev za odjavom sa poslužitelja
        /// </summary>
        public void SendLogoutRequest()
        {
            DataHandler instance = new DataHandler();
            MessageSend(instance.ConstructLogoutMessageContent(), serverAddress);
        }

        /// <summary>
        /// Šalje proslijeđeni serijalizirani sadržaj poslužitelju
        /// </summary>
        /// <param name="serializedData">Serijalizirani sadržaj (ovdje se koristi XML standard)</param>
        public void SendSerializedData(string serializedData)
        {
            MessageSend(serializedData, serverAddress);
        }

        public void SendRequestForGettingTemperatura()
        {
            MessageSend(DataHandler.ConstructTemperatureRequest(), serverAddress);
        }
    }

}

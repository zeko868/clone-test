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
    public class CommunicationHandler
    {
        private static Socket netSocket;
        private static SocketAsyncEventArgs netSocketServerArgs;
        private static byte[] netSocketBuffer;
        private bool isServer;
        private static object thisLock = new object();
        private const ushort defaultPortNumber = 8087;
        private const int intervalLengthBetweenTimeoutChecksInMsec = 30000;
        private const short numOfMsecToWaitForTimeoutResponse = 2000;
        private const byte numOfRepeatsOfTimeoutChecksIfClientDoesNotResponse = 3;
        private IPEndPoint serverAddress = null;

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
                Thread HearthbeatCheckingThreadHandle = new Thread(new ThreadStart(CheckIfAnyUserHasTimedOut));
            }
        }

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

        private bool IsValidIPAddress(string ipAddress)
        {
            return Regex.IsMatch(ipAddress, @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }

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
                foreach (var zapis in ClientsAddressesList.addressList)
                {
                    if ((DateTime.Now - zapis.TimeOfLastAnswer).TotalMilliseconds > numOfMsecToWaitForTimeoutResponse)
                    {
                        ClientsAddressesList.UnregisterUserWithCertainIPAddress(zapis.EndPoint);
                    }
                }
                Thread.Sleep(intervalLengthBetweenTimeoutChecksInMsec - numOfMsecToWaitForTimeoutResponse);
            }
        }
        public CommunicationHandler(bool isServer = true, string remoteServerIdentifier = null, ushort portNum = defaultPortNumber)
        {
            this.isServer = isServer;
            IPEndPoint remoteIPAddress = null;
            if (remoteServerIdentifier != null)
            {
                if (IsValidIPAddress(remoteServerIdentifier)) {
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
                        response = dataHandlerInstance.AddWrapperOverXMLDatagroups(response);
                    }
                }

                foreach (var ipAddress in dataHandlerInstance.IPAddressesOfDestinations)
                {
                    MessageSend(response, ipAddress);
                }
            }
        }

        private static void MessageSend(string message, EndPoint destinationIPAddress)
        {
            netSocketBuffer = UTF8Encoding.UTF8.GetBytes(message);
            netSocket.SendTo(netSocketBuffer, destinationIPAddress);
        }

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
                    response = dataHandlerInstance.AddWrapperOverXMLDatagroups(dataHandlerInstance.ResponseForSending);
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

        public void SendRequestForSendingUsedData()
        {
            using (DataHandler obj = new DataHandler())
            {
                MessageSend(obj.ConstructMessageWithRequestForSendingInstancesOfUsedEntities(), serverAddress);
            }
        }

        public void SendLoginCredentials(string userIdentity, string password, bool isIdentityUsername)
        {
            DataHandler instance = new DataHandler();
            MessageSend(instance.ConstructLoginMessageContent(userIdentity, password, isIdentityUsername), serverAddress);
        }

        public void SendLogoutRequest()
        {
            DataHandler instance = new DataHandler();
            MessageSend(instance.ConstructLogoutMessageContent(), serverAddress);
        }
    }

}

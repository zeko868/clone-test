using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace kolnikApp_komponente
{
    public class DataHandler : IDisposable
    {
        private bool sendToAll = false;

        private static Nullable<bool> loginState = null;

        public static Nullable<bool> LoginState
        {
            get
            {
                Nullable<bool> tmp = loginState;
                loginState = null;
                return tmp;
            }
            private set
            {
                loginState = value;
            }
        }
        private static zaposlenik loggedUser;

        public static zaposlenik LoggedUser
        {
            get
            {
                return loggedUser;
            }
            private set
            {
                loggedUser = value;
            }
        }

        public static SerialPort arduinoPort;

        private DataClasses1DataContext dataContextInstance;

        public bool HasErrorOccurred = false;
        public string ErrorInfo = null;
        public string EntityOnWhichErrorRefers = null;
        public bool IsConfirmationOfPreviousRequest = false;
        public bool SendWhenMessageWillBeReceivedFromMicrocontroller = false;
        public string ResponseForSending;
        public System.Net.IPEndPoint[] IPAddressesOfDestinations = null;

        public static Dictionary<string, BindingList<object>> entityNamesWithReferencesToBelongingDataStores = null;
        public static Dictionary<string, System.Windows.Forms.Control> entityNamesWithBelongingContainers = null;

        public static Nullable<T> TypeToNullableType<T>(string s) where T : struct
        {
            Nullable<T> result = new Nullable<T>();
            try
            {
                if (!string.IsNullOrEmpty(s) && s.Trim().Length > 0)
                {
                    TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
                    result = (T)conv.ConvertFrom(s);
                }
            }
            catch
            {
                Console.WriteLine("Pojavila se pogreška prilikom pokušaja pretvorbe u Nullable tip.");
            }
            return result;
        }

        private bool IsCollection(object variable)
        {
            return variable.GetType().GetInterfaces().Any(
                i => i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IEnumerable<>)
            );
        }

        public string ConvertObjectsToXMLData(object instance)
        {
            MemoryStream stream1 = new MemoryStream();
            try
            {
                DataContractSerializer ser = new DataContractSerializer(instance.GetType());
                //za serijalizaciju je potrebno sljedeće:
                //-ako postoji cikličnost, potrebno je ispred svake klase, koja u ERA modelu na strani 0..1 kod veze 1-N, dodati atribut [DataContract(IsReference=true)]
                //-ispred svakog javnog svojstva (property-ja) koje se želi serijalizirati unutar svake klase je potrebno staviti atribut [DataMemberAttribute]
                //-ispred svakog javnog svojstva (property-ja) koje se ne želi serijalizirati (poput navigacijskih svojstava) je potrebno staviti atribut [IgnoreDataMember]
                ser.WriteObject(stream1, instance);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Iznimka: " + ex.Message);
            }

            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            string xmlOutput = sr.ReadToEnd();
            if (IsCollection(instance))
            {
                int offset = xmlOutput.IndexOf('>') + 1;
                xmlOutput = xmlOutput.Substring(offset, xmlOutput.LastIndexOf('<') - offset);
            }
            return Regex.Replace(xmlOutput.Replace("xmlns:z=\"http://schemas.microsoft.com/2003/10/Serialization/\"", "").Replace(" xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\" ", "").Replace(" i:nil=\"true\"", ""), @" z:Id=""i\d+""", "");
        }

        public string AddWrapperOverXMLDatagroups(string XMLData)
        {
            return "<data>" + XMLData + "</data>";
        }

        private string AddHeaderInfoToXMLDatagroup(string XMLData, char action = 'R')
        {
            return "<datagroup action=\"" + action + "\">" + XMLData + "</datagroup>";
        }

        private string ConvertNonObjectDataIntoXMLData(string tagName, string value = null, Dictionary<string,string> attributes = null)
        {
            return "<" + tagName + (attributes!=null?String.Join("", attributes.Select(x => " " + x.Key + "=\"" + x.Value + "\"")):"") + ">" + (value==null?"":value) + "</" + tagName + ">";
        }

        public string CreateMessageForAvailabilityChecking()
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("provjeri_dostupnost")));
        }
        public string ConstructErrorMessageContent()
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData(EntityOnWhichErrorRefers, ErrorInfo)));
        }
        private string GenerateCommandForUpdatingRecord(Type tip, object sth, object oldValIfUpdating)
        {
            string commandForUpdatingRecord = "UPDATE " + tip.Name;
            bool recordHasNotBeenChanged = true;
            for (int i = 0; i < 2; i++)
            {
                object obj;
                string delimiter;
                string operatorForNull;
                if (i == 0)
                {
                    commandForUpdatingRecord += " SET ";
                    obj = sth;
                    delimiter = ",";
                    operatorForNull = "=";
                }
                else
                {
                    commandForUpdatingRecord += " WHERE ";
                    obj = oldValIfUpdating;
                    delimiter = " AND ";
                    operatorForNull = " IS ";
                }
                foreach (PropertyInfo info in tip.GetProperties().Where(x => x.PropertyType.Namespace != "kolnikApp_server" && x.PropertyType.Name != "EntitySet`1"))
                {
                    if (info.CanWrite)
                    {
                        if (i == 0)
                        {
                            if ((info.GetValue(sth) == null && info.GetValue(oldValIfUpdating) == null) || info.GetValue(sth).Equals(info.GetValue(oldValIfUpdating)))
                            {
                                continue;
                            }
                            else
                            {
                                recordHasNotBeenChanged = false;
                            }
                        }
                        if (info.GetValue(obj) == null)
                        {
                            commandForUpdatingRecord += info.Name + operatorForNull + "null" + delimiter;
                        }
                        else
                        {
                            Console.WriteLine(info.PropertyType.Name);
                            switch (info.PropertyType.Name)
                            {
                                case "DateTime":
                                case "String":
                                case "Char":
                                    commandForUpdatingRecord += info.Name + "='" + info.GetValue(obj).ToString() + "'" + delimiter;
                                    break;
                                default:
                                    commandForUpdatingRecord += info.Name + "=" + info.GetValue(obj) + delimiter;
                                    break;
                            }
                        }
                    }
                }
                if (recordHasNotBeenChanged)
                {
                    return ";";
                }
                commandForUpdatingRecord = commandForUpdatingRecord.Substring(0, commandForUpdatingRecord.LastIndexOf(delimiter));
            }
            return commandForUpdatingRecord;
        }
        
        private void PutRecordProcessingCommandInExecutionQueue(char action, object sth, object oldValIfUpdating)
        {
            Type tip = sth.GetType();
            var tableInDataContext = dataContextInstance.GetTable(tip);
            switch (action)
            {
                case 'C':
                    tableInDataContext.InsertOnSubmit(sth);
                    break;
                case 'U':
                    string commandForUpdatingRecord = GenerateCommandForUpdatingRecord(tip, sth, oldValIfUpdating);
                    try
                    {
                        dataContextInstance.ExecuteCommand(commandForUpdatingRecord);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 'D':
                    tableInDataContext.Attach(sth);
                    tableInDataContext.DeleteOnSubmit(sth);
                    break;
            }
        }

        private void AssignObjectsProperties(object a, XElement KeyValuePairsOfEntity, bool assignOldValues = false)
        {
            foreach (var KeyValuePair in KeyValuePairsOfEntity.Elements())
            {
                if (assignOldValues)
                {
                    SetProperty(a, KeyValuePair.Name.LocalName, KeyValuePair.Attribute("old").Value);
                }
                else
                {
                    SetProperty(a, KeyValuePair.Name.LocalName, KeyValuePair.Value);
                }
            }
        }
        private void SetProperty(object p, string propName, object value)
        {
            Type t = p.GetType();
            foreach (PropertyInfo info in t.GetProperties())
            {
                if (info.Name == propName && info.CanWrite)
                {
                    if (value.Equals(""))
                    {
                        info.SetValue(p, null);
                    }
                    else
                    {
                        TypeConverter conv = TypeDescriptor.GetConverter(info.PropertyType);
                        if (info.PropertyType.Name == "Char")
                        {
                            info.SetValue(p, (char)byte.Parse((string)value));
                        }
                        else
                        {
                            info.SetValue(p, conv.ConvertFrom(value));
                        }
                    }
                }
            }
        }

        public bool IsUserPrivilegedToDoAnAction(System.Net.IPEndPoint address, string entityName, char action)
        {
            IEnumerable<int> userHasRight = from ip_adresar in ClientsAddressesList.addressList
            join radi in dataContextInstance.radis
            on ip_adresar.Oib equals radi.zaposlenik
            join tablicna_privilegija in dataContextInstance.tablicna_privilegijas
            on radi.radno_mjesto equals tablicna_privilegija.radno_mjesto
            where ip_adresar.EndPoint.Equals(address)
            && tablicna_privilegija.naziv_tablice.Equals(entityName)
            && tablicna_privilegija.operacija == action
            select 1;
            return userHasRight.Any();
        }

        public List<string> GetListOfAccessibleEntityTypes(System.Net.IPEndPoint address)
        {
            return (from ip_adresar in ClientsAddressesList.addressList
                                            join radi in dataContextInstance.radis
                                            on ip_adresar.Oib equals radi.zaposlenik
                                            join tablicna_privilegija in dataContextInstance.tablicna_privilegijas
                                            on radi.radno_mjesto equals tablicna_privilegija.radno_mjesto
                                            where ip_adresar.EndPoint.Equals(address)
                                            select tablicna_privilegija.naziv_tablice).Distinct().ToList();
        }

        public void InterpretXMLData(string XMLData, System.Net.IPEndPoint address, bool isClientSide = true)
        {
            XDocument doc = XDocument.Parse(XMLData);

            var datagroups = doc.Element("data").Elements();
            foreach (var datagroup in datagroups)
            {
                char action = datagroup.Attribute("action").Value[0];
                string entityName = datagroup.Elements().First().Name.LocalName;
                switch (entityName)
                {
                    case "senzor_temperature":
                        if (!isClientSide)
                        {
                            if (arduinoPort != null)
                            {
                                if (IsUserPrivilegedToDoAnAction(address, "otpremnica", 'C') || IsUserPrivilegedToDoAnAction(address, "otpremnica", 'U'))
                                {
                                    string sendersOib = ClientsAddressesList.addressList.Where(x => x.EndPoint.Equals(address)).Select(x => x.Oib).First();
                                    PosaljiZahtjevZaIscitavanjemTemperatureBitumenskeMjesavine(sendersOib);
                                    SendWhenMessageWillBeReceivedFromMicrocontroller = true;
                                }
                            }
                            else
                            {
                                HasErrorOccurred = true;
                                ErrorInfo = "Trenutno nije moguće dohvatiti podatak o temperaturi bitumenske mješavine";
                                EntityOnWhichErrorRefers = entityName;
                            }
                        }
                        else
                        {

                        }
                        break;
                    case "pristiglo_vozilo":
                        if (isClientSide)
                        {
                            System.Windows.Forms.MessageBox.Show("Pristiglo je novo vozilo pred otpremište!");
                        }
                        break;
                    case "pogreska_o_podatkovnom_zahtjevu":
                        if (isClientSide)
                        {
                            System.Windows.Forms.MessageBox.Show(datagroup.Element(entityName).Value);
                        }
                        break;
                    case "provjeri_dostupnost":
                        if (isClientSide)
                        {
                            //VratiPaketPosluziteljuSPotvrdomOAktivnosti
                            ResponseForSending = AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("provjeri_dostupnost", "active"));
                        }
                        else
                        {
                            string sendersOib = ClientsAddressesList.addressList.Where(x => x.EndPoint.Equals(address)).Select(x => x.Oib).First();
                            ClientsAddressesList.addressList.Where(x => x.Oib == sendersOib).First().UpdateTimeOfLastAnswer();
                        }
                        break;
                    case "prijava":
                        if (!isClientSide)
                        {
                            XElement prijavaPodaci = datagroup.Element("prijava");
                            var queryResult = (from korisnicki_racun in dataContextInstance.korisnicki_racuns
                                                              join zaposlenik in dataContextInstance.zaposleniks
                                                              on korisnicki_racun.zaposlenik equals zaposlenik.oib
                                                              where
                                                              (
                                                                  korisnicki_racun.korisnicko_ime.Equals(prijavaPodaci.Element("korisnicko_ime").Value)
                                                                  || korisnicki_racun.zaposlenik.Equals(prijavaPodaci.Element("oib").Value)
                                                              )
                                                              select new { zaposlenik , korisnicki_racun.lozinka });
                            bool userWithProvidedUsernameOrOibExists = Convert.ToBoolean(queryResult.Count());
                            if (userWithProvidedUsernameOrOibExists && HashPasswordUsingSHA1Algorithm(prijavaPodaci.Element("lozinka").Value) == queryResult.First().lozinka.TrimEnd(' '))
                            {
                                string userOib = queryResult.First().zaposlenik.oib;
                                if (ClientsAddressesList.CheckIfUserWithCertainOibIsAlreadyLoggedIn(userOib))
                                {
                                    HasErrorOccurred = true;
                                    ErrorInfo = "Korisnik sa navedenim OIB-om je već prijavljen!";
                                    EntityOnWhichErrorRefers = entityName;
                                }
                                else
                                {
                                    ClientsAddressesList.RegisterUser(userOib, address);
                                    Dictionary<string, string> attributes = new Dictionary<string, string>();
                                    attributes["success"] = "success";
                                    ResponseForSending = AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("prijava", ConvertObjectsToXMLData(queryResult.First().zaposlenik), attributes));
                                }
                            }
                            else
                            {
                                HasErrorOccurred = true;
                                ErrorInfo = "Unijeli ste pogrešne podatke za prijavu.";
                                EntityOnWhichErrorRefers = entityName;
                            }
                        }
                        else
                        {
                            XElement infoAboutLoginAttempt = datagroup.Element("prijava");
                            if (datagroup.Element("prijava").Attribute("success") != null)
                            {
                                LoggedUser = new zaposlenik()
                                {
                                    oib = infoAboutLoginAttempt.Element("zaposlenik").Element("oib").Value,
                                    ime = infoAboutLoginAttempt.Element("zaposlenik").Element("ime").Value,
                                    prezime = infoAboutLoginAttempt.Element("zaposlenik").Element("prezime").Value
                                };
                                LoginState = true;
                                IsConfirmationOfPreviousRequest = true;
                            }
                            else
                            {
                                LoginState = false;
                            }
                        }
                        break;
                    case "odjava":
                        if (!isClientSide)
                        {
                            ClientsAddressesList.UnregisterUserWithCertainIPAddress(address);
                            IsConfirmationOfPreviousRequest = true;
                        }
                        break;
                    case "registracija":
                        if (!isClientSide)
                        {
                            korisnicki_racun noviKorisnickiRacun = new korisnicki_racun();
                            XElement registracijaPodaci = datagroup.Element("registracija");
                            noviKorisnickiRacun.zaposlenik = registracijaPodaci.Element("oib").Value;
                            IQueryable<int> queryResult = from zaposlenik in dataContextInstance.zaposleniks
                                                           where zaposlenik.oib == registracijaPodaci.Element("oib").Value
                                                           select 1;
                            if (queryResult.Count() == 0)
                            {
                                zaposlenik noviZaposlenik = new zaposlenik()
                                {
                                    oib = registracijaPodaci.Element("oib").Value,
                                    ime = registracijaPodaci.Element("ime").Value,
                                    prezime = registracijaPodaci.Element("prezime").Value
                                };
                                dataContextInstance.zaposleniks.InsertOnSubmit(noviZaposlenik);
                            }
                            noviKorisnickiRacun.korisnicko_ime = registracijaPodaci.Element("korisnicko_ime").Value;
                            noviKorisnickiRacun.lozinka = HashPasswordUsingSHA1Algorithm(registracijaPodaci.Element("lozinka").Value);
                            dataContextInstance.korisnicki_racuns.InsertOnSubmit(noviKorisnickiRacun);
                            try
                            {
                                dataContextInstance.SubmitChanges();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        break;
                    case "tablica":
                        if (!isClientSide)
                        {
                            ResponseForSending = AddHeaderInfoToXMLDatagroup(String.Join("", GetListOfAccessibleEntityTypes(address).Select(x => ConvertNonObjectDataIntoXMLData("tablica", x))));
                        }
                        else
                        {
                            foreach (var tablica in datagroup.Elements())
                            {
                                entityNamesWithReferencesToBelongingDataStores["tablica"].Add(tablica.Value);
                            }
                        }
                        break;
                default:
                        if (isClientSide || IsUserPrivilegedToDoAnAction(address, entityName, action))
                        {
                            foreach (var redak in datagroup.Elements())
                            {
                                object sth = null;
                                var type = Assembly.GetExecutingAssembly().GetTypes().SingleOrDefault(t => t.Name == redak.Name.LocalName);
                                var ctors = type.GetConstructors();
                                sth = ctors[0].Invoke(new object[] { });

                                if (!isClientSide)
                                {
                                    if (action != 'R')
                                    {
                                        object oldValIfUpdating = null;

                                        AssignObjectsProperties(sth, redak);
                                        if (action == 'U')
                                        {
                                            oldValIfUpdating = ctors[0].Invoke(new object[] { });
                                            AssignObjectsProperties(oldValIfUpdating, redak, true);
                                        }
                                        PutRecordProcessingCommandInExecutionQueue(action, sth, oldValIfUpdating);
                                    }
                                    else
                                    {
                                        var recordSet = dataContextInstance.ExecuteQuery(type, "SELECT * FROM " + type.Name);

                                        var listType = typeof(List<>);
                                        var constructedListType = listType.MakeGenericType(type);

                                        var instance = (IList)Activator.CreateInstance(constructedListType);
                                        foreach (var record in recordSet)
                                        {
                                            instance.Add(record);
                                        }
                                        ResponseForSending += AddHeaderInfoToXMLDatagroup(ConvertObjectsToXMLData(instance), 'C');
                                    }
                                }
                                else
                                {
                                    AssignObjectsProperties(sth, redak);
                                    object oldValIfUpdating = null;
                                    if (action == 'U')
                                    {
                                        oldValIfUpdating = ctors[0].Invoke(new object[] { });
                                        AssignObjectsProperties(oldValIfUpdating, redak, true);
                                    }
                                    StoreReceivedDataIntoFormsLists(action, sth, oldValIfUpdating);
                                }

                            }
                        }

                        break;
                }
                if (action != 'R')
                {
                    try
                    {
                        dataContextInstance.SubmitChanges();

                        ConstructBaseOfMessageContentForSending(XMLData, address);
                    }
                    catch (Exception ex)
                    {
                        string successIdentifier = "success";
                        if (!ex.Message.StartsWith(successIdentifier))
                        {
                            HasErrorOccurred = true;
                            ErrorInfo = ex.Message;
                            EntityOnWhichErrorRefers = "pogreska_o_podatkovnom_zahtjevu";
                        }
                        else
                        {
                            ConstructBaseOfMessageContentForSending(XMLData, address);
                            string changesPerformedByTrigger = ex.Message.Substring(successIdentifier.Length);
                            ResponseForSending += changesPerformedByTrigger;
                        }
                    }
                }

            }
            if (!isClientSide)
            {
                if (sendToAll)
                {
                    IPAddressesOfDestinations = ClientsAddressesList.addressList.Where(x => !x.EndPoint.Equals(address)).Select(x => x.EndPoint).ToArray();
                }
                else
                {
                    IPAddressesOfDestinations = new System.Net.IPEndPoint[1];
                    IPAddressesOfDestinations[0] = address;
                }
            }
            else
            {
                IsConfirmationOfPreviousRequest = true;
            }
        }

        private string HashPasswordUsingSHA1Algorithm(string password)
        {
            return String.Join("", SHA1.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password.ToCharArray())).Select(x => String.Format("{0:X}", x)));
        }

        private void ConstructBaseOfMessageContentForSending(string XMLData, System.Net.IPEndPoint senderIP)
        {
            ResponseForSending += XMLData;
            sendToAll = true;
            //select radi.zaposlenik,tablicna_privilegija.naziv_tablice from radi
            //join tablicna_privilegija on radi.radno_mjesto = tablicna_privilegija.radno_mjesto
            //group by radi.zaposlenik, tablicna_privilegija.naziv_tablice having count(*) > 0;
            /*            IPAddressesOfOtherDestinations = (from ip_adresar in ClientsAddressesList.addressList
                                                          join radi in dataContextInstance.radis
                                                          on ip_adresar.Oib equals radi.zaposlenik
                                                          join tablicna_privilegija in dataContextInstance.tablicna_privilegijas
                                                          on radi.radno_mjesto equals tablicna_privilegija.radno_mjesto
                                                          where !ip_adresar.EndPoint.Equals(senderIP)
                                                          group ip_adresar by new { ip_adresar.EndPoint, tablicna_privilegija.naziv_tablice } into grp
                                                          where grp.Count() > 0
                                                          select grp.Key).Where(x => x.naziv_tablice.Equals()).Select(x => x.EndPoint).ToArray();*/
        }

        public void StoreReceivedDataIntoFormsLists(char action, object obj, object oldObjIfUpdate = null)
        {
            string objectTypename = obj.GetType().Name;
            if (entityNamesWithReferencesToBelongingDataStores.ContainsKey(objectTypename))
            {
                switch (action)
                {
                    case 'C':
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Add(obj);
                        break;
                    case 'D':
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Remove(obj);
                        break;
                    case 'U':
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Remove(oldObjIfUpdate);
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Add(obj);
                        break;
                }

                if (entityNamesWithBelongingContainers != null && entityNamesWithBelongingContainers.ContainsKey(objectTypename))
                {
                    string controlTypename = entityNamesWithBelongingContainers[objectTypename].GetType().Name;
                    switch (controlTypename)
                    {
                        case "DataGridView":
                            ((System.Windows.Forms.DataGridView)entityNamesWithBelongingContainers[objectTypename]).Refresh();
                            break;
                        case "ComboBox":
                            ((System.Windows.Forms.ComboBox)entityNamesWithBelongingContainers[objectTypename]).Refresh();
                            break;
                    }
                }
            }
        }

        public string ConstructMessageWithRequestForSendingInstancesOfUsedEntities()
        {
            return AddWrapperOverXMLDatagroups(String.Join("", entityNamesWithReferencesToBelongingDataStores.Keys.Select(x => AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData(x), 'R'))));
        }

        public string ConstructLoginMessageContent(string identity, string password, bool isIdentityUsername)
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("prijava",
                ConvertNonObjectDataIntoXMLData("oib", isIdentityUsername ? "" : identity) +
                ConvertNonObjectDataIntoXMLData("korisnicko_ime", isIdentityUsername ? identity : "") +
                ConvertNonObjectDataIntoXMLData("lozinka", password)
                )));
        }

        public string ConstructLogoutMessageContent()
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("odjava")));
        }

        public DataHandler()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        public void ProcessReceivedDataOverSerialCommunication(string primljenaPoruka)
        {
            if (primljenaPoruka.StartsWith("TMP"))
            {
                int temperatura = -1;
                try
                {
                    temperatura = int.Parse(Regex.Match(primljenaPoruka, @"\-?\d+").Value);
                }
                catch
                {
                    HasErrorOccurred = true;
                    ErrorInfo = "Mikrokontroler je poslao neispravan zapis serijskom komunikacijom";
                    EntityOnWhichErrorRefers = "senzor_temperature";
                }
                string oibIdentifier = "OIB=";
                string oibPrimatelja = primljenaPoruka.Substring(primljenaPoruka.IndexOf(oibIdentifier) + oibIdentifier.Length);
                IPAddressesOfDestinations = ClientsAddressesList.addressList.Where(x => x.Oib == oibPrimatelja).Select(x => x.EndPoint).ToArray();
                if (HasErrorOccurred)
                {
                    return;
                }
                ResponseForSending = AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("senzor_temperature", temperatura.ToString()));
            }
            else if (primljenaPoruka.StartsWith("NOTIFY"))
            {
                IQueryable<System.Net.IPEndPoint> otpremnicari = from radi in dataContextInstance.radis
                                   join radno_mjesto in dataContextInstance.radno_mjestos
                                   on radi.radno_mjesto equals radno_mjesto.id
                                   join ip_adresar in ClientsAddressesList.addressList
                                   on radi.zaposlenik equals ip_adresar.Oib
                                   where radi.datum_zavrsetka == null && radno_mjesto.naziv == "otpremitelj"
                                   select ip_adresar.EndPoint;
                IPAddressesOfDestinations = otpremnicari.ToArray();
                ResponseForSending = AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("pristiglo_vozilo", ""));
            }
        }

        private void PosaljiZahtjevZaIscitavanjemTemperatureBitumenskeMjesavine(string oibZahtjevatelja)
        {
            try
            {
                arduinoPort.WriteLine("temperatura&OIB=" + oibZahtjevatelja);
            }
            catch
            {
                HasErrorOccurred = true;
                ErrorInfo = "Neuspjeh kod uspostavljanja veze sa Arduino mikrokontrolerom.";
                EntityOnWhichErrorRefers = "senzor_temperature";
            }
        }

        public void InitializeDataContext()
        {
            dataContextInstance = new DataClasses1DataContext();
        }
        public void ClearCurrentDataContext()
        {
            dataContextInstance.Dispose();
        }

        void IDisposable.Dispose()
        {

        }
    }
}

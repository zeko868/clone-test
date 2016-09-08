using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace kolnikApp_komponente
{
    public class DataHandler : IDisposable
    {
        private bool sendToAll = false;

        public enum LoginState
        {
            waiting = 0,
            error = 1,
            success = 2
        }

        public static volatile byte UserLoginState;

        private static volatile bool changesCommited = false;
        public static bool ChangesCommited
        {
            get
            {
                if (changesCommited)
                {
                    bool tmp = changesCommited;
                    changesCommited = false;
                    return tmp;
                }
                return false;
            }
            private set
            {
                changesCommited = value;
            }
        }

        private static osoba loggedUser;

        public static osoba LoggedUser
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

        public static volatile int Temperatura = 0;

        public static SerialPort ArduinoPort;

        private DataClasses1DataContext dataContextInstance;

        public bool HasErrorOccurred = false;
        public string ErrorInfo = null;
        public string EntityOnWhichErrorRefers = null;
        public bool IsConfirmationOfPreviousRequest = false;
        public bool SendWhenMessageWillBeReceivedFromMicrocontroller = false;
        public string ResponseForSending;
        public System.Net.IPEndPoint[] IPAddressesOfDestinations = null;

        public static Dictionary<string, BindingList<object>> entityNamesWithReferencesToBelongingDataStores = null;
        public static List<string> entityNamesForButtons = new List<string>();
        static List<Dictionary<string, object>> entityRelationships = null;
        static List<Dictionary<string, object>> entityAutoIncrementColumns = null;

        public enum Operations
        {
            C = 1,
            R = 2,
            U = 4,
            D = 8
        }

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

        private static bool IsCollection(object variable)
        {
            return variable.GetType().GetInterfaces().Any(
                i => i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IEnumerable<>)
            );
        }

        public static string ConvertObjectsToXMLData(object instance)
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

        public static string AddWrapperOverXMLDatagroups(string XMLData)
        {
            return "<data>" + XMLData + "</data>";
        }

        public static string AddHeaderInfoToXMLDatagroup(string XMLData, char action = 'R')
        {
            return "<datagroup action=\"" + action + "\">" + XMLData + "</datagroup>";
        }

        private static string ConvertNonObjectDataIntoXMLData(string tagName, string value = null, Dictionary<string,string> attributes = null)
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

        public static string ConstructTemperatureRequest()
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("senzor_temperature"), 'R'));
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
                foreach (PropertyInfo info in tip.GetProperties())
                {
                    if (info.CanWrite)
                    {
                        if (i == 0)
                        {
                            if ((info.GetValue(sth) == null && info.GetValue(oldValIfUpdating) == null))
                            {
                                continue;
                            }
                            else if ((info.GetValue(sth) != null && info.GetValue(oldValIfUpdating) != null) && info.GetValue(sth).Equals(info.GetValue(oldValIfUpdating)))
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
                            switch (info.PropertyType.Name)
                            {
                                case "DateTime":
                                    if (i == 1) //ovaj način se vrši jer je razlika u formatu zapisa u bazi i objekata u .netu (u bp s milisekundama, tu ne)
                                    {
                                        break;  //pretpostavka da datum nije PK (jedinstvena značajka zapisa)
                                    }
                                    else
                                    {
                                        commandForUpdatingRecord += info.Name + "='" + info.GetValue(obj).ToString() + "'" + delimiter;
                                    }
                                    break;
                                case "String":
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
                        if (commandForUpdatingRecord != ";")
                        {
                            dataContextInstance.ExecuteCommand(commandForUpdatingRecord);
                        }
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
                        info.SetValue(p, conv.ConvertFrom(value));
                    }
                }
            }
        }

        public bool IsUserPrivilegedToDoAnAction(System.Net.IPEndPoint address, string entityName, char action)
        {

            IEnumerable<byte> userRights = from ip_adresar in ClientsAddressesList.addressList
            join zaposlen in dataContextInstance.zaposlens
            on ip_adresar.Oib equals zaposlen.zaposlenik
            join tablicna_privilegija in dataContextInstance.tablicna_privilegijas
            on zaposlen.radno_mjesto equals tablicna_privilegija.radno_mjesto
            where ip_adresar.EndPoint.Equals(address)
            && tablicna_privilegija.naziv_tablice.Equals(entityName)
            select tablicna_privilegija.operacija;
            if (userRights.Count() == 0)
            {
                return false;
            }
            return ((Operations)userRights.First()).HasFlag((Operations)Enum.Parse(typeof(Operations), action.ToString()));
        }

        private List<Dictionary<string, object>> GetNonEntityQueryResult(string query)
        {
            List<Dictionary<string, object>> retVal = new List<Dictionary<string, object>>();
            using (DbCommand command = dataContextInstance.Connection.CreateCommand())
            {
                command.CommandText = query;
                dataContextInstance.Connection.Open();

                using (DbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> dictionary = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dictionary.Add(reader.GetName(i), reader.GetValue(i));
                        }

                        retVal.Add(dictionary);
                    }
                }
            }
            return retVal;
        }

        private List<string> GetListOfAccessibleEntityTypes(System.Net.IPEndPoint address)
        {
            return (from ip_adresar in ClientsAddressesList.addressList
                                            join zaposlen in dataContextInstance.zaposlens
                                            on ip_adresar.Oib equals zaposlen.zaposlenik
                                            join tablicna_privilegija in dataContextInstance.tablicna_privilegijas
                                            on zaposlen.radno_mjesto equals tablicna_privilegija.radno_mjesto
                                            where ip_adresar.EndPoint.Equals(address)
                                            &&
                                            tablicna_privilegija.operacija > 0
                                            select tablicna_privilegija.naziv_tablice).ToList();
        }

        public void InterpretXMLData(string XMLData, System.Net.IPEndPoint address, bool isClientSide = true)
        {
            XDocument doc = XDocument.Parse(XMLData);

            var datagroups = doc.Element("data").Elements();
            bool isAvailabilityCheck = false;
            Nullable<int> generatedId = null;
            foreach (var datagroup in datagroups)
            {
                char action = datagroup.Attribute("action").Value[0];
                if (datagroup.Elements().Count() == 0)
                {
                    if (datagroups.Count() == 1)
                    {
                        entityNamesWithReferencesToBelongingDataStores["tablica"].Add("tmp");
                        DataHandler.ChangesCommited = true;
                        entityNamesWithReferencesToBelongingDataStores["tablica"].Remove("tmp");
                    }
                    continue;
                }
                string entityName = datagroup.Elements().First().Name.LocalName;
                switch (entityName)
                {
                    case "senzor_temperature":
                        if (!isClientSide)
                        {
                            if (ArduinoPort != null)
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
                            int temperatura;
                            if (int.TryParse(datagroup.Elements().First().Value, out temperatura)) {
                                Temperatura = temperatura;
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show(datagroup.Elements().First().Value);
                                Temperatura = -1;
                            }
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
                            ResponseForSending = AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("provjeri_dostupnost"));
                        }
                        else
                        {
                            var addressOibPair = ClientsAddressesList.addressList.Where(x => x.EndPoint.Equals(address));
                            if (addressOibPair.Count() != 0)
                            {
                                addressOibPair.First().UpdateTimeOfLastAnswer();
                            }
                        }
                        isAvailabilityCheck = true;
                        break;
                    case "prijava":
                        if (!isClientSide)
                        {
                            XElement prijavaPodaci = datagroup.Element("prijava");
                            var queryResult = (from korisnicki_racun in dataContextInstance.korisnicki_racuns
                                                              join osoba in dataContextInstance.osobas
                                                              on korisnicki_racun.zaposlenik equals osoba.oib
                                                              where
                                                              (
                                                                  korisnicki_racun.korisnicko_ime.Equals(prijavaPodaci.Element("korisnicko_ime").Value)
                                                                  || korisnicki_racun.zaposlenik.Equals(prijavaPodaci.Element("oib").Value)
                                                              )
                                                              select new { osoba , korisnicki_racun.lozinka });
                            bool userWithProvidedUsernameOrOibExists = false;
                            try
                            {
                                userWithProvidedUsernameOrOibExists = Convert.ToBoolean(queryResult.Count());
                            }
                            catch
                            {
                                System.Windows.Forms.MessageBox.Show("Server with database does not reply.");
                            }
                            
                            if (userWithProvidedUsernameOrOibExists && HashPasswordUsingSHA1Algorithm(prijavaPodaci.Element("lozinka").Value) == queryResult.First().lozinka.TrimEnd(' '))
                            {
                                string userOib = queryResult.First().osoba.oib;
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
                                    ResponseForSending = AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("prijava", ConvertObjectsToXMLData(queryResult.First().osoba), attributes));
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
                                LoggedUser = new osoba()
                                {
                                    oib = infoAboutLoginAttempt.Element("osoba").Element("oib").Value,
                                    ime = infoAboutLoginAttempt.Element("osoba").Element("ime").Value,
                                    prezime = infoAboutLoginAttempt.Element("osoba").Element("prezime").Value
                                };
                                UserLoginState = (byte)LoginState.success;
                                IsConfirmationOfPreviousRequest = true;
                            }
                            else
                            {
                                UserLoginState = (byte)LoginState.error;
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
                            IQueryable<int> queryResult = from osoba in dataContextInstance.osobas
                                                           where osoba.oib == registracijaPodaci.Element("oib").Value
                                                           select 1;
                            if (queryResult.Count() == 0)
                            {
                                osoba noviZaposlenik = new osoba()
                                {
                                    oib = registracijaPodaci.Element("oib").Value,
                                    ime = registracijaPodaci.Element("ime").Value,
                                    prezime = registracijaPodaci.Element("prezime").Value
                                };
                                dataContextInstance.osobas.InsertOnSubmit(noviZaposlenik);
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
                            if (entityRelationships == null)
                            {
                                entityRelationships = GetNonEntityQueryResult("SELECT * FROM prikazi_sve_ovisnosti_medju_tablicama;");
                            }
                            var buttonEntities = GetListOfAccessibleEntityTypes(address);
                            var otherEntities = entityRelationships.Where(x => buttonEntities.Contains(x["FK_Table"].ToString())).Select(x => x["PK_Table"].ToString()).Except(buttonEntities);
                            Dictionary<string, string> atributes = new Dictionary<string, string>();
                            atributes.Add("menu", "yes");
                            ResponseForSending = AddHeaderInfoToXMLDatagroup(
                                String.Join("", buttonEntities.Select(x => ConvertNonObjectDataIntoXMLData("tablica", x, atributes)))
                                + String.Join("", otherEntities.Select(x => ConvertNonObjectDataIntoXMLData("tablica", x)))
                                );
                        }
                        else
                        {
                            foreach (var tablica in datagroup.Elements())
                            {
                                if (datagroup.Elements().Last() == tablica)
                                {
                                    ChangesCommited = true;
                                }
                                entityNamesWithReferencesToBelongingDataStores["tablica"].Add(tablica.Value);
                                if (tablica.Attribute("menu") != null)
                                {
                                    entityNamesForButtons.Add(tablica.Value);
                                }
                            }
                        }
                        break;
                    default:
                        if (isClientSide || IsUserPrivilegedToDoAnAction(address, entityName, action))
                        {
                            if (entityAutoIncrementColumns == null)
                            {
                                entityAutoIncrementColumns = GetNonEntityQueryResult(@"SELECT OBJECT_NAME(object_id) as ""table"", name as ""column"" FROM sys.identity_columns WHERE OBJECT_SCHEMA_NAME(object_id)='dbo';");
                            }
                            if (!isClientSide && action == 'C' && entityAutoIncrementColumns.Any(x => x["table"].ToString() == entityName))
                            {
                                object objWithAutoIncProp = null;
                                var type = Assembly.GetExecutingAssembly().GetTypes().SingleOrDefault(t => t.Name == entityName);
                                var ctors = type.GetConstructors();
                                objWithAutoIncProp = ctors[0].Invoke(new object[] { });
                                AssignObjectsProperties(objWithAutoIncProp, datagroup.Elements().First());
                                dataContextInstance.GetTable(type).InsertOnSubmit(objWithAutoIncProp);
                                dataContextInstance.SubmitChanges();

                                string propName = entityAutoIncrementColumns.Where(x => x["table"].ToString() == entityName).Select(x => x["column"]).First().ToString();

                                generatedId = (int)type.GetProperty(propName).GetValue(objWithAutoIncProp);
                                ConstructBaseOfMessageContentForSending(AddHeaderInfoToXMLDatagroup(ConvertObjectsToXMLData(objWithAutoIncProp), 'C'));
                                continue;
                            }
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
                                        if (generatedId.HasValue)
                                        {
                                            if (type.Name == "otpremnica")
                                            {
                                                type.GetProperty("racun").SetValue(sth, generatedId.Value);
                                            }
                                        }
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
                                    if (datagroup == datagroups.Last() && redak == datagroup.Elements().Last())
                                    {
                                        StoreReceivedDataIntoFormsLists(action, sth, oldValIfUpdating, true);
                                    }
                                    else
                                    {
                                        StoreReceivedDataIntoFormsLists(action, sth, oldValIfUpdating);
                                    }
                                }

                            }
                        }

                        break;
                }
                if (action != 'R')
                {
                    if (!isClientSide)
                    {
                        try
                        {
                            dataContextInstance.SubmitChanges();

                            if (generatedId.HasValue)
                            {
                                if (entityName == "otpremnica")
                                {
                                    ConstructBaseOfMessageContentForSending(datagroup.ToString(SaveOptions.DisableFormatting).Replace("<racun old=\"\"></racun>", "<racun old=\"\">" + generatedId.Value.ToString() + "</racun>"));
                                }
                                generatedId = null;
                            }
                            else
                            {
                                ConstructBaseOfMessageContentForSending(datagroup.ToString(SaveOptions.DisableFormatting));
                            }
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
                                ConstructBaseOfMessageContentForSending(datagroup.ToString(SaveOptions.DisableFormatting));
                                string changesPerformedByTrigger = ex.Message.Substring(successIdentifier.Length);
                                ResponseForSending += changesPerformedByTrigger;
                            }
                        }
                    }
                }

            }
            if (!isClientSide)
            {
                if (sendToAll)
                {
                    IPAddressesOfDestinations = ClientsAddressesList.addressList.Select(x => x.EndPoint).ToArray();
                }
                else
                {
                    IPAddressesOfDestinations = new System.Net.IPEndPoint[1];
                    IPAddressesOfDestinations[0] = address;
                    IsConfirmationOfPreviousRequest = !isAvailabilityCheck ? false : true;
                }
            }
            else
            {
                IPAddressesOfDestinations = new System.Net.IPEndPoint[1];
                IPAddressesOfDestinations[0] = address;
                IsConfirmationOfPreviousRequest = !isAvailabilityCheck ? true : false;
            }
        }

        public static string HashPasswordUsingSHA1Algorithm(string password)
        {
            return String.Join("", SHA1.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password.ToCharArray())).Select(x => String.Format("{0:X}", x)));
        }

        private void ConstructBaseOfMessageContentForSending(string XMLData)
        {
            ResponseForSending += XMLData;
            sendToAll = true;
        }

        private bool AreObjectsEqual(object obj, object obj2)
        {
            if (obj == null && obj2 == null)
            {
                return true;
            }
            else if (obj == null || obj2 == null)
            {
                return false;
            }
            else if (obj.GetType() != obj2.GetType())
            {
                return false;
            }

            foreach (var prop in obj.GetType().GetProperties())
            {
                if (prop.GetValue(obj) == null && prop.GetValue(obj2) == null)
                {
                    continue;
                }
                else if (prop.GetValue(obj) == null || prop.GetValue(obj2) == null)
                {
                    return false;
                }
                else
                {
                    if (prop.PropertyType.Name == "DateTime")
                    {
                        if (((DateTime)prop.GetValue(obj)).Date != ((DateTime)prop.GetValue(obj2)).Date)
                        {
                            //return false;
                        }
                    }
                    else if (!prop.GetValue(obj).Equals(prop.GetValue(obj2)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private object GetObjectFromList(object needle, BindingList<object> list)
        {
            foreach (var elem in list)
            {
                if (AreObjectsEqual(needle, elem))
                {
                    return elem;
                }
            }
            return null;
        }

        private int CompareObjectsAlphabetically(object obj1, object obj2)
        {
            foreach (var prop in obj1.GetType().GetProperties())
            {
                if (prop.GetValue(obj1) == null && prop.GetValue(obj2) == null)
                {
                    continue;
                }
                else
                {
                    if (prop.GetValue(obj1) == null)
                    {
                        return -1;
                    }
                    if (prop.GetValue(obj2) == null)
                    {
                        return 1;
                    }
                }
                string val1 = prop.GetValue(obj1).ToString();
                string val2 = prop.GetValue(obj2).ToString();
                if (Regex.IsMatch(val1, @"^\d+") && Regex.IsMatch(val2, @"^\d+")) {
                    long numericVal1 = long.Parse(Regex.Match(val1, @"^\d+").Value);
                    long numericVal2 = long.Parse(Regex.Match(val2, @"^\d+").Value);
                    if (numericVal1 != numericVal2)
                    {
                        return numericVal1 > numericVal2 ? 1 : -1;
                    }
                }
                int strCmpResult = String.Compare(val1, val2);
                if (strCmpResult != 0)
                {
                    return strCmpResult > 0 ? 1 : -1;
                }
            }
            return 0;
        }

        private int GetAppropriatePositionInListForInsertion(object obj, BindingList<object> list)
        {
            int listSize = list.Count();
            if (listSize == 0)
            {
                return 0;
            }
            else if (listSize == 1)
            {
                if (CompareObjectsAlphabetically(obj, list[0]) > 0) {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                int startPointOfAnalyzedRange = 0;
                int endPointOfAnalyzedRange = listSize - 1;
                int insertionIndex = 0;
                bool endLoop = false;
                while (startPointOfAnalyzedRange <= endPointOfAnalyzedRange)
                {
                    insertionIndex = (endPointOfAnalyzedRange + startPointOfAnalyzedRange) >> 1;
                    switch (CompareObjectsAlphabetically(obj, list[insertionIndex]))
                    {
                        case 0:
                            endLoop = true;
                            break;
                        case 1:
                            startPointOfAnalyzedRange = insertionIndex + 1;
                            break;
                        default:
                            endPointOfAnalyzedRange = insertionIndex - 1;
                            break;
                    }
                    if (endLoop)
                    {
                        break;
                    }
                }

                if (insertionIndex <= 0)
                {
                    insertionIndex = 0;
                }
                else if (insertionIndex >= listSize)
                {
                    insertionIndex = listSize;
                }
                else
                {
                    if (CompareObjectsAlphabetically(list[insertionIndex], obj) == -1)
                    {
                        insertionIndex++;
                    }
                }
                return insertionIndex;
            }
        }

        public void StoreReceivedDataIntoFormsLists(char action, object obj, object oldObjIfUpdate = null, bool lastElement = false)
        {
            if (lastElement)
            {
                ChangesCommited = true;
            }
            string objectTypename = obj.GetType().Name;
            if (entityNamesWithReferencesToBelongingDataStores.ContainsKey(objectTypename))
            {
                switch (action)
                {
                    case 'C':
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Insert(GetAppropriatePositionInListForInsertion(obj, entityNamesWithReferencesToBelongingDataStores[objectTypename]), obj);
                        break;
                    case 'D':
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Remove(GetObjectFromList(oldObjIfUpdate, entityNamesWithReferencesToBelongingDataStores[objectTypename]));
                        break;
                    case 'U':
                        ChangesCommited = false;
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Remove(GetObjectFromList(oldObjIfUpdate, entityNamesWithReferencesToBelongingDataStores[objectTypename]));
                        if (lastElement)
                        {
                            ChangesCommited = true;
                        }
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Insert(GetAppropriatePositionInListForInsertion(obj, entityNamesWithReferencesToBelongingDataStores[objectTypename]), obj);
                        break;
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
                string oibPrimatelja = primljenaPoruka.Substring(primljenaPoruka.IndexOf(oibIdentifier) + oibIdentifier.Length).TrimEnd();
                IPAddressesOfDestinations = ClientsAddressesList.addressList.Where(x => x.Oib == oibPrimatelja).Select(x => x.EndPoint).ToArray();
                if (HasErrorOccurred)
                {
                    return;
                }
                ResponseForSending = AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("senzor_temperature", temperatura.ToString()));
            }
            else if (primljenaPoruka.StartsWith("NOTIFY"))
            {
                IQueryable<string> otpremnicari = from zaposlen in dataContextInstance.zaposlens
                                   join radno_mjesto in dataContextInstance.radno_mjestos
                                   on zaposlen.radno_mjesto equals radno_mjesto.id
                                   where zaposlen.datum_zavrsetka == null && radno_mjesto.naziv == "otpremitelj"
                                   select zaposlen.zaposlenik;
                IPAddressesOfDestinations = ClientsAddressesList.addressList.Where(x => otpremnicari.Contains(x.Oib)).Select(x => x.EndPoint).ToArray();
                ResponseForSending = AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("pristiglo_vozilo", ""));
            }
        }

        private void PosaljiZahtjevZaIscitavanjemTemperatureBitumenskeMjesavine(string oibZahtjevatelja)
        {
            try
            {
                ArduinoPort.WriteLine("temperatura&OIB=" + oibZahtjevatelja);
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
            try
            {
                dataContextInstance = new DataClasses1DataContext();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ClearCurrentDataContext()
        {
            dataContextInstance.Dispose();
        }

        void IDisposable.Dispose()
        {

        }

        public static string SerializeUpdatedObject(object oldObj, object newObj)
        {
            string entityName = oldObj.GetType().Name;
            string str = "<" + entityName + ">";
            foreach (PropertyInfo info in oldObj.GetType().GetProperties())
            {
                if (info.CanRead)
                {
                    str += "<" + info.Name + " old=\"";
                    if (info.GetValue(oldObj) != null)
                    {
                        str += info.GetValue(oldObj).ToString();
                    }
                    str += "\">";
                    if (info.GetValue(newObj) != null)
                    {
                        str += info.GetValue(newObj).ToString();
                    }
                    str += "</" + info.Name + ">";
                }
            }
            str += "</" + entityName + ">";
            return str;
        }
    }
}

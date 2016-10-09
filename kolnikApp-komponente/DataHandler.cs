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
    /// <summary>
    /// Klasa za rad s podacima, te za komunikaciju s bazom podataka
    /// </summary>
    public class DataHandler : IDisposable
    {
        /// <summary>
        /// Šalju li se svima podaci za slanje
        /// </summary>
        private bool sendToAll = false;

        /// <summary>
        /// Stanja koja se mogu pojaviti prilikom pokušaja prijave u sustav
        /// </summary>
        public enum LoginState
        {
            waiting = 0,
            success = 1,
            invalidCredentials = 2,
            dbInaccessible = 4,
            accountInUse = 8
        }

        /// <summary>
        /// Trenutno stanje korisnika tokom pokušaja prijave u sustav
        /// </summary>
        public static volatile LoginState UserLoginState;

        /// <summary>
        /// Jesu li sve promjene učinjene nad bazom
        /// </summary>
        private static volatile bool changesCommited = false;

        /// <summary>
        /// Jesu li sve promjene učinjene nad bazom
        /// </summary>
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

        /// <summary>
        /// Podaci prijavljenog korisnika
        /// </summary>
        private static osoba loggedUser;

        /// <summary>
        /// Podaci prijavljenog korisnika
        /// </summary>
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

        /// <summary>
        /// Temperatura koja se iščituje putem temperaturnog senzora s Arduino mikrokontrolera
        /// </summary>
        public static volatile int Temperatura = 0;

        /// <summary>
        /// Port i frekvencija na kojem aplikacija osluškuje i kontaktira spojeni Arduino mikrokontroler radi serijske komunikacije
        /// </summary>
        public static SerialPort ArduinoPort;

        /// <summary>
        /// Instanca podatkovnog konteksta
        /// </summary>
        private DataClasses1DataContext dataContextInstance;

        /// <summary>
        /// Da li se pojavila pogreška prilikom rada s podacima ili njihove pohrane
        /// </summary>
        public bool HasErrorOccurred = false;
        /// <summary>
        /// Opis potencijalno pojavljene pogreške
        /// </summary>
        public string ErrorInfo = null;
        /// <summary>
        /// Naziv vrste entiteta kod kojeg se je pojavila pogreška
        /// </summary>
        public string EntityOnWhichErrorRefers = null;
        /// <summary>
        /// Je li trenutno primljena poruka zapravo samo potvrda na prethodno zatraženi zahtje
        /// </summary>
        public bool IsConfirmationOfPreviousRequest = false;
        /// <summary>
        /// Šalje li se zapravo odgovor klijentu tek kada Arduino mikrokontroler izvrši obradu i pošalje odgovor
        /// </summary>
        public bool SendWhenMessageWillBeReceivedFromMicrocontroller = false;
        /// <summary>
        /// Sadržaj za slanje
        /// </summary>
        public string ResponseForSending;
        /// <summary>
        /// Lista odredišta na koje se treba poruka slati
        /// </summary>
        public System.Net.IPEndPoint[] IPAddressesOfDestinations = null;

        /// <summary>
        /// Kolekcija svih vrsta entiteta dostupnih korisniku za korištenje kao i liste svih instanci svakoga
        /// </summary>
        public static Dictionary<string, BindingList<object>> entityNamesWithReferencesToBelongingDataStores = null;
        /// <summary>
        /// Lista svih naziva entiteta koji su korisniku služe za formiranje tipki za pristup karticama za pregled i rad s podacima
        /// </summary>
        public static List<string> entityNamesForButtons = new List<string>();
        /// <summary>
        /// Kolekcija svih odnosa među vrstama entiteta (temelje se na postojanju  referencijalnog integriteta među tablicama)
        /// </summary>
        static List<Dictionary<string, object>> entityRelationships = null;
        /// <summary>
        /// Kolekcija tablica i njihovih atributa koji sadrže AutoIncrement svojstvo
        /// </summary>
        static List<Dictionary<string, object>> entityAutoIncrementColumns = null;

        /// <summary>
        /// Operacije koje korisnik može posjedovati nad radom s instancama određene vrste entiteta
        /// </summary>
        public enum Operations
        {
            C = 1,
            R = 2,
            U = 4,
            D = 8
        }

        /// <summary>
        /// Stanje u kojem se nalazi konstruiranje Update SQL naredbe
        /// </summary>
        private enum UpdateCommandPart
        {
            Assign = 1,
            Compare = 2,
            Finish = 3
        }

        /// <summary>
        /// Provjerava da li je proslijeđeni objekt zapravo kolekcija drugih objekata
        /// </summary>
        /// <param name="variable">Objekt čiji se tip želi ispitati</param>
        /// <returns>Istina ako je objekt kolekcija, inače laž</returns>
        private static bool IsCollection(object variable)
        {
            return variable.GetType().GetInterfaces().Any(
                i => i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IEnumerable<>)
            );
        }

        /// <summary>
        /// Serijalizira objekte u tekst XML formata
        /// </summary>
        /// <param name="instance">Objekt (može biti i kolekcija objekata) koji je potrebno serijalizirati</param>
        /// <returns>Tekst koji predočava serijalizirani objekt</returns>
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

        /// <summary>
        /// Dodaje roditeljski element svim serijaliziranim podacima jer na najvišoj razini DOM-a može biti samo jedan čvor
        /// </summary>
        /// <param name="XMLData">Serijalizirani podaci koji se žele omotati roditeljskim elementom</param>
        /// <returns>Serijalizirani podaci zajedno s omotačem</returns>
        public static string AddWrapperOverXMLDatagroups(string XMLData)
        {
            return "<data>" + XMLData + "</data>";
        }

        /// <summary>
        /// Dodaje operaciju koja definira što treba sa serijaliziranim objektima učiniti
        /// </summary>
        /// <param name="XMLData">Serijalizirani podaci</param>
        /// <param name="action">Operacija koja se treba učiniti nad serijaliziranim podacima (može biti slovo C, R, U ili D)</param>
        /// <returns>Serijalizirane podatke zajedno s oznakom operacije za koju su namijenjeni</returns>
        public static string AddHeaderInfoToXMLDatagroup(string XMLData, char action = 'R')
        {
            return "<datagroup action=\"" + action + "\">" + XMLData + "</datagroup>";
        }

        /// <summary>
        /// Stvara serijaliziran sadržaj entiteta čija klasa službeno ne postoji
        /// </summary>
        /// <param name="tagName">Naziv vrste entiteta</param>
        /// <param name="value">Vrijednost entiteta</param>
        /// <param name="attributes">Dodatni atributi koji će po XML standardu biti dodijeljeni uz sam čvor</param>
        /// <returns>Serijalizirani podaci proslijeđenog entiteta</returns>
        private static string ConvertNonObjectDataIntoXMLData(string tagName, string value = null, Dictionary<string,string> attributes = null)
        {
            return "<" + tagName + (attributes!=null?String.Join("", attributes.Select(x => " " + x.Key + "=\"" + x.Value + "\"")):"") + ">" + (value==null?"":value) + "</" + tagName + ">";
        }

        /// <summary>
        /// Kreira sadržaj poruke za testiranje prisutnosti korisnika
        /// </summary>
        /// <returns>Sadržaj poruke za testiranje prisutnosti korisnika</returns>
        public string CreateMessageForAvailabilityChecking()
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("provjeri_dostupnost")));
        }

        /// <summary>
        /// Kreira sadržaj poruke koji obuhvaća poruku o pogrešci koja se dogodila tokom rada s podacima
        /// </summary>
        /// <returns>Sadržaj poruke s pogreškom koja se dogodila</returns>
        public string ConstructErrorMessageContent()
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData(EntityOnWhichErrorRefers, ErrorInfo)));
        }

        /// <summary>
        /// Kreira sadržaj poruke za zahtjev temperature mjerene bitumenske mješavine
        /// </summary>
        /// <returns>Sadržaj poruke za zahtjev temperature</returns>
        public static string ConstructTemperatureRequest()
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("senzor_temperature"), 'R'));
        }

        /// <summary>
        /// Konstruira UPDATE SQL naredbu kojom se zamijeniti stari zapis s novim
        /// </summary>
        /// <param name="type">Tip objekta nad kojim se radi (tj. kojeg su sljedeća 2 parametra)</param>
        /// <param name="newObj">Instanca entiteta čije vrijednosti će zamijeniti stare vrijednosti mijenjane instance</param>
        /// <param name="oldObj">Instanca entiteta koja se mijenja</param>
        /// <returns>Sastavljena SQL Update naredba za izvršavanje ažuriranja zapisa u bazi s navedenim vrijednostima atributa</returns>
        private string GenerateCommandForUpdatingRecord(Type type, object newObj, object oldObj)
        {
            string commandForUpdatingRecord = "UPDATE " + type.Name;
            bool recordHasNotBeenChanged = true;
            for (UpdateCommandPart currState = UpdateCommandPart.Assign; !currState.HasFlag(UpdateCommandPart.Finish); currState++)
            {
                object currObjWorkingWith;
                string delimiter;
                string operatorForNull;
                if (currState.HasFlag(UpdateCommandPart.Assign))
                {
                    commandForUpdatingRecord += " SET ";
                    currObjWorkingWith = newObj;
                    delimiter = ",";
                    operatorForNull = "=";
                }
                else
                {
                    commandForUpdatingRecord += " WHERE ";
                    currObjWorkingWith = oldObj;
                    delimiter = " AND ";
                    operatorForNull = " IS ";
                }
                foreach (PropertyInfo info in type.GetProperties())
                {
                    if (info.CanWrite)
                    {
                        if (currState.HasFlag(UpdateCommandPart.Assign))
                        {
                            if ((info.GetValue(newObj) == null && info.GetValue(oldObj) == null))
                            {
                                continue;
                            }
                            else if ((info.GetValue(newObj) != null && info.GetValue(oldObj) != null) && info.GetValue(newObj).Equals(info.GetValue(oldObj)))
                            {
                                continue;
                            }
                            else
                            {
                                recordHasNotBeenChanged = false;
                            }
                        }
                        if (info.GetValue(currObjWorkingWith) == null)
                        {
                            commandForUpdatingRecord += info.Name + operatorForNull + "null" + delimiter;
                        }
                        else
                        {
                            string typeName;
                            if (info.PropertyType.IsGenericType && info.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            {
                                typeName = info.PropertyType.GetGenericArguments()[0].Name;
                            }
                            else
                            {
                                typeName = info.PropertyType.Name;
                            }
                            switch (typeName)
                            {
                                case "DateTime":
                                    if (currState.HasFlag(UpdateCommandPart.Compare)) //ovaj način se vrši jer je razlika u formatu zapisa u bazi i objekata u .netu (u bp s milisekundama, tu ne)
                                    {
                                        break;  //pretpostavka da datum nije PK (jedinstvena značajka zapisa)
                                    }
                                    else
                                    {
                                        commandForUpdatingRecord += info.Name + "='" + info.GetValue(currObjWorkingWith).ToString() + "'" + delimiter;
                                    }
                                    break;
                                case "String":
                                    commandForUpdatingRecord += info.Name + "='" + info.GetValue(currObjWorkingWith).ToString() + "'" + delimiter;
                                    break;
                                default:
                                    commandForUpdatingRecord += info.Name + "=" + info.GetValue(currObjWorkingWith) + delimiter;
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
        
        /// <summary>
        /// Izvodi proslijeđenu SQL operaciju nad proslijeđenim zapisom
        /// </summary>
        /// <param name="action">SQL operacija koju je potrebno izvesti nad operandom (zapisom/objektom)</param>
        /// <param name="mainObj">Operand na kojeg se odnosi izvođenje operacije</param>
        /// <param name="oldValIfUpdating">Dodatni operand koji je obvezan ukoliko se vrši izvođenje Update SQL naredbe</param>
        private void PutRecordProcessingCommandInExecutionQueue(char action, object mainObj, object oldValIfUpdating = null)
        {
            Type type = mainObj.GetType();
            var tableInDataContext = dataContextInstance.GetTable(type);
            switch (action)
            {
                case 'C':
                    tableInDataContext.InsertOnSubmit(mainObj);
                    break;
                case 'U':
                    string commandForUpdatingRecord = GenerateCommandForUpdatingRecord(type, mainObj, oldValIfUpdating);
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
                    try
                    {
                        tableInDataContext.Attach(mainObj);
                    }
                    catch
                    {

                    }
                    tableInDataContext.DeleteOnSubmit(mainObj);
                    break;
            }
        }

        /// <summary>
        /// Dodjeljuje vrijednosti objektu na temelju zaprimljenog serijaliziranog objekta u XML formatu
        /// </summary>
        /// <param name="instance">Objekt (instanciran, ali najčešće neinicijaliziran) kojem se dodijeljuju vrijednosti</param>
        /// <param name="keyValuePairsOfEntity">Niz čvorova (s atributima instance entiteta) čije vrijednosti se dodijeljuju proslijeđenom objektu</param>
        /// <param name="assignOldValues">Da li se iščitavaju iz čvorova prijašnje vrijednosti atributa (vrijednosti atributa 'old') ili pak sadašnje (vrijednosti XML elementa)</param>
        private void AssignObjectsProperties(object instance, XElement keyValuePairsOfEntity, bool assignOldValues = false)
        {
            foreach (var keyValuePair in keyValuePairsOfEntity.Elements())
            {
                if (assignOldValues)
                {
                    SetProperty(instance, keyValuePair.Name.LocalName, keyValuePair.Attribute("old").Value);
                }
                else
                {
                    SetProperty(instance, keyValuePair.Name.LocalName, keyValuePair.Value);
                }
            }
        }

        /// <summary>
        /// Dodjeljuje navedenom objektu proslijeđenu vrijednost atributu s proslijeđenim nazivom
        /// </summary>
        /// <param name="instance">Instanca entiteta kojem se dodjeljuje vrijednost</param>
        /// <param name="propName">Naziv atributa kojem se dodjeljuje vrijednost</param>
        /// <param name="value">Vrijednost koja se dodjeljuje atributu s proslijeđenim nazivom</param>
        private void SetProperty(object instance, string propName, object value)
        {
            Type type = instance.GetType();
            foreach (PropertyInfo info in type.GetProperties())
            {
                if (info.Name == propName && info.CanWrite)
                {
                    if (value.Equals(""))
                    {
                        info.SetValue(instance, null);
                    }
                    else
                    {
                        TypeConverter converter = TypeDescriptor.GetConverter(info.PropertyType);
                        info.SetValue(instance, converter.ConvertFrom(value));
                    }
                }
            }
        }

        /// <summary>
        /// Provjerava da li je korisnik koji je poslao zahtjev za rad s podacima privilegiran za izvršenje definirane operacije nad definiranom tipu entiteta
        /// </summary>
        /// <param name="address">IP adresa i port korisnika od kojeg je zaprimljen zahtjev</param>
        /// <param name="entityName">Naziv tipa entiteta nad čijim instancama se želi vršiti zatražena operacija</param>
        /// <param name="action">Oznaka operacije koja se želi primijeniti nad instancama tipa entiteta čiji je naziv proslijeđen</param>
        /// <returns></returns>
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

        /// <summary>
        /// Dohvaća rezultate upita u listu rječnika (asocijativnih listi) radi dohvaćanja podataka za koje ne postoji definirani tip/klasa
        /// </summary>
        /// <param name="query">Znakovni niz koji predstavlja SQL upit koji je potrebno izvršiti</param>
        /// <returns>Lista rječnika (asocijativnih listi) koja predstavlja redove rezultata SQL upita</returns>
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

        /// <summary>
        /// Dohvaća sve vrste entiteta na čije instance korisnik može primijeniti neku od operaciju
        /// </summary>
        /// <param name="address">IP adresa i port korisnika za kojeg se želi ispitati dostupnost operacija</param>
        /// <returns>Lista naziva vrsta entiteta na čije instance korisnik može primijeniti neku od operacija</returns>
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

        /// <summary>
        /// Tumači sadržaj zaprimljene poruke, te pritom izvršava definiranu operaciju nad priloženim serijaliziranim zapisima (instancama entiteta)
        /// </summary>
        /// <param name="XMLData">Sadržaj zaprimljene poruke koji je potrebno interpretirati</param>
        /// <param name="address">IP adresa i port pošiljatelja zaprimljene poruke</param>
        /// <param name="isClientSide">Da li je aplikacija koja je pozvala funkciju iz ovog modula poslužiteljska ili klijentska</param>
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
                    if (datagroups.Last() == datagroup)
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
                            bool userWithProvidedUsernameOrOibExists = false;
                            IList<dynamic> queryResult = null;
                            try
                            {
                                queryResult = (from korisnicki_racun in dataContextInstance.korisnicki_racuns
                                                   join osoba in dataContextInstance.osobas
                                                   on korisnicki_racun.zaposlenik equals osoba.oib
                                                   where
                                                   (
                                                       korisnicki_racun.korisnicko_ime.Equals(prijavaPodaci.Element("korisnicko_ime").Value)
                                                       || korisnicki_racun.zaposlenik.Equals(prijavaPodaci.Element("oib").Value)
                                                   )
                                                   select new { osoba, korisnicki_racun.lozinka }).ToArray();
                            }
                            catch
                            {
                                HasErrorOccurred = true;
                                ErrorInfo = "db-inaccessible";
                                EntityOnWhichErrorRefers = "prijava";
                                IPAddressesOfDestinations = new System.Net.IPEndPoint[1];
                                IPAddressesOfDestinations[0] = address;
                                return;
                            }
                            userWithProvidedUsernameOrOibExists = Convert.ToBoolean(queryResult.Count);

                            if (userWithProvidedUsernameOrOibExists && HashPasswordUsingSHA1Algorithm(prijavaPodaci.Element("lozinka").Value) == queryResult.First().lozinka.TrimEnd(' '))
                            {
                                string userOib = queryResult[0].osoba.oib;
                                if (ClientsAddressesList.CheckIfUserWithCertainOibIsAlreadyLoggedIn(userOib))
                                {
                                    HasErrorOccurred = true;
                                    ErrorInfo = "account-in-use";
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
                                ErrorInfo = "invalid-credentials";
                                EntityOnWhichErrorRefers = entityName;
                            }
                        }
                        else
                        {
                            XElement infoAboutLoginAttempt = datagroup.Element("prijava");
                            if (infoAboutLoginAttempt.Attribute("success") != null)
                            {
                                LoggedUser = new osoba()
                                {
                                    oib = infoAboutLoginAttempt.Element("osoba").Element("oib").Value,
                                    ime = infoAboutLoginAttempt.Element("osoba").Element("ime").Value,
                                    prezime = infoAboutLoginAttempt.Element("osoba").Element("prezime").Value
                                };
                                UserLoginState = LoginState.success;
                                IsConfirmationOfPreviousRequest = true;
                            }
                            else
                            {
                                switch (infoAboutLoginAttempt.Value)
                                {
                                    case "invalid-credentials":
                                        UserLoginState = LoginState.invalidCredentials;
                                        break;
                                    case "db-inaccessible":
                                        UserLoginState = LoginState.dbInaccessible;
                                        break;
                                    case "account-in-use":
                                        UserLoginState = LoginState.accountInUse;
                                        break;
                                }
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

        /// <summary>
        /// Kriptira proslijeđenu lozinku koristeći SHA1 algoritam sažimanja
        /// </summary>
        /// <param name="password">Lozinka u čitljivom obliku koju je potrebno kriptirati</param>
        /// <returns>Kriptirana lozinka</returns>
        public static string HashPasswordUsingSHA1Algorithm(string password)
        {
            return String.Join("", SHA1.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password.ToCharArray())).Select(x => String.Format("{0:X}", x)));
        }

        /// <summary>
        /// Dodaje sadržaj sa svim zapisima koji su prethodno dodani, izbrisani ili izmijenjeni u bazi podataka na postojeći sadržaj poruke za slanje
        /// </summary>
        /// <param name="XMLData">Sadržaj sa svim zapisima koji su prethodno dodani, izbrisani ili izmijenjeni u bazi podataka</param>
        private void ConstructBaseOfMessageContentForSending(string XMLData)
        {
            ResponseForSending += XMLData;
            sendToAll = true;
        }

        /// <summary>
        /// Ispituje da li su uspoređivani objekti jednaki, odnosno da li uspoređivane instance entiteta posjeduju jednake vrijednosti svih atributa
        /// </summary>
        /// <param name="obj">Prvi objekt (instanca entiteta) koji se uspoređuje</param>
        /// <param name="obj2">Drugi objekt (instanca entiteta) koji se uspoređuje</param>
        /// <returns>Logička istina ukoliko se proslijeđeni objekti (instance entiteta) podudaraju</returns>
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

        /// <summary>
        /// Dohvaća element liste s identičnim vrijednostima atributa kao što posjeduje proslijeđeni pretraživani objekt sa svojim (definiranim) vrijednostima
        /// </summary>
        /// <param name="needle">Objekt s (definiranim) vrijednostima atributa kojim se pretražuje element liste s identičnim vrijednostima atributa</param>
        /// <param name="list">Lista u kojoj se traži navedeni element</param>
        /// <returns>Pronađeni element unutar proslijeđene liste</returns>
        private object GetObjectFromList(object needle, IList<object> list)
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

        /// <summary>
        /// Uspoređuje dva proslijeđena znakovna niza pri čemu se vodi računa da se numerički znakovi unutar njih uspoređuju kao brojevi (tako je rb102 a > rb10 a, a po klasičnoj usporedbi znakova bi važilo suprotno)
        /// </summary>
        /// <param name="s1">Prvi znakovni izraz kojeg treba usporediti</param>
        /// <param name="s2">Drugi znakovni izraz kojeg treba usporediti</param>
        /// <returns>-1 ako je prvi izraz alfanumerički prije drugog, 0 ako su jednaki, a 1 ako je prvi izraz alfanumerički poslije drugog</returns>
        private short CompareValuesNumericallyIfPossible(string s1, string s2)
        {
            short len1 = (short)s1.Length;
            short len2 = (short)s2.Length;
            short marker1 = 0;
            short marker2 = 0;

            // Walk through two the strings with two markers.
            while (marker1 < len1 && marker2 < len2)
            {
                char ch1 = s1[marker1];
                char ch2 = s2[marker2];

                // Some buffers we can build up characters in for each chunk.
                char[] space1 = new char[len1];
                short loc1 = 0;
                char[] space2 = new char[len2];
                short loc2 = 0;

                // Walk through all following characters that are digits or
                // characters in BOTH strings starting at the appropriate marker.
                // Collect char arrays.
                do
                {
                    space1[loc1++] = ch1;
                    marker1++;

                    if (marker1 < len1)
                    {
                        ch1 = s1[marker1];
                    }
                    else
                    {
                        break;
                    }
                } while (char.IsDigit(ch1) == char.IsDigit(space1[0]));

                do
                {
                    space2[loc2++] = ch2;
                    marker2++;

                    if (marker2 < len2)
                    {
                        ch2 = s2[marker2];
                    }
                    else
                    {
                        break;
                    }
                } while (char.IsDigit(ch2) == char.IsDigit(space2[0]));

                // If we have collected numbers, compare them numerically.
                // Otherwise, if we have strings, compare them alphabetically.
                string str1 = new string(space1);
                string str2 = new string(space2);

                int result;

                if (char.IsDigit(space1[0]) && char.IsDigit(space2[0]))
                {
                    try
                    {
                        long thisNumericChunk = long.Parse(str1);
                        long thatNumericChunk = long.Parse(str2);
                        result = thisNumericChunk.CompareTo(thatNumericChunk);
                    }
                    catch
                    {
                        double thisNumericChunk = double.Parse(str1);
                        double thatNumericChuck = double.Parse(str2);
                        result = thisNumericChunk.CompareTo(thatNumericChuck);
                    }
                }
                else
                {
                    result = str1.CompareTo(str2);
                }

                if (result != 0)
                {
                    return (short)Math.Sign(result);
                }
            }
            return (short)Math.Sign(len1 - len2);
        }

        /// <summary>
        /// Uspoređuje proslijeđene objekte promatrajući njihove vrijednosti atributa - ukoliko vrijednosti atributa su znakovni nizovi koji sadrže brojke, brojke se iz njih izvlače i uspoređuju numerički
        /// </summary>
        /// <param name="obj1">Prvi objekt (instanca entiteta) koji se uspoređuje</param>
        /// <param name="obj2">Drugi objekt (instanca entiteta) koji se uspoređuje</param>
        /// <returns>-1 ako je prvi objekt alfanumerički prije drugog, 0 ako su jednaki, a 1 ako je prvi objekt alfanumerički poslije drugog</returns>
        private short CompareObjectsAlphanumerically(object obj1, object obj2)
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
                short result = CompareValuesNumericallyIfPossible(val1, val2);
                if (result != 0)
                {
                    return result;
                }
            }
            return 0;
        }

        /// <summary>
        /// Vraća prikladnu poziciju na koju treba smjestiti proslijeđeni objekt u navedenu listu
        /// </summary>
        /// <param name="obj">Objekt koji se želi smjestiti</param>
        /// <param name="list">Lista u koju se smješta objekt</param>
        /// <returns>Pozicija (indeks) u listi na koju je potrebno pohraniti proslijeđeni objekt</returns>
        private int GetAppropriatePositionInListForInsertion(object obj, IList<object> list)
        {
            int listSize = list.Count();
            if (listSize == 0)
            {
                return 0;
            }
            else if (listSize == 1)
            {
                if (CompareObjectsAlphanumerically(obj, list[0]) > 0) {
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
                    switch (CompareObjectsAlphanumerically(obj, list[insertionIndex]))
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
                    if (CompareObjectsAlphanumerically(list[insertionIndex], obj) == -1)
                    {
                        insertionIndex++;
                    }
                }
                return insertionIndex;
            }
        }

        /// <summary>
        /// Pohranjuje, briše ili modificira proslijeđeni objekt u listu globalnog rječnika namijenjenu za pohranu instanci entiteta ekvivalentnih tipu navedenog objekta
        /// </summary>
        /// <param name="action">Operacija koju je potrebno izvršiti s proslijeđenim objektom nad listom u memoriji</param>
        /// <param name="obj">Objekt s kojim se djeluje na listu u memoriji</param>
        /// <param name="oldObjIfUpdate">Objekt sa starim vrijednostima ukoliko je riječ o operaciji modificiranja</param>
        /// <param name="lastElement">Istina ukoliko je riječ o zadnjoj obradi iz zaprimljenog odgovora (čime je potrebno okinuti događaj kako bi se promjene ažurirale na prezentacijskom sloju)</param>
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
                        entityNamesWithReferencesToBelongingDataStores[objectTypename].Remove(GetObjectFromList(obj, entityNamesWithReferencesToBelongingDataStores[objectTypename]));
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

        /// <summary>
        /// Kreira sadržaj poruke sa zahtjevom za slanje svih instanci svih vrsti entiteta koji su dostupni za pošiljatelja
        /// </summary>
        /// <returns>Sadržaj poruke s navedenim zahtjevom</returns>
        public string ConstructMessageWithRequestForSendingInstancesOfUsedEntities()
        {
            return AddWrapperOverXMLDatagroups(String.Join("", entityNamesWithReferencesToBelongingDataStores.Keys.Select(x => AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData(x), 'R'))));
        }

        /// <summary>
        /// Kreira sadržaj poruke s podacima za prijavu u sustav
        /// </summary>
        /// <param name="identity">Korisničko ime ili broj OIB-a</param>
        /// <param name="password">Lozinka za prijavu u sustav s navedenim korisničkim imenom/OIB-om</param>
        /// <param name="isIdentityUsername">Istina ukoliko prvi parametar predstavlja korisničko ime; inače neistina</param>
        /// <returns>Sadržaj poruke s podacima za prijavu u sustav</returns>
        public string ConstructLoginMessageContent(string identity, string password, bool isIdentityUsername)
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("prijava",
                ConvertNonObjectDataIntoXMLData("oib", isIdentityUsername ? "" : identity) +
                ConvertNonObjectDataIntoXMLData("korisnicko_ime", isIdentityUsername ? identity : "") +
                ConvertNonObjectDataIntoXMLData("lozinka", password)
                )));
        }

        /// <summary>
        /// Kreira sadržaj za odjavu iz sustava (preporučljivo kako bi odmah bila moguća prijava s tim istim korisničkim računom)
        /// </summary>
        /// <returns>Sadržaj poruke sa zahtjevom za odjavu iz sustava</returns>
        public string ConstructLogoutMessageContent()
        {
            return AddWrapperOverXMLDatagroups(AddHeaderInfoToXMLDatagroup(ConvertNonObjectDataIntoXMLData("odjava")));
        }

        /// <summary>
        /// Instancira objekt DataHandler klase pri čemu se definiraju kulturološke značajke Sjedinjenih Američkih Država
        /// </summary>
        public DataHandler()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        /// <summary>
        /// Obrađuje podatke zaprimljene putem serijske komunikacije (tj. od strane mikrokontrolera)
        /// </summary>
        /// <param name="primljenaPoruka">Sadržaj poruke koja je pristigla (tj. koju je mikrokontroler poslao)</param>
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

        /// <summary>
        /// Pokušava poslati mikrokontroleru putem serijske komunikacije zahtjev za iščitavanjem temperature
        /// </summary>
        /// <param name="oibZahtjevatelja"></param>
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

        /// <summary>
        /// Pokušava inicijalizirati podatkovni kontekst kako bi bio moguć daljnji rad s podacima iz baze podataka
        /// </summary>
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

        /// <summary>
        /// Oslobađa do sada korišteni podatkovni kontekst
        /// </summary>
        public void ClearCurrentDataContext()
        {
            dataContextInstance.Dispose();
        }

        /// <summary>
        /// Oslobađa resurse zauzete od oslobađanog/uništavanog objekta (poziva se i ujedno je nužna ukoliko se objekt klase instancira pomoću using bloka)
        /// </summary>
        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Serijalizira objekt koji treba ažurirati zajedno sa objektom koji predstavlja stanje nakon ažuriranja
        /// </summary>
        /// <param name="oldObj">Objekt prije ažuriranja</param>
        /// <param name="newObj">Objekt poslije ažuriranja</param>
        /// <returns>Tekst koji predstavlja serijalizirane objekte (objekt prije i objekt nakon modificiranja)</returns>
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

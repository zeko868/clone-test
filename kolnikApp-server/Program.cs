using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using kolnikApp_komponente;

namespace kolnikApp_server
{
    class Program
    {
        //nakon što završi izrada softvera, potrebno je kolnikApp-komponente kompajlirati kao Release verziju, kao što je
        //ujedno potrebno nakon njenog rebuildanja u projektu aplikacije za klijenta i poslužitelja referencirati .DLL
        //iz Release foldera (drugi dio vise nije potreban jer se vrsi conditional referencing)
        static void Main(string[] args)
        {
            SerialPort arduinoPort = new SerialPort();
            arduinoPort.PortName = "COM5";
            arduinoPort.BaudRate = 9600;
            switch (args.Length)
            {
                case 2:
                    int baudRate;
                    if (!int.TryParse(args[1], out baudRate))
                    {
                        Console.WriteLine("Ako se već navodi drugi parametar, on mora biti cjelobrojna vrijednost");
                        return;
                    }
                    arduinoPort.BaudRate = baudRate;
                    goto case 2;
                case 1:
                    switch (args[0])
                    {
                        case "\\h":
                        case "/h":
                        case "--h":
                        case "-h":
                        case "--help":
                        case "-help":
                            Console.WriteLine("Popis parametara:");
                            Console.WriteLine("\tnazivPorta - opcionalan (default: COM6)");
                            Console.WriteLine("\tbrojPulsevaUSekundi - opcionalan (default: 9600)");
                            return;
                        default:
                            arduinoPort.PortName = args[0];
                            break;
                    }
                    break;
                default:
                    break;
            }
            try
            {
                arduinoPort.Open();
                arduinoPort.DataReceived += CommunicationHandler.DataThroughSerialCommunicationHasBeenReceived;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

/*            zaposlenik a = new zaposlenik
            {
                ime = "sda",
                prezime = "dsfsdf",
                oib = "13357421677"
            };
            zaposlenik[] sd = new zaposlenik[1];
            sd[0] = a;
            List<zaposlenik> df = new List<zaposlenik>();
            df.Add(a);
            DataHandler dfdgf = new DataHandler();
            dfdgf.ConvertObjectsToXMLData(sd);
            string xmlDATA =
              @"<data>
                    <datagroup action=""U"">
                        <artikl>
                            <id old=""2"">2</id>
                            <naziv old=""AC 11 surf 50/70"">AC 11 surf 50/70</naziv>
                            <jedinicna_cijena old=""120.00"">120.00</jedinicna_cijena>
                            <jedinica_mjere old=""tona"">tona</jedinica_mjere>
                        </artikl>
                    </datagroup>
                </data>";

            DataHandler.arduinoPort = arduinoPort;
            DataHandler sth = new DataHandler();
            sth.InitializeDataContext();
            sth.InterpretXMLData(xmlDATA, null, false);
            sth.ClearCurrentDataContext();

            CommunicationHandler uticnica = new CommunicationHandler();


            List<object> l1 = new List<object>();
            l1.Add(new zaposlenik()
            {
                oib = "43535345325",
                prezime = "Šestak",
                ime = "Petar"
            });
            Dictionary<string, List<object>> abc = new Dictionary<string, List<object>>();
            abc["zaposlenik"] = l1;
            abc["zaposlenik"].Add(new zaposlenik()
            {
                oib = "35443634615",
                prezime = "Jelečki",
                ime = "Martin"
            });
            */


            do
            {
                Console.Write("> ");
                string inputString = Console.ReadLine();
                switch (inputString)
                {
                    case "exit":
                    case "quit":
                        return;
                    default:
                        break;
                }
            } while (true);

        }

    }
}

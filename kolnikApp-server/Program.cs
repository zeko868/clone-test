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
                DataHandler.ArduinoPort = arduinoPort;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            CommunicationHandler uticnica = new CommunicationHandler();

            do
            {
                Console.Write("> ");
                string inputString = Console.ReadLine();
                switch (inputString)
                {
                    case "exit":
                    case "quit":
                        return;
                    case "retry":
                        try
                        {
                            arduinoPort.Open();

                            DataHandler.ArduinoPort = arduinoPort;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "calibrate low":
                    case "calibrate high":
                    case "calibrate default":
                        try
                        {
                            arduinoPort.WriteLine(inputString);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Command you've entered is not valid!");
                        break;
                }
            } while (true);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using kolnikApp_komponente;
using System.Threading;

namespace kolnikApp_klijent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] parameters)
        {
            Thread.Sleep(1000);
            //kad se server i posluzitelj pokreću istovremeno u Visual Studiju,
            //tada unatoč postavljanja da se klijentska aplikacija pokreće prije serverske,
            //klijentska uspije prije zauzeti defaultni port
            CommunicationHandler sockObj = null;
            switch (parameters.Length)
            {
                case 0:
                    //ili čini spajanje na neki defaultni hostname (možda na Azureu?)
                    MessageBox.Show("Hostname ili IP adresa (ni port) nisu proslijeđeni prilikom pokretanja programa!");
                    return;
                case 1: // IP/hostname
                    sockObj = new CommunicationHandler(false, parameters[0]);
                    break;
                case 2: // IP/hostname i port
                    ushort portNum;
                    if (!ushort.TryParse(parameters[1], out portNum))
                    {
                        MessageBox.Show("Pod vrijednost porta aplikacije je unešena nevaljana vrijednost");
                        return;
                    }
                    sockObj = new CommunicationHandler(false, parameters[0], portNum);
                    break;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(sockObj));
        }
    }
}

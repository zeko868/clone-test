using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace kolnikApp_komponente
{
    /// <summary>
    /// Kontejner za pohranu podataka vezanih uz samog korisnika spojenog na server
    /// </summary>
    class ClientsAddress
    {
        /// <summary>
        /// OIB korisnika
        /// </summary>
        public string Oib;
        /// <summary>
        /// IP adresa i port korisnika
        /// </summary>
        public IPEndPoint EndPoint;
        /// <summary>
        /// Datum i vrijeme kada je korisnik zadnji put odgovorio na test prisutnosti
        /// </summary>
        public DateTime TimeOfLastAnswer;

        /// <summary>
        /// Konstruktor za stvaranje instance za pohranu podataka o aktivnom korisniku
        /// </summary>
        /// <param name="oib">OIB spojenog korisnika</param>
        /// <param name="endPoint">IP adresa i port spojenog korisnika</param>
        public ClientsAddress(string oib, IPEndPoint endPoint)
        {
            this.Oib = oib;
            this.EndPoint = endPoint;
            this.TimeOfLastAnswer = DateTime.Now;
        }

        /// <summary>
        /// Ažuriraj vrijeme zadnjeg odgovora na test prisutnosti na trenutno
        /// </summary>
        public void UpdateTimeOfLastAnswer()
        {
            this.TimeOfLastAnswer = DateTime.Now;
        }
    }
}

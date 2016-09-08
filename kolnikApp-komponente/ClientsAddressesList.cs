using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace kolnikApp_komponente
{
    /// <summary>
    /// Kolekcija podataka aktivnih korisnika
    /// </summary>
    class ClientsAddressesList
    {
        /// <summary>
        /// Lista u koju se pohranjuju podaci aktivnih korisnika
        /// </summary>
        static public List<ClientsAddress> addressList;

        /// <summary>
        /// Provjera je li trenutno već neki korisnik za proslijeđenim OIB-om već prijavljen
        /// </summary>
        /// <param name="oib">OIB korisnika čija se prisutnost želi ispitati</param>
        /// <returns>Istina ako se korisnik s navedenim OIB-om nalazi u listi, inače laž</returns>
        static public bool CheckIfUserWithCertainOibIsAlreadyLoggedIn(string oib)
        {
            return Convert.ToBoolean(addressList.Count(x => x.Oib.Equals(oib)));
        }

        /// <summary>
        /// Briše korisnika iz liste aktivnih korisnika
        /// </summary>
        /// <param name="endPoint">Korisnikova IP adresa i port</param>
        static public void UnregisterUserWithCertainIPAddress(IPEndPoint endPoint)
        {
            int pozicijaElementa = addressList.FindIndex(x => x.EndPoint.Equals(endPoint));
            if (pozicijaElementa != -1)
            {
                addressList.RemoveAt(pozicijaElementa);
            }
        }

        /// <summary>
        /// Dodaje korisnika u listu aktivnih korisnika
        /// </summary>
        /// <param name="oib">OIB korisnika koji se želi dodati u listu</param>
        /// <param name="endPoint">IP adresa i port korisnika koji se želi dodati u listu</param>
        static public void RegisterUser(string oib, IPEndPoint endPoint)
        {
            UnregisterUserWithCertainIPAddress(endPoint);  //u slucaju da je korisnik bio prijavljen, pukla mu je 'veza' sa posluziteljem, a da u medjuvremenu posluzitelj nije spoznao da korisnik vise nije aktivan
            addressList.Add(new ClientsAddress(oib, endPoint));
        }
    }
}

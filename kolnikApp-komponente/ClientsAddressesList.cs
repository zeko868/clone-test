using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace kolnikApp_komponente
{
    class ClientsAddressesList
    {
        static public List<ClientsAddress> addressList;

        static public bool CheckIfUserWithCertainOibIsAlreadyLoggedIn(string oib)
        {
            return Convert.ToBoolean(addressList.Count(x => x.Oib.Equals(oib)));
        }

        static public void UnregisterUserWithCertainIPAddress(IPEndPoint endPoint)
        {
            int pozicijaElementa = addressList.FindIndex(x => x.EndPoint.Equals(endPoint));
            if (pozicijaElementa != -1)
            {
                addressList.RemoveAt(pozicijaElementa);
            }
        }

        static public void RegisterUser(string oib, IPEndPoint endPoint)
        {
            UnregisterUserWithCertainIPAddress(endPoint);  //u slucaju da je korisnik bio prijavljen, pukla mu je 'veza' sa posluziteljem, a da u medjuvremenu posluzitelj nije spoznao da korisnik vise nije aktivan
            addressList.Add(new ClientsAddress(oib, endPoint));
        }
    }
}

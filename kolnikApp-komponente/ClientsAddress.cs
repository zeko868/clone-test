using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace kolnikApp_komponente
{
    class ClientsAddress
    {
        public string Oib;
        public IPEndPoint EndPoint;
        public DateTime TimeOfLastAnswer;

        public ClientsAddress(string oib, IPEndPoint endPoint)
        {
            this.Oib = oib;
            this.EndPoint = endPoint;
            this.TimeOfLastAnswer = DateTime.Now;
        }

        public void UpdateTimeOfLastAnswer()
        {
            this.TimeOfLastAnswer = DateTime.Now;
        }
    }
}

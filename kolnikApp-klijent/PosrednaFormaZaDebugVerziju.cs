using kolnikApp_komponente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp_klijent
{
    public class PosrednaFormaZaDebugVerziju : ApstraktnaForma
    {
        protected PosrednaFormaZaDebugVerziju() : base()
        {
        }

        protected PosrednaFormaZaDebugVerziju(CommunicationHandler sockObj) : base(sockObj)
        {

        }
    }
}

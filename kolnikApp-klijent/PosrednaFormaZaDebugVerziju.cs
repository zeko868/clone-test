using kolnikApp_komponente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp_klijent
{
    /// <summary>
    /// Klasa koja nasljeđuje apstraktnu klasu, a koja je nasljeđivana od svih ostalih korištenih korisnički definiranih formi u aplikaciji kako bi se u Debug načinu rada u Designeru mogao vidjeti izgled forme i raditi se nad njome s grafičkim sučeljem
    /// </summary>
    public class PosrednaFormaZaDebugVerziju : ApstraktnaForma
    {
        /// <summary>
        /// Konstruktor bazne korisnički definirane klase forme gdje se definira hoće li forme sadržavati klasičan okvir s kontrolama
        /// </summary>
        /// <param name="fullControlBox">Istina ukoliko forma treba sadržava tipke za minimizaciju, maksimizaciju/normalizaciju i zatvaranje; inače sadrži samo tipku za zatvaranje forme</param>
        protected PosrednaFormaZaDebugVerziju(bool fullControlBox = true) : base(fullControlBox)
        {
        }

        /// <summary>
        /// Konstruktor bazne korisnički definirane klase forme gdje se definira mrežna utičnica putem koje će se vršiti mrežna komunikacija
        /// </summary>
        /// <param name="sockObj">Mrežna utičnica putem koje se vrši mrežna komunikacija u svim ostalim formama naslijeđenim od bazne</param>
        protected PosrednaFormaZaDebugVerziju(CommunicationHandler sockObj) : base(sockObj)
        {
        }

        /// <summary>
        /// Konstruktor bazne korisnički definirane klase forme gdje se koristi prethodno definirana mrežna utičnica te je prikazan puni okvir s kontrolama (tipke za minimizaciju, maksimizaciju/normalizaciju i zatvaranje forme)
        /// </summary>
        protected PosrednaFormaZaDebugVerziju() : this(true)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kolnikApp_komponente;
using System.Threading;

namespace kolnikApp_klijent
{
    /// <summary>
    /// Klasa za prikaz forme s trakom za učitavanje pri čemu se u pozadini vrši dohvaćanje podataka (kako vrsti entiteta s kojima korisnik smije raditi, tako i svim instancama dozvoljenih vrsti entiteta)
    /// </summary>
    public partial class glavnaForma :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        /// <summary>
        /// Konstruktor navedene klase pri čemu se ujedno kreira spremnik za pohranu naziva vrsti entiteta s kojima korisnik može raditi kao i što se šalje zahtjev za njihovim dohvaćanjem
        /// </summary>
        public glavnaForma() : base()
        {
            InitializeComponent();

            DataHandler.entityNamesWithReferencesToBelongingDataStores.Clear();
            DataHandler.entityNamesWithReferencesToBelongingDataStores["tablica"] = new BindingList<object>();
            DataHandler.entityNamesWithReferencesToBelongingDataStores["tablica"].ListChanged += ProcessChanges;
            sockObj.SendRequestForSendingUsedData();
        }

        /// <summary>
        /// Obrađuje niz podataka zaprimljenih od poslužitelja
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        void ProcessChanges(object obj, ListChangedEventArgs e)
        {
            if (DataHandler.ChangesCommited)
            {
                if (DataHandler.entityNamesWithReferencesToBelongingDataStores.ContainsKey("tablica"))
                {
                    Invoke((MethodInvoker)delegate
                    {
                        loadingTraka.Value = (int) (loadingTraka.Maximum * (1.0 / 2));
                        loadingTraka.PerformStep();
                    });
                    if (DataHandler.entityNamesWithReferencesToBelongingDataStores["tablica"].Count == 0)
                    {
                        DataHandler.entityNamesWithReferencesToBelongingDataStores.Remove("tablica");
                        CloseLoadingWindowAndStartMainOne();
                    }
                    else
                    {
                        foreach (string nazivTablice in DataHandler.entityNamesWithReferencesToBelongingDataStores["tablica"])
                        {
                            DataHandler.entityNamesWithReferencesToBelongingDataStores[nazivTablice] = new BindingList<object>();
                            DataHandler.entityNamesWithReferencesToBelongingDataStores[nazivTablice].ListChanged += ProcessChanges;
                        }
                        DataHandler.entityNamesWithReferencesToBelongingDataStores.Remove("tablica");
                        sockObj.SendRequestForSendingUsedData();
                    }
                }
                else
                {
                    foreach (string entityName in DataHandler.entityNamesWithReferencesToBelongingDataStores.Keys)
                    {
                        DataHandler.entityNamesWithReferencesToBelongingDataStores[entityName].ListChanged -= ProcessChanges;
                    }
                    CloseLoadingWindowAndStartMainOne();
                }
            }
        }

        /// <summary>
        /// Sakriva trenutni prozor, otvara glavni prozor za rad s podacima te definira da prilkom zatvaranja glavnom prozora se zatvara ujedno i ovaj prozor
        /// </summary>
        private void CloseLoadingWindowAndStartMainOne()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                this.Hide();
                obrazac formaObrazac = new obrazac();
                formaObrazac.Closed += (s, args) => this.Close();
                formaObrazac.Show();
            });
        }
    }
}

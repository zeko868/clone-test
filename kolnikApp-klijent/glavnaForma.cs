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
    public partial class glavnaForma :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public glavnaForma() : base()
        {
            InitializeComponent();

            DataHandler.entityNamesWithReferencesToBelongingDataStores.Clear();
            DataHandler.entityNamesWithReferencesToBelongingDataStores["tablica"] = new BindingList<object>();
            DataHandler.entityNamesWithReferencesToBelongingDataStores["tablica"].ListChanged += ProcessChanges;
            sockObj.SendRequestForSendingUsedData();
        }

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
                        CloseLoginWindowAndStartMainOne();
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
                    CloseLoginWindowAndStartMainOne();
                }
            }
        }

        private void formaObrazac_FormClosed(object sender, FormClosedEventArgs e)
        {
        this.Close();
        }

        private void CloseLoginWindowAndStartMainOne()
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

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
    public partial class glavnaForma : Form
    {
        private CommunicationHandler sockObj;
        public glavnaForma(CommunicationHandler sockObj)
        {
            this.sockObj = sockObj;
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
                        loadingTraka.Value = (int) (loadingTraka.Maximum * (2.0 / 4));
                        loadingTraka.PerformStep();
                    });
                    foreach (string nazivTablice in DataHandler.entityNamesWithReferencesToBelongingDataStores["tablica"])
                    {
                        DataHandler.entityNamesWithReferencesToBelongingDataStores[nazivTablice] = new BindingList<object>();
                        DataHandler.entityNamesWithReferencesToBelongingDataStores[nazivTablice].ListChanged += ProcessChanges;
                    }
                    DataHandler.entityNamesWithReferencesToBelongingDataStores.Remove("tablica");
                    sockObj.SendRequestForSendingUsedData();
                }
                else
                {
                    BeginInvoke((MethodInvoker)delegate
                    {
                        this.Hide();
                        obrazac formaObrazac = new obrazac(sockObj);
                        //formaObrazac.FormClosed += new FormClosedEventHandler(formaObrazac_FormClosed);
                        formaObrazac.Closed += (s, args) => this.Close();
                        formaObrazac.Show();
                    });
                }
            }
        }

        private void formaObrazac_FormClosed(object sender, FormClosedEventArgs e)
        {
        this.Close();
        }
    }
}

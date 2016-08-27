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

namespace kolnikApp_klijent
{
    public partial class glavnaForma : Form
    {
        private CommunicationHandler sockObj;
        private BindingList<object> tableNames = new BindingList<object>();
        public glavnaForma(CommunicationHandler sockObj)
        {
            this.sockObj = sockObj;
            InitializeComponent();

            DataHandler.entityNamesWithReferencesToBelongingDataStores.Clear();
            DataHandler.entityNamesWithReferencesToBelongingDataStores["tablica"] = tableNames;
            sockObj.SendRequestForSendingUsedData();
        }

        private void glavnaForma_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
        }


     private void formaObrazac_FormClosed(object sender, FormClosedEventArgs e)
        {
        this.Close();
        }

    private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (loadingTraka.Value == loadingTraka.Maximum)
            {
                timerLoading.Stop();
                this.Hide();
                obrazac formaObrazac = new obrazac(sockObj, tableNames.OfType<string>().ToArray());
                //formaObrazac.FormClosed += new FormClosedEventHandler(formaObrazac_FormClosed);
                formaObrazac.Closed += (s, args) => this.Close();
                formaObrazac.Show();
            }
            else
            {
                loadingTraka.PerformStep();
            }           
        }
    }
}

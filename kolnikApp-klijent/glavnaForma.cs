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
        private string userOib;
        private List<object> tableNames = new List<object>();
        public glavnaForma(CommunicationHandler sockObj, string userOib)
        {
            this.sockObj = sockObj;
            this.userOib = userOib;
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
                obrazac formaObrazac = new obrazac(sockObj, userOib, tableNames.OfType<string>().ToArray());
                formaObrazac.FormClosed += new FormClosedEventHandler(formaObrazac_FormClosed);
                formaObrazac.Show();
                this.Hide();
            }
            else
            {
                loadingTraka.PerformStep();
            }           
        }
    }
}

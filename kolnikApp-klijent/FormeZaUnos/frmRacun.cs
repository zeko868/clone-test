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

namespace kolnikApp_klijent.FormeZaUnos
{
    public partial class frmRacun : Form
    {
        public frmRacun()
        {
            InitializeComponent();
            izdavateljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                 from radiObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radi"]
                 from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 where ((zaposlenik)zaposlenikObj).oib == ((radi)radiObj).zaposlenik &&
                       ((radi)radiObj).radno_mjesto == ((radno_mjesto)radno_mjestoObj).id &&
                       ((radno_mjesto)radno_mjestoObj).naziv == "računovođa"
                 select ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime).ToArray();
            izdavateljComboBox.SelectedIndex = -1;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            datum_izdavanjaDateTimePicker.Value = DateTime.Now;
            izdavateljComboBox.SelectedIndex = -1;
            UpozorenjeIzdavatelj.Hide();
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (izdavateljComboBox.SelectedIndex == -1)
            {
                UpozorenjeIzdavatelj.Text = "Odaberite element";
                UpozorenjeIzdavatelj.Show();
            }
            else
            {
                //stavi podatke u klasu i pošalji u BP
                this.Close();
            }
        }

        private void izdavateljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeIzdavatelj.Hide();
        }
    }
}

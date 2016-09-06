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

namespace kolnikApp_klijent.FormeZaUpdate
{
    public partial class frmRacunUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmRacunUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
            izdavateljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 where ((osoba)zaposlenikObj).oib == ((zaposlen)zaposlenObj).zaposlenik &&
                       ((zaposlen)zaposlenObj).radno_mjesto == ((radno_mjesto)radno_mjestoObj).id &&
                       ((radno_mjesto)radno_mjestoObj).naziv == "računovođa"
                 select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            izdavateljComboBox.SelectedItem = PodatkovniRedak.Cells["izdavatelj"].Value;
            datum_izdavanjaDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_izdavanja"].Value;
            placenoCheckBox.Checked = (string)(PodatkovniRedak.Cells["placeno"].Value) == "da" ? true : false;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
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

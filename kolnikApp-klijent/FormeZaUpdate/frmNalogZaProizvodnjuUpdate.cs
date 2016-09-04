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
    public partial class frmNalogZaProizvodnjuUpdate : Form
    {
        public frmNalogZaProizvodnjuUpdate(DataGridViewRow PodatkovniRedak)
        {
            InitializeComponent();

            gradilisteComboBox.DataSource =
                (from gradilisteObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["gradiliste"]
                 select ((gradiliste)gradilisteObj).naziv_mjesta).ToArray();
            gradilisteComboBox.SelectedItem = PodatkovniRedak.Cells["gradiliste"].Value;

            izdavateljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                 select ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime).ToArray();
            izdavateljComboBox.SelectedItem = PodatkovniRedak.Cells["izdavatelj"].Value;
            temeljnicaComboBox.SelectedItem = PodatkovniRedak.Cells["temeljnica"].Value;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenja = "Odaberite element";
            LabelaUpozorenja.Text = TekstUpozorenja;
            LabelaUpozorenja.Show();
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (temeljnicaComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeTemeljnica);
            }
            if (gradilisteComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeGradiliste);
            }
            if (izdavateljComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeIzdavatelj);
            }
            if (temeljnicaComboBox.SelectedIndex != -1 && gradilisteComboBox.SelectedIndex != -1 && izdavateljComboBox.SelectedIndex != -1)
            {
                //pohraniti podatke u klasu i poslati na BP
                this.Close();
            }

        }

        private void temeljnicaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeTemeljnica.Hide();
        }

        private void gradilisteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeGradiliste.Hide();
        }

        private void izdavateljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeIzdavatelj.Hide();
        }
    }
}

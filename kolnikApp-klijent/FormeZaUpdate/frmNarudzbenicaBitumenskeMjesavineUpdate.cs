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
    public partial class frmNarudzbenicaBitumenskeMjesavineUpdate : Form
    {
        public frmNarudzbenicaBitumenskeMjesavineUpdate(DataGridViewRow PodatkovniRedak)
        {
            InitializeComponent();

            naruciteljComboBox.DataSource =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 select ((poduzece)poduzeceObj).naziv).ToArray();
            temeljnicaComboBox.SelectedItem = PodatkovniRedak.Cells["temeljnica"].Value;
            naruciteljComboBox.SelectedItem = PodatkovniRedak.Cells["narucitelj"].Value;
            datum_potrazivanjaDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_potrazivanja"].Value;
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
            if (naruciteljComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeNarucitelj);
            }
            if (temeljnicaComboBox.SelectedIndex != -1 && naruciteljComboBox.SelectedIndex != -1)
            {
                //pohraniti podatke u klasu i poslati u BP
                this.Close();
            }
        }

        private void temeljnicaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeTemeljnica.Hide();
        }

        private void naruciteljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeNarucitelj.Hide();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            temeljnicaComboBox.SelectedIndex = -1;
            datum_potrazivanjaDateTimePicker.Value = DateTime.Now;
            naruciteljComboBox.SelectedIndex = -1;
            UpozorenjeTemeljnica.Hide();
            UpozorenjeNarucitelj.Hide();
            UpozorenjeDatumPotrazivanja.Hide();
        }
    }
}

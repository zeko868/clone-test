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
    public partial class frmOtpremnicaUpdate : Form
    {
        public frmOtpremnicaUpdate(DataGridViewRow PodatkovniRedak)
        {
            InitializeComponent();

            otpremiteljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                 from radiObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radi"]
                 from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 where ((zaposlenik)zaposlenikObj).oib == ((radi)radiObj).zaposlenik &&
                 ((radi)radiObj).radno_mjesto == ((radno_mjesto)radno_mjestoObj).id &&
                 ((radno_mjesto)radno_mjestoObj).naziv == "otpremitelj"
                 select ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime
                 ).ToArray();
            otpremiteljComboBox.SelectedItem = PodatkovniRedak.Cells["izdavatelj"].Value;
            datum_otpremeDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_otpreme"].Value;
            temperaturaTextBox.Text = PodatkovniRedak.Cells["temperatura"].Value.ToString();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja, string VrstaLabele)
        {
            string TekstUpozorenja = "Polje mora biti popunjeno";
            string TekstUpozorenjaComboBox = "Odaberite element";
            if (VrstaLabele == "ComboBox")
            {
                LabelaUpozorenja.Text = TekstUpozorenjaComboBox;
                LabelaUpozorenja.Show();
            }
            else
            {
                LabelaUpozorenja.Text = TekstUpozorenja;
                LabelaUpozorenja.Show();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            float VarijablaZaProvjeru = 0;
            if (temeljnicaComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeTemeljnica, "ComboBox");
            }
            if (temperaturaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeTemeperatura, "TextBox");
            }
            else if (float.TryParse(temperaturaTextBox.Text, out VarijablaZaProvjeru))
            {
                UpozorenjeTemeperatura.Text = "Polje mora sadržavati broj";
                UpozorenjeTemeperatura.Show();
            }
            if (otpremiteljComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeOtpremitelj, "ComboBox");
            }
            if (temeljnicaComboBox.SelectedIndex != -1 && temperaturaTextBox.Text != "" && float.TryParse(temperaturaTextBox.Text, out VarijablaZaProvjeru) && otpremiteljComboBox.SelectedIndex != -1)
            {
                //popuniti klasu podacima i poslati u BP
                this.Close();
            }

        }

        private void temeljnicaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeTemeljnica.Hide();
        }

        private void otpremiteljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeOtpremitelj.Hide();
        }

        private void temperaturaTextBox_Leave(object sender, EventArgs e)
        {
            float VarijablaZaProvjeru = 0;
            if (temperaturaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeTemeperatura, "TextBox");
            }
            else if (float.TryParse(temperaturaTextBox.Text, out VarijablaZaProvjeru))
            {
                UpozorenjeTemeperatura.Text = "Polje mora sadržavati broj";
                UpozorenjeTemeperatura.Show();
            }
            else
            {
                UpozorenjeTemeperatura.Hide();
            }
        }
    }
}

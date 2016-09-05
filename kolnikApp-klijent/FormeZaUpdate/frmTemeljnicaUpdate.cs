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
    public partial class frmTemeljnicaUpdate : Form
    {
        public frmTemeljnicaUpdate(DataGridViewRow PodatkovniRedak)
        {
            InitializeComponent();

            artiklComboBox.DataSource =
                (from artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 select ((artikl)artiklObj).naziv).ToArray();
            artiklComboBox.SelectedItem = PodatkovniRedak.Cells["artikl"].Value;

            vozacComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 where ((osoba)zaposlenikObj).oib == ((zaposlen)zaposlenObj).zaposlenik &&
                       ((zaposlen)zaposlenObj).radno_mjesto == ((radno_mjesto)radno_mjestoObj).id &&
                       ((radno_mjesto)radno_mjestoObj).naziv == "vozač"
                 select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            vozacComboBox.SelectedItem = PodatkovniRedak.Cells["vozac"].Value;

            voziloComboBox.DataSource =
                (from voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                 select ((vozilo)voziloObj).registracijski_broj).ToArray();
            voziloComboBox.SelectedItem = PodatkovniRedak.Cells["vozilo"].Value;
            kolicinaTextBox.Text = PodatkovniRedak.Cells["kolicina"].Value.ToString();
            datum_izdavanjaDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_izdavanja"].Value;
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

        private void kolicinaTextBox_Leave(object sender, EventArgs e)
        {
            int VarijablaZaProvjeru = 0;
            if (kolicinaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKolicina, "TextBox");
            }
            else if (!int.TryParse(kolicinaTextBox.Text, out VarijablaZaProvjeru))
            {
                UpozorenjeKolicina.Text = "Polje mora sadržavati broj";
                UpozorenjeKolicina.Show();
            }
            else
            {
                UpozorenjeKolicina.Hide();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (kolicinaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKolicina, "TextBox");
            }
            if (voziloComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeVozilo, "ComboBox");
            }
            if (vozacComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeVozac, "ComboBox");
            }
            if (artiklComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeArtikl, "ComboBox");
            }
            int VarijablaZaProvjeru = 0;
            if (int.TryParse(kolicinaTextBox.Text, out VarijablaZaProvjeru) && kolicinaTextBox.Text != "" && voziloComboBox.SelectedIndex != -1 && vozacComboBox.SelectedIndex != -1 && artiklComboBox.SelectedIndex != -1)
            {
                //spremi podatke u klasu i pošalji u BP
                this.Close();
            }
        }

        private void voziloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeVozilo.Hide();
        }

        private void vozacComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeVozac.Hide();
        }

        private void artiklComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeArtikl.Hide();
        }
    }
}

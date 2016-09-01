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
    public partial class frmTablicnaPrivilegija : Form
    {
        public frmTablicnaPrivilegija()
        {
            InitializeComponent();

            operacijaComboBox.DataSource = Operacije;
            operacijaComboBox.SelectedIndex = -1;

            radno_mjestoComboBox.DataSource =
                (from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 select ((radno_mjesto)radno_mjestoObj).naziv).ToArray();
            radno_mjestoComboBox.SelectedIndex = -1;

            naziv_tabliceComboBox.DataSource = ImenaTablica;
            naziv_tabliceComboBox.SelectedIndex = -1;
        }

        string[] ImenaTablica = new string[17] { "Korisnički račun", "Račun", "Artikl", "Radi", "Rabat", "Zaposlenik", "Temeljnica", "Narudžbenica", "Vozilo", "Zaposlen", "Poduzeće", "Vozi", "Otpremnica", "Tablična privilegija", "Gradilište", "Nalog za proizvodnju", "Radno mjesto" };
        string[] Operacije = new string[4] { "Create", "Read", "Update", "Delete" };

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            radno_mjestoComboBox.SelectedIndex = -1;
            naziv_tabliceComboBox.SelectedIndex = -1;
            operacijaComboBox.SelectedIndex = -1;
            UpozorenjeNazivTablice.Hide();
            UpozorenjeOperacija.Hide();
            UpozorenjeRadnoMjesto.Hide();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenjaComboBox = "Odaberite element";
            LabelaUpozorenja.Text = TekstUpozorenjaComboBox;
            LabelaUpozorenja.Show();
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (radno_mjestoComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeRadnoMjesto);
            }
            if (naziv_tabliceComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeNazivTablice);
            }
            if (operacijaComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeOperacija);
            }
            if(radno_mjestoComboBox.SelectedIndex != -1 && naziv_tabliceComboBox.SelectedIndex != -1 && operacijaComboBox.SelectedIndex != -1)
            {
                //pohrani podatke u klasu i pošalji u BP
                this.Close();
            }
            
        }

        private void radno_mjestoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeRadnoMjesto.Hide();
        }

        private void naziv_tabliceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeNazivTablice.Hide();
        }

        private void operacijaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeOperacija.Hide();
        }
    }
}

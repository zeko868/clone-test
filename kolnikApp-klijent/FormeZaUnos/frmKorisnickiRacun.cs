using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp_klijent.FormeZaUnos
{
    public partial class frmKorisnickiRacun : Form
    {
        public frmKorisnickiRacun()
        {
            InitializeComponent();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            zaposlenikComboBox.SelectedIndex = -1;
            korisnicko_imeTextBox.Text = "";
            lozinkaTextBox.Text = "";
            UpozorenjeKorisnickoIme.Hide();
            UpozorenjeLozinka.Hide();
            UpozorenjeZaposlenik.Hide();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenja = "Polje mora biti popunjeno";
            LabelaUpozorenja.Text = TekstUpozorenja;
            LabelaUpozorenja.Show();
        }

        private void korisnicko_imeTextBox_Leave(object sender, EventArgs e)
        {
            if (korisnicko_imeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKorisnickoIme);
            }
            else
            {
                UpozorenjeKorisnickoIme.Hide();
            }
        }

        private void lozinkaTextBox_Leave(object sender, EventArgs e)
        {
            if(lozinkaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeLozinka);
            }
            else
            {
                UpozorenjeLozinka.Hide();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (korisnicko_imeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKorisnickoIme);
            }
            if (lozinkaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeLozinka);
            }
            if (zaposlenikComboBox.SelectedIndex == -1)
            {
                UpozorenjeZaposlenik.Text = "Odaberite zaposlenika";
                UpozorenjeZaposlenik.Show();
            }
            if(korisnicko_imeTextBox.Text != "" && lozinkaTextBox.Text != "" && zaposlenikComboBox.SelectedIndex != -1)
            {
                //unesti podatke u klasu i pohraniti u bazu podatka
                this.Close();
            }
        }

        private void zaposlenikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeZaposlenik.Hide();
        }
    }
}

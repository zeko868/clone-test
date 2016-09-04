using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp_klijent.FormeZaUpdate
{
    public partial class frmZaposlenikUpdate : Form
    {
        public frmZaposlenikUpdate(DataGridViewRow PodatkovniRedak)
        {
            InitializeComponent();
            oibTextBox.Text = PodatkovniRedak.Cells["oib"].Value.ToString();
            imeTextBox.Text = PodatkovniRedak.Cells["ime"].Value.ToString();
            prezimeTextBox.Text = PodatkovniRedak.Cells["prezime"].Value.ToString();
            korisnickoImeTextBox.Text = PodatkovniRedak.Cells["korisnicko_ime"].Value.ToString();
            //lozinkaTextBox.Text=????
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenja = "Polje mora biti popunjeno";
            LabelaUpozorenja.Text = TekstUpozorenja;
            LabelaUpozorenja.Show();
        }

        private bool TestirajPravilonostUnosaZaOib()
        {
            bool IspravanOib = false;
            if (oibTextBox.Text.Length < 11)
            {
                UpozorenjeOib.Text = "OIB mora sadržavati 11 brojeva";
                UpozorenjeOib.Show();
            }
            else
            {
                UpozorenjeOib.Text = "";
            }
            if (oibTextBox.Text.Any(x => !char.IsDigit(x)))
            {
                if (UpozorenjeOib.Text != "")
                {
                    UpozorenjeOib.Text += "\nOIB mora sadržavati samo brojeve";
                }
                else
                {
                    UpozorenjeOib.Text = "OIB mora sadržavati samo brojeve";
                }
                UpozorenjeOib.Show();
            }
            if (oibTextBox.Text.Length == 11 && oibTextBox.Text.All(x => char.IsDigit(x)))
            {
                UpozorenjeOib.Hide();
                IspravanOib = true;
            }
            return IspravanOib;
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            bool IspravanOib = TestirajPravilonostUnosaZaOib();
            if (imeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeIme);
            }
            if (prezimeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjePrezime);
            }
            if(lozinkaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeLozinka);
            }
            if(korisnickoImeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKorIme);
            }
            //što je s lozinkom???
            if (IspravanOib && imeTextBox.Text != "" && prezimeTextBox.Text != "" && korisnickoImeTextBox.Text != "")
            {
                //pohrani podatke u klasu i pošalji u BP
                this.Close();
            }
        }

        private void oibTextBox_Leave(object sender, EventArgs e)
        {
            bool IspravanOib = TestirajPravilonostUnosaZaOib();
            if (IspravanOib)
            {
                UpozorenjeOib.Hide();
            }
        }

        private void imeTextBox_Leave(object sender, EventArgs e)
        {
            if (imeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeIme);
            }
            else
            {
                UpozorenjeIme.Hide();
            }
        }

        private void prezimeTextBox_Leave(object sender, EventArgs e)
        {
            if (prezimeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjePrezime);
            }
            else
            {
                UpozorenjePrezime.Hide();
            }
        }

        private void korisnickoImeTextBox_Leave(object sender, EventArgs e)
        {
            if (korisnickoImeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKorIme);
            }
            else
            {
                UpozorenjeKorIme.Hide();
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
    }
}

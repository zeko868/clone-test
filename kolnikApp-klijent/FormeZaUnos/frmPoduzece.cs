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
    public partial class frmPoduzece : Form
    {
        public frmPoduzece()
        {
            InitializeComponent();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            oibTextBox.Text = "";
            nazivTextBox.Text = "";
            adresaTextBox.Text = "";
            ibanTextBox.Text = "";
            UpozorenjeAdresa.Hide();
            UpozorenjeIban.Hide();
            UpozorenjeNaziv.Hide();
            UpozorenjeOib.Hide();
        }
        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenja = "Polje mora biti popunjeno";
            LabelaUpozorenja.Text = TekstUpozorenja;
            LabelaUpozorenja.Show();
        }

        private bool TestirajPravilonostUnosaZaOib ()
        {
            bool IspravanOib = false;
            if(oibTextBox.Text.Length < 11)
            {
                UpozorenjeOib.Text= "OIB mora sadržavati 11 brojeva";
                UpozorenjeOib.Show();
            }
            else
            {
                UpozorenjeOib.Text = "";
            }
            if(oibTextBox.Text.Any(x => !char.IsDigit(x)))
            {
                if(UpozorenjeOib.Text != "")
                {
                    UpozorenjeOib.Text += "\nOIB mora sadržavati samo brojeve";
                }
                else
                {
                    UpozorenjeOib.Text = "OIB mora sadržavati samo brojeve";
                }                    
                UpozorenjeOib.Show();
            }
            if(oibTextBox.Text.Length==11 && oibTextBox.Text.All(x => char.IsDigit(x)))
            {
                UpozorenjeOib.Hide();
                IspravanOib = true;
            }
            return IspravanOib;
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            bool IspravanOib=TestirajPravilonostUnosaZaOib();
            if (nazivTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeNaziv);
            }
            if (adresaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeAdresa);
            }
            if (ibanTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeIban);
            }
            if (IspravanOib && nazivTextBox.Text != "" && adresaTextBox.Text != "" && ibanTextBox.Text != "")
            {
                //staviti podatke u klasu i postati u BP
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

        private void nazivTextBox_Leave(object sender, EventArgs e)
        {
            if (nazivTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeNaziv);
            }
            else
            {
                UpozorenjeNaziv.Hide();
            }
        }

        private void adresaTextBox_Leave(object sender, EventArgs e)
        {
            if (adresaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeAdresa);
            }
            else
            {
                UpozorenjeAdresa.Hide();
            }
            
        }

        private void ibanTextBox_Leave(object sender, EventArgs e)
        {
            if (ibanTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeIban);
            }
            else
            {
                UpozorenjeIban.Hide();
            }
        }
    }
}

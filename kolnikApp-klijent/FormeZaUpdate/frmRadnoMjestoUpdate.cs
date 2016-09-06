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
    public partial class frmRadnoMjestoUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmRadnoMjestoUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
            nazivTextBox.Text = PodatkovniRedak.Cells["naziv"].Value.ToString();
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

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (nazivTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeNaziv);
            }
            if (nazivTextBox.Text != "")
            {
                //spremi podatke u klasu i pošalji u BP
                this.Close();
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
    }
}

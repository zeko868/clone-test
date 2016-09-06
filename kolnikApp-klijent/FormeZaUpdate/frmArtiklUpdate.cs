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
    public partial class frmArtiklUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmArtiklUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
            nazivTextBox.Text = PodatkovniRedak.Cells["naziv"].Value.ToString();
            jedinicna_cijenaTextBox.Text = PodatkovniRedak.Cells["jedinicna_cijena"].Value.ToString();

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

        private void jedinicna_cijenaTextBox_Leave(object sender, EventArgs e)
        {
            float VarijablaZaProvjeru = 0;
            if (jedinicna_cijenaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeJedinicnaCijena);
            }
            else if (!float.TryParse(jedinicna_cijenaTextBox.Text, out VarijablaZaProvjeru))
            {
                UpozorenjeJedinicnaCijena.Text = "Polje mora sadržavati broj";
                UpozorenjeJedinicnaCijena.Show();
            }
            else
            {
                UpozorenjeJedinicnaCijena.Hide();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (jedinicna_cijenaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeJedinicnaCijena);
            }
            if (nazivTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeNaziv);
            }

            float VarijablaZaProvjeru = 0;
            if (float.TryParse(jedinicna_cijenaTextBox.Text, out VarijablaZaProvjeru) && nazivTextBox.Text != "" && jedinicna_cijenaTextBox.Text != "")
            {
                //pohrani podatke u klasu i pošalji na server
                this.Close();
            }
        }
    }
}

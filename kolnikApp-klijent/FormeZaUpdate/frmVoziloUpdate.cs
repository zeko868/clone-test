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
    public partial class frmVoziloUpdate : Form
    {
        public frmVoziloUpdate(DataGridViewRow PodatkovniRedak)
        {
            InitializeComponent();
            registracijski_brojTextBox.Text = PodatkovniRedak.Cells["registracijski_broj"].Value.ToString();
            proizvodjacTextBox.Text = PodatkovniRedak.Cells["proizvodjac"].Value.ToString();
            modelTextBox.Text = PodatkovniRedak.Cells["model"].Value.ToString();
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
            if (registracijski_brojTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeRegistracijskiBroj);
            }
            if (proizvodjacTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeProizvodac);
            }
            if (modelTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeModel);
            }
            if (registracijski_brojTextBox.Text != "" && proizvodjacTextBox.Text != "" && modelTextBox.Text != "")
            {
                //pohrani podatke u klasu i prenesi u BP
                this.Close();
            }
        }

        private void registracijski_brojTextBox_Leave(object sender, EventArgs e)
        {
            if (registracijski_brojTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeRegistracijskiBroj);
            }
            else
            {
                UpozorenjeRegistracijskiBroj.Hide();
            }
        }

        private void proizvodjacTextBox_Leave(object sender, EventArgs e)
        {
            if (proizvodjacTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeProizvodac);
            }
            else
            {
                UpozorenjeProizvodac.Hide();
            }
        }

        private void modelTextBox_Leave(object sender, EventArgs e)
        {
            if (modelTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeModel);
            }
            else
            {
                UpozorenjeModel.Hide();
            }
        }
    }
}

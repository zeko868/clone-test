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
    public partial class frmTablicnaPrivilegija : Form
    {
        public frmTablicnaPrivilegija()
        {
            InitializeComponent();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            radno_mjestoComboBox.SelectedIndex = -1;
            naziv_tabliceComboBox.SelectedIndex = -1;
            UpozorenjeNazivTablice.Hide();
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
            if(radno_mjestoComboBox.SelectedIndex != -1 && naziv_tabliceComboBox.SelectedIndex != -1)
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
    }
}

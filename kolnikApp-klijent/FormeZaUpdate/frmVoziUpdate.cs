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
    public partial class frmVoziUpdate : Form
    {
        public frmVoziUpdate()
        {
            InitializeComponent();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            voziloComboBox.SelectedIndex = -1;
            vozacComboBox.SelectedIndex = -1;
            datum_pocetkaDateTimePicker.Value = DateTime.Now;
            datum_zavrsetkaDateTimePicker.Value = DateTime.Now;
            UpozorenjeVozac.Hide();
            UpozorenjeVozilo.Hide();
            UpozorenjeDatumi.Hide();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenjaComboBox = "Odaberite element";
            LabelaUpozorenja.Text = TekstUpozorenjaComboBox;
            LabelaUpozorenja.Show();
        }

        private bool provjeriIspravnostDatuma()
        {
            bool IspravanDatum = false;
            if (datum_zavrsetkaDateTimePicker.Checked)
            {
                if (datum_pocetkaDateTimePicker.Value < datum_zavrsetkaDateTimePicker.Value)
                {
                    IspravanDatum = true;
                }
                else
                {
                    popuniLabeleUpozorenja(UpozorenjeDatumi);
                }
            }
            return IspravanDatum;
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (vozacComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeVozac);
            }
            if (voziloComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeVozilo);
            }
            if (vozacComboBox.SelectedIndex != -1 && voziloComboBox.SelectedIndex != -1 && provjeriIspravnostDatuma())
            {
                //spremiti podatke u klasu i poslati u BP
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

        private void datum_pocetkaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool IspravniDatum = provjeriIspravnostDatuma();
            {
                if (IspravniDatum)
                {
                    UpozorenjeDatumi.Hide();
                }
                else
                {
                    UpozorenjeDatumi.Show();
                }
            }
        }

        private void datum_zavrsetkaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool IspravniDatum = provjeriIspravnostDatuma();
            {
                if (IspravniDatum)
                {
                    UpozorenjeDatumi.Hide();
                }
                else
                {
                    UpozorenjeDatumi.Show();
                }
            }
        }
    }
}

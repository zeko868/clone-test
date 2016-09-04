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
    public partial class frmZaposlenUpdate : Form
    {
        public frmZaposlenUpdate(DataGridViewRow PodatkovniRedak)
        {
            InitializeComponent();
            zaposlenikComboBox.SelectedItem = PodatkovniRedak.Cells["zaposlenik"].Value;
            poduzeceComboBox.SelectedItem = PodatkovniRedak.Cells["poduzece"].Value;
            datum_pocetkaDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_pocetka"].Value;
            datum_zavrsetkaDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_zavrsetka"].Value;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (datum_pocetkaDateTimePicker.Value <= datum_zavrsetkaDateTimePicker.Value)
                {
                    IspravanDatum = true;
                }
            }
            else
            {
                IspravanDatum = true;
            }
            return IspravanDatum;
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {

            if (zaposlenikComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeZaposlenik);
            }
            if (poduzeceComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjePoduzece);
            }

            if (zaposlenikComboBox.SelectedIndex == -1 && poduzeceComboBox.SelectedIndex == -1 && provjeriIspravnostDatuma())
            {
                //pohrani podatke u klasu i pošalji u BP
                this.Close();
            }
        }

        private void zaposlenikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeZaposlenik.Hide();
        }

        private void poduzeceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjePoduzece.Hide();
        }

        private void datum_pocetkaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool IspravnostDatuma = provjeriIspravnostDatuma();
            if (IspravnostDatuma)
            {
                UpozorenjeRazlikaDatuma.Hide();
            }
            else
            {
                UpozorenjeRazlikaDatuma.Show();
            }
        }

        private void datum_zavrsetkaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool IspravnostDatuma = provjeriIspravnostDatuma();
            if (IspravnostDatuma)
            {
                UpozorenjeRazlikaDatuma.Hide();
            }
            else
            {
                UpozorenjeRazlikaDatuma.Show();
            }
        }
    }
}

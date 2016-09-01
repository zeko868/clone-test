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
    public partial class frmZaposlen : Form
    {
        public frmZaposlen()
        {
            InitializeComponent();
            zaposlenikComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                 select ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime).ToArray();
            zaposlenikComboBox.SelectedIndex = -1;

            poduzeceComboBox.DataSource =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 select ((poduzece)poduzeceObj).naziv).ToArray();
            poduzeceComboBox.SelectedIndex = -1;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            zaposlenikComboBox.SelectedIndex = -1;
            poduzeceComboBox.SelectedIndex = -1;
            datum_pocetkaDateTimePicker.Value = DateTime.Now;
            datum_zavrsetkaDateTimePicker.Value = DateTime.Now;
            UpozorenjePoduzece.Hide();
            UpozorenjeRazlikaDatuma.Hide();
            UpozorenjeZaposlenik.Hide();
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
          
            if(zaposlenikComboBox.SelectedIndex == -1 && poduzeceComboBox.SelectedIndex == -1 && provjeriIspravnostDatuma())
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
            bool IspravnostDatuma=provjeriIspravnostDatuma();
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

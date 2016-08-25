﻿using System;
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
    public partial class frmRadiUpdate : Form
    {
        public frmRadiUpdate()
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
            radno_mjestoComboBox.SelectedIndex = -1;
            datum_pocetkaDateTimePicker.Value = DateTime.Now;
            datum_zavrsetkaDateTimePicker.Value = DateTime.Now;
            UpozorenjeRadnoMjesto.Hide();
            UpozorenjeRazlikaDatuma.Hide();
            UpozorenjeZaposlenik.Hide();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenjaComboBox = "Odaberite element";
            {
                LabelaUpozorenja.Text = TekstUpozorenjaComboBox;
                LabelaUpozorenja.Show();
            }
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
                    popuniLabeleUpozorenja(UpozorenjeRazlikaDatuma);
                }
            }
            return IspravanDatum;
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (zaposlenikComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeZaposlenik);
            }
            if (radno_mjestoComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeRadnoMjesto);
            }
            if (zaposlenikComboBox.SelectedIndex != -1 && radno_mjestoComboBox.SelectedIndex != -1 && provjeriIspravnostDatuma())
            {
                //spremi podatke u klasu i pošalji u BP
                this.Close();
            }

        }

        private void zaposlenikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeZaposlenik.Hide();
        }

        private void radno_mjestoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeRadnoMjesto.Hide();
        }

        private void datum_pocetkaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool IspravanDatum = provjeriIspravnostDatuma();
            {
                if (IspravanDatum)
                {
                    UpozorenjeRazlikaDatuma.Hide();
                }
                else
                {
                    UpozorenjeRazlikaDatuma.Show();
                }
            }
        }

        private void datum_zavrsetkaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool IspravanDatum = provjeriIspravnostDatuma();
            {
                if (IspravanDatum)
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
}
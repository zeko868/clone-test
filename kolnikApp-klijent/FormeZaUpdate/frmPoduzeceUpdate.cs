﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kolnikApp_komponente;

namespace kolnikApp_klijent.FormeZaUpdate
{
    public partial class frmPoduzeceUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        poduzece oldInstance = null;
        public frmPoduzeceUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
            oldInstance = new poduzece
            {
                oib = PodatkovniRedak.Cells["oib"].Value.ToString(),
                naziv = PodatkovniRedak.Cells["naziv"].Value.ToString(),
                adresa = PodatkovniRedak.Cells["adresa"].Value.ToString(),
                iban = PodatkovniRedak.Cells["iban"].Value.ToString()
            };
            oibTextBox.Text = PodatkovniRedak.Cells["oib"].Value.ToString();
            nazivTextBox.Text= PodatkovniRedak.Cells["naziv"].Value.ToString();
            adresaTextBox.Text= PodatkovniRedak.Cells["adresa"].Value.ToString();
            ibanTextBox.Text= PodatkovniRedak.Cells["iban"].Value.ToString();
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
                poduzece newInstance = new poduzece
                {
                    oib = oibTextBox.Text,
                    naziv = nazivTextBox.Text,
                    adresa = adresaTextBox.Text,
                    iban = ibanTextBox.Text
                };

                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
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

using kolnikApp_komponente;
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
    public partial class frmOsoba :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmOsoba() : base(false)
        {
            InitializeComponent();
            if (!DataHandler.entityNamesWithReferencesToBelongingDataStores.ContainsKey("korisnicki_racun"))
            {
                this.lozinkaTextBox.Visible = false;
                this.korisnickoImeTextBox.Visible = false;
                this.KorisnickoImeLabel.Visible = false;
                this.LozinkaLabel.Visible = false;
            }
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            oibTextBox.Text = "";
            imeTextBox.Text = "";
            prezimeTextBox.Text = "";
            korisnickoImeTextBox.Text = "";
            lozinkaTextBox.Text = "";
            UpozorenjeKorIme.Hide();
            UpozorenjeLozinka.Hide();
            UpozorenjePrezime.Hide();
            UpozorenjeOib.Hide();
            UpozorenjeIme.Hide();
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

        private void oibTextBox_Leave(object sender, EventArgs e)
        {
            bool IspravanOib = TestirajPravilonostUnosaZaOib();
            if (IspravanOib)
            {
                UpozorenjeOib.Hide();
            }            
        }

        private void imeTextBox_Leave(object sender, EventArgs e)
        {
            if (imeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeIme);
            }
            else
            {
                UpozorenjeIme.Hide();
            }
        }

        private void prezimeTextBox_Leave(object sender, EventArgs e)
        {
            if (prezimeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjePrezime);
            }
            else
            {
                UpozorenjePrezime.Hide();
            }
        }

        private void lozinkaTextBox_Leave(object sender, EventArgs e)
        {
            if (lozinkaTextBox.Text == "")
            {
                if (korisnickoImeTextBox.Text != "")
                {
                    popuniLabeleUpozorenja(UpozorenjeLozinka);
                }
            }
            else
            {
                UpozorenjeLozinka.Hide();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            bool IspravanOib = TestirajPravilonostUnosaZaOib();
            if (imeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeIme);
            }
            if (prezimeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjePrezime);
            }
            if (lozinkaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeLozinka);
            }
            if (korisnickoImeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKorIme);
            }
            if (IspravanOib && imeTextBox.Text != "" && prezimeTextBox.Text != "")
            {
                korisnicki_racun newAccountInstance = null;
                osoba newInstance = new osoba
                {
                    oib = oibTextBox.Text,
                    ime = imeTextBox.Text,
                    prezime = prezimeTextBox.Text
                };
                string dataForSending = "";
                if (DataHandler.entityNamesWithReferencesToBelongingDataStores.ContainsKey("korisnicki_racun"))
                {
                    if (korisnickoImeTextBox.Text != "" && lozinkaTextBox.Text != "")
                    {
                        newAccountInstance = new korisnicki_racun
                        {
                            zaposlenik = oibTextBox.Text,
                            korisnicko_ime = korisnickoImeTextBox.Text,
                            lozinka = DataHandler.HashPasswordUsingSHA1Algorithm(lozinkaTextBox.Text)
                        };
                        //pohrani s korisnickim_racunom
                        dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newInstance), 'C');
                        dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newAccountInstance), 'C');
                    }
                    else
                    {
                        //pohrani bez korisnickog_racuna
                        dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newInstance), 'C');
                    }
                }
                else
                {
                    //pohrani bez korisnickog_racuna
                    dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newInstance), 'C');
                }
                //pohrani podatke u klasu i pošalji u BP
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                this.Close();
            }
        }
    }
}

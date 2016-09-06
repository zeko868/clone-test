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

namespace kolnikApp_klijent.FormeZaUpdate
{
    public partial class frmOsobaUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif
    {
        osoba oldInstance = null;
        korisnicki_racun oldAccountInstance = null;
        public frmOsobaUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
            oldInstance = new osoba
            {
                oib = oibTextBox.Text = PodatkovniRedak.Cells["oib"].Value.ToString(),
                ime = imeTextBox.Text = PodatkovniRedak.Cells["ime"].Value.ToString(),
                prezime = prezimeTextBox.Text = PodatkovniRedak.Cells["prezime"].Value.ToString()

            };
            korisnickoImeTextBox.Text = PodatkovniRedak.Cells["korisnicko_ime"].Value.ToString();
            if (DataHandler.entityNamesWithReferencesToBelongingDataStores.ContainsKey("korisnicki_racun"))
            {
                if (korisnickoImeTextBox.Text != String.Empty)
                {
                    oldAccountInstance = new korisnicki_racun
                    {
                        zaposlenik = oldInstance.oib,
                        korisnicko_ime = korisnickoImeTextBox.Text,
                        lozinka = (from accountObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["korisnicki_racun"]
                                   where ((korisnicki_racun)accountObj).zaposlenik == oldInstance.oib
                                   select ((korisnicki_racun)accountObj).lozinka).First()
                    };
            }
            }
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
            if (imeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeIme);
            }
            if (prezimeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjePrezime);
            }
            if(lozinkaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeLozinka);
            }
            if(korisnickoImeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKorIme);
            }
            //što je s lozinkom???
            if (IspravanOib && imeTextBox.Text != "" && prezimeTextBox.Text != "")
            {
                korisnicki_racun newAccountInstance = null;
                osoba newInstance = new osoba()
                {
                    oib = oibTextBox.Text,
                    ime = imeTextBox.Text,
                    prezime = prezimeTextBox.Text
                };
                if (DataHandler.entityNamesWithReferencesToBelongingDataStores.ContainsKey("korisnicki_racun"))
                {
                    if (korisnickoImeTextBox.Text != "" && lozinkaTextBox.Text != "")
                    {
                        newAccountInstance = new korisnicki_racun()
                        {
                            zaposlenik = oldInstance.oib,
                            korisnicko_ime = korisnickoImeTextBox.Text,
                            lozinka = DataHandler.HashPasswordUsingSHA1Algorithm(lozinkaTextBox.Text)
                        };
                    }
                }
                string dataForSending = "";
                //kod updateanja je u bazi potrebno prvo izvršiti rad s korisničkim imenom, a onda nad osobom
                //inače ako je oldAccountInstance == null && newAccountInstance == null, tada izvrši promjenu samo nad osobom
                if (oldAccountInstance == null && newAccountInstance == null)
                {
                    dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                }
                //inače ako je oldAccountInstance == null && newAccountInstance != null, tada izvrši dodavanje korisničkog računa i promjenu nad osobom
                else if (oldAccountInstance == null && newAccountInstance != null)
                {
                    dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newAccountInstance), 'C');
                    dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                }
                //inače ako je oldAccountInstance != null && newAccountInstance == null, tada izvrši brisanje korisničkog računa i promjenu nad osobom
                else if (oldAccountInstance != null && newAccountInstance == null)
                {
                    dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newAccountInstance), 'D');
                    dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                }
                //inače izvrši promjenu nad korisničkim računom i promjenu nad osobom
                else
                {
                    dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldAccountInstance, newAccountInstance), 'U');
                    dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                }
                //pohrani podatke u klasu i pošalji u BP
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

        private void korisnickoImeTextBox_Leave(object sender, EventArgs e)
        {
            if (korisnickoImeTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeKorIme);
            }
            else
            {
                UpozorenjeKorIme.Hide();
            }
        }

        private void lozinkaTextBox_Leave(object sender, EventArgs e)
        {
            if(lozinkaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeLozinka);
            }
            else
            {
                UpozorenjeLozinka.Hide();
            }
        }
    }
}

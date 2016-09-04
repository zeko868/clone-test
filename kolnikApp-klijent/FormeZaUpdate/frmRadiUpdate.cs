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

namespace kolnikApp_klijent.FormeZaUpdate
{
    public partial class frmRadiUpdate : Form
    {
        public frmRadiUpdate(DataGridViewRow PodatkovniRedak, DataGridViewRow DodatniRedak)
        {
            InitializeComponent();
            zaposlenikComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                 select ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime).ToArray();
            string ImePrezime = DodatniRedak.Cells["ime"].Value.ToString() + " " + DodatniRedak.Cells["prezime"].Value.ToString();
            zaposlenikComboBox.SelectedItem = ImePrezime;
            zaposlenikComboBox.Enabled = false;            

            dobaviMogucaRadnaMjesta(DodatniRedak);
            datum_pocetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_pocetka"].Value;
            if(DodatniRedak.Cells["datum_zavrsetka"].Value == null)
            {
                datum_zavrsetkaDateTimePicker.Checked = false;
            }
            else
            {
                datum_zavrsetkaDateTimePicker.Checked = true;
                datum_zavrsetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_zavrsetka"].Value;
            }
            zaposlenikComboBox.SelectedIndexChanged += new EventHandler((s, e) => zaposlenikComboBox_SelectedIndexChanged(s, e, DodatniRedak));
        }

        private void dobaviMogucaRadnaMjesta(DataGridViewRow DodatniRedak)
        {
            string[] RadnaMjestaRadnika = (from radiObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radi"]
                                           from rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                           from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                                           where ((radi)radiObj).radno_mjesto == ((radno_mjesto)rmObj).id &&
                                                 ((radi)radiObj).zaposlenik == ((zaposlenik)zaposlenikObj).oib &&
                                                 ((zaposlenik)zaposlenikObj).ime ==  DodatniRedak.Cells["ime"].Value.ToString() && 
                                                 ((zaposlenik)zaposlenikObj).prezime == DodatniRedak.Cells["prezime"].Value.ToString() &&
                                                 ((radi)radiObj).datum_zavrsetka == null
                                               select ((radno_mjesto)rmObj).naziv).ToArray();

                string[] SvaRadnaMjesta = (from rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                           select ((radno_mjesto)rmObj).naziv).ToArray();
                var Filtrirano = SvaRadnaMjesta.Except(RadnaMjestaRadnika);
                radno_mjestoComboBox.DataSource = Filtrirano.ToList();
                radno_mjestoComboBox.SelectedIndex = -1;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void zaposlenikComboBox_SelectedIndexChanged(object sender, EventArgs e, DataGridViewRow DodatniRedak)
        {
            UpozorenjeZaposlenik.Hide();
            dobaviMogucaRadnaMjesta(DodatniRedak);
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

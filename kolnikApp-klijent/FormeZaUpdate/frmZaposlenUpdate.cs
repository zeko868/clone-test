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
    public partial class frmZaposlenUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        class PodaciZaOldInstance
        {
            public int artikl { get; set; }
            public int vozi { get; set; }
            public string izdavatelj { get; set; }
        }

        zaposlen oldInstance;
        public frmZaposlenUpdate(DataGridViewRow PodatkovniRedak, DataGridViewRow DodatniRedak) : base(false)
        {
            InitializeComponent();
            PodaciZaOldInstance objekt = new PodaciZaOldInstance();
            //dohvatiPodatke(DodatniRedak);
            zaposlenikComboBox.DataSource =
                (from osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 select ((osoba)osobaObj).ime + " " + ((osoba)osobaObj).prezime).ToArray();
            zaposlenikComboBox.SelectedText = DodatniRedak.Cells["ime"].Value.ToString() + " " + DodatniRedak.Cells["prezime"].Value.ToString();

            radno_mjestoComboBox.SelectedItem = DodatniRedak.Cells["radno_mjesto"].Value;

            poduzeceComboBox.DataSource =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 select ((poduzece)poduzeceObj).naziv).ToArray();
            poduzeceComboBox.SelectedItem = PodatkovniRedak.Cells["naziv"].Value;
            poduzeceComboBox.Enabled = false;

            radno_mjestoComboBox.DataSource =
                (from rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 select ((radno_mjesto)rmObj).naziv).ToArray();

            datum_pocetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_pocetka"].Value;
            if(DodatniRedak.Cells["datum_zavrsetka"].Value == null)
            {
                datum_zavrsetkaDateTimePicker.Checked = false;
                /*oldInstance = new zaposlen
                {
                    zaposlenik= nesto,
                    poduzece= nesto,
                    radno_mjesto= nesto,
                    datum_pocetka= (DateTime)DodatniRedak.Cells["datum_pocetka"].Value,
                };*/
            }
            else
            {
                datum_zavrsetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_zavrsetka"].Value;
            }
           
        }

        /*private void dohvatiPodatke(DataGridViewRow DodatniRedak)
        {
            var podaci =
                (from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 join osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((zaposlen)zaposlenObj).zaposlenik equals ((osoba)osobaObj).oib
                 join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 on ((zaposlen)zaposlenObj) equals ((poduzece)poduzeceObj).oib
                 where ((narudzbenica_bitumenske_mjesavine)zaposlenObj).id == key
                 select new PodaciZaOldInstance
                 {
                     artikl = ((narudzbenica_bitumenske_mjesavine)zaposlenObj).artikl,
                     vozi = ((narudzbenica_bitumenske_mjesavine)zaposlenObj).vozi,
                     izdavatelj = ((narudzbenica_bitumenske_mjesavine)zaposlenObj).izdavatelj
                 }).ToArray();
        }*/

        private void napraviDataSourceZaRadnoMjesto()
        {
            if (poduzeceComboBox.SelectedValue.ToString() == "Kolnik d.o.o")
            {
                string[] ImeIPrezime = zaposlenikComboBox.SelectedValue.ToString().Split(' ');
                string[] radnaMjestaZaposlenika =
                         (from rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                          join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                          on ((radno_mjesto)rmObj).id equals ((zaposlen)zaposlenObj).radno_mjesto
                          join osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                          on ((zaposlen)zaposlenObj).zaposlenik equals ((osoba)osobaObj).oib
                          join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                          on ((zaposlen)zaposlenObj).poduzece equals ((poduzece)poduzeceObj).oib
                          where ((osoba)osobaObj).ime == ImeIPrezime[0] &&
                                ((osoba)osobaObj).prezime == ImeIPrezime[1] &&
                                ((zaposlen)zaposlenObj).datum_zavrsetka == null &&
                                ((poduzece)poduzeceObj).naziv == poduzeceComboBox.SelectedValue.ToString()
                          select ((radno_mjesto)rmObj).naziv).ToArray();
                string[] svaRadnaMjesta =
                    (from rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                     select ((radno_mjesto)rmObj).naziv).ToArray();

                radno_mjestoComboBox.DataSource = svaRadnaMjesta.Except(radnaMjestaZaposlenika).ToList();
            }
            else
            {
                string[] radnaMjestaVanjskih = { "vozač", "naručitelj" };
                radno_mjestoComboBox.DataSource = radnaMjestaVanjskih;
            }
            radno_mjestoComboBox.SelectedIndex = -1;
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
            if (poduzeceComboBox.SelectedValue != null)
            {
                string[] osobePoduzeca =
               (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                on ((osoba)zaposlenikObj).oib equals ((zaposlen)zaposlenObj).zaposlenik
                join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                on ((zaposlen)zaposlenObj).poduzece equals ((poduzece)poduzeceObj).oib
                where ((poduzece)poduzeceObj).naziv == poduzeceComboBox.SelectedValue.ToString() &&
                      ((zaposlen)zaposlenObj).datum_zavrsetka == null
                select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();

                string[] sveOsobe=
                    (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                     select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();

                var ZaposleneOsobe =
                    (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                    join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                    on ((osoba)zaposlenikObj).oib equals ((zaposlen)zaposlenObj).zaposlenik                    
                    select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();

                zaposlenikComboBox.DataSource = sveOsobe.Except(ZaposleneOsobe).Union(osobePoduzeca).ToArray();
                zaposlenikComboBox.SelectedIndex = -1;
            }
            if (zaposlenikComboBox.SelectedValue != null && poduzeceComboBox.SelectedValue != null)
            {
                napraviDataSourceZaRadnoMjesto();
            }
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

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
    public partial class frmZaposlen :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmZaposlen() : base(false)
        {
            InitializeComponent();

            poduzeceComboBox.DataSource =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 select ((poduzece)poduzeceObj).naziv).ToArray();
            poduzeceComboBox.SelectedIndex = -1;

            zaposlenikComboBox.DataSource = 
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            zaposlenikComboBox.SelectedIndex = -1;
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
            radno_mjestoComboBox.SelectedIndex = -1;
            UpozorenjeRadnoMjesto.Hide();
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
            if(radno_mjestoComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeRadnoMjesto);
            }          
            if(radno_mjestoComboBox.SelectedIndex != -1 && zaposlenikComboBox.SelectedIndex == -1 && poduzeceComboBox.SelectedIndex == -1 && provjeriIspravnostDatuma())
            {
                //pohrani podatke u klasu i pošalji u BP
                this.Close();
            }
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

        private void napraviDataSourceZaRadnoMjesto()
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
            radno_mjestoComboBox.SelectedIndex = -1;
        }

        private void zaposlenikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeZaposlenik.Hide();
            if (zaposlenikComboBox.SelectedValue != null && poduzeceComboBox.SelectedValue != null)
            {
                napraviDataSourceZaRadnoMjesto();
            }
        }

        private void poduzeceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjePoduzece.Hide();
            if (zaposlenikComboBox.SelectedValue != null && poduzeceComboBox.SelectedValue != null)
            {
                napraviDataSourceZaRadnoMjesto();
            }
        }
    }
}

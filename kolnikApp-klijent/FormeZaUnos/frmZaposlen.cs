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
        private string nadjiPoduzece()
        {
            string[] poduzece =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 where ((poduzece)poduzeceObj).naziv == poduzeceComboBox.SelectedValue.ToString()
                 select ((poduzece)poduzeceObj).oib).ToArray();
            return poduzece[0];
        }

        private string nadjiZaposlenika()
        {
            string[] imeZaposlenika = zaposlenikComboBox.SelectedValue.ToString().Split(' ');
            string[] oibZaposlenika =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]                                 
                 where ((osoba)zaposlenikObj).ime == imeZaposlenika[0] && ((osoba)zaposlenikObj).prezime == imeZaposlenika[1]
                 select ((osoba)zaposlenikObj).oib).ToArray();
            return oibZaposlenika[0];
        }

        private int nadjiRadnoMjesto()
        {
            int[] radnoMjesto =
                (from rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 where ((radno_mjesto)rmObj).naziv == radno_mjestoComboBox.SelectedValue.ToString()
                 select ((radno_mjesto)rmObj).id).ToArray();
            return radnoMjesto[0];
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
            if(radno_mjestoComboBox.SelectedIndex != -1 && zaposlenikComboBox.SelectedIndex != -1 && poduzeceComboBox.SelectedIndex != -1 && provjeriIspravnostDatuma())
            {
                zaposlen newInstance;
                if (datum_zavrsetkaDateTimePicker.Checked)
                {
                    newInstance = new zaposlen
                    {
                        poduzece = nadjiPoduzece(),
                        zaposlenik = nadjiZaposlenika(),
                        radno_mjesto = nadjiRadnoMjesto(),
                        datum_pocetka = datum_pocetkaDateTimePicker.Value,
                        datum_zavrsetka = datum_zavrsetkaDateTimePicker.Value
                    };
                }
                else
                {
                    newInstance = new zaposlen
                    {
                        poduzece = nadjiPoduzece(),
                        zaposlenik = nadjiZaposlenika(),
                        radno_mjesto = nadjiRadnoMjesto(),
                        datum_pocetka = datum_pocetkaDateTimePicker.Value,
                    };
                }
                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newInstance), 'C');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
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
    }
}

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

        zaposlen oldInstance;
        public frmZaposlenUpdate(DataGridViewRow PodatkovniRedak, DataGridViewRow DodatniRedak) : base(false)
        {
            InitializeComponent();
            radno_mjestoComboBox.SelectedItem = DodatniRedak.Cells["radno_mjesto"].Value;

            poduzeceComboBox.DataSource =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 select ((poduzece)poduzeceObj).naziv).ToArray();
            poduzeceComboBox.SelectedItem = PodatkovniRedak.Cells["naziv"].Value;
            poduzeceComboBox.Enabled = false;

            zaposlenikComboBox.SelectedItem = DodatniRedak.Cells[1].Value + " " + DodatniRedak.Cells[2].Value;
            string[] workingPlacesNamesOfForeignEmployees = { "vozač", "naručitelj"};
            radno_mjestoComboBox.DataSource = poduzeceComboBox.SelectedValue.ToString() == "Kolnik d.o.o" ? workingPlacesNamesOfForeignEmployees :
                 (from rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                  where workingPlacesNamesOfForeignEmployees.Contains(((radno_mjesto)rmObj).naziv)
                  select ((radno_mjesto)rmObj).naziv).ToArray();

            datum_pocetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_pocetka"].Value;
            datum_zavrsetkaDateTimePicker.Checked = false;
            int idOfWorkingPlace = (from radnoMjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                    where ((radno_mjesto)radnoMjestoObj).naziv == DodatniRedak.Cells[5].Value.ToString()
                                    select ((radno_mjesto)radnoMjestoObj).id).First();
            oldInstance = new zaposlen
            {
                id = GetIdentityOfEmployeeRole(DodatniRedak.Cells[0].Value.ToString(), PodatkovniRedak.Cells[0].Value.ToString(), idOfWorkingPlace, (DateTime)DodatniRedak.Cells[3].Value),
                zaposlenik= DodatniRedak.Cells[0].Value.ToString(),
                poduzece= PodatkovniRedak.Cells[0].Value.ToString(),
                radno_mjesto= idOfWorkingPlace,
                datum_pocetka = (DateTime)DodatniRedak.Cells["datum_pocetka"].Value
            };
            if (DodatniRedak.Cells["datum_zavrsetka"].Value == null)
            {
                oldInstance.datum_zavrsetka = null;
            }
            else
            {
                oldInstance.datum_zavrsetka = (DateTime)DodatniRedak.Cells["datum_zavrsetka"].Value;
            }
        }

        private int GetIdentityOfEmployeeRole(string oibZaposlenik, string oibPoduzece, int radnoMjesto, DateTime datumPocetka)
        {
            return (from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                    where ((zaposlen)zaposlenObj).poduzece == oibPoduzece
                    && ((zaposlen)zaposlenObj).zaposlenik == oibZaposlenik
                    && ((zaposlen)zaposlenObj).radno_mjesto == radnoMjesto
                    && ((zaposlen)zaposlenObj).datum_pocetka == datumPocetka
                    select ((zaposlen)zaposlenObj).id
                    ).First();
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

            if (zaposlenikComboBox.SelectedIndex != -1 && poduzeceComboBox.SelectedIndex != -1 && provjeriIspravnostDatuma())
            {
                string companyId = (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                                 where ((poduzece)poduzeceObj).naziv == poduzeceComboBox.SelectedValue.ToString()
                                 select ((poduzece)poduzeceObj).oib).First();
                int workingPlaceId = (from radnoMjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                      where ((radno_mjesto)radnoMjestoObj).naziv == radno_mjestoComboBox.SelectedValue.ToString()
                                      select ((radno_mjesto)radnoMjestoObj).id).First();
                string employeeId = (from osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                                    where ((osoba)osobaObj).ime + " " + ((osoba)osobaObj).prezime == zaposlenikComboBox.SelectedValue.ToString()
                                    select ((osoba)osobaObj).oib).First();

                zaposlen newInstance = new zaposlen
                {
                    id = oldInstance.id,
                    poduzece = companyId,
                    zaposlenik = employeeId,
                    radno_mjesto = workingPlaceId,
                    datum_pocetka = datum_pocetkaDateTimePicker.Value,
                    datum_zavrsetka = datum_zavrsetkaDateTimePicker.Value
                };
                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
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
                where ((poduzece)poduzeceObj).naziv == poduzeceComboBox.SelectedValue.ToString()
                select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();

                zaposlenikComboBox.DataSource = osobePoduzeca;
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

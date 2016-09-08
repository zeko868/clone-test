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
    public partial class frmNarudzbenicaBitumenskeMjesavineUpdate :
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

        narudzbenica_bitumenske_mjesavine oldInstance = null;
        public frmNarudzbenicaBitumenskeMjesavineUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
            PodaciZaOldInstance objekt = new PodaciZaOldInstance();
            dohvatiPodatke(int.Parse(PodatkovniRedak.Cells["id_narudzbenica"].Value.ToString()));
            oldInstance = new narudzbenica_bitumenske_mjesavine
            {
                id = int.Parse(PodatkovniRedak.Cells["id_narudzbenica"].Value.ToString()),
                datum_izdavanja = (DateTime)PodatkovniRedak.Cells["datum_izdavanja"].Value,
                datum_potrazivanja = (DateTime)PodatkovniRedak.Cells["datum_potrazivanja"].Value,
                izdavatelj = objekt.izdavatelj,
                artikl = objekt.artikl,
                vozi = objekt.vozi,
                kolicina = decimal.Parse(PodatkovniRedak.Cells["kolicina"].Value.ToString())
            };
            datum_izdavanjaDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_izdavanja"].Value;
            datum_potrazivanjaDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_potrazivanja"].Value;

            izdavateljComboBox.DataSource =
                (from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 join osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((zaposlen)zaposlenObj).zaposlenik equals ((osoba)osobaObj).oib
                 join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 on ((zaposlen)zaposlenObj).poduzece equals ((poduzece)poduzeceObj).oib
                 join rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 on ((zaposlen)zaposlenObj).radno_mjesto equals ((radno_mjesto)rmObj).id
                 where ((radno_mjesto)rmObj).naziv == "naručitelj" && ((zaposlen)zaposlenObj).datum_zavrsetka == null
                 select ((osoba)osobaObj).ime + " " + ((osoba)osobaObj).prezime + " (" + ((poduzece)poduzeceObj).naziv + ")").ToArray();
            izdavateljComboBox.SelectedItem = PodatkovniRedak.Cells["izdavatelj"].Value;

            artiklComboBox.DataSource =
                (from artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 select ((artikl)artiklObj).naziv).ToArray();
            artiklComboBox.SelectedItem = PodatkovniRedak.Cells["artikl"].Value;

            voziComboBox.DataSource =
                (from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                 join voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                 on ((vozi)voziObj).vozilo equals ((vozilo)voziloObj).registracijski_broj
                 join osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((vozi)voziObj).vozac equals ((osoba)osobaObj).oib
                 where ((vozi)voziObj).datum_zavrsetka == null
                 select ((osoba)osobaObj).ime + " " + ((osoba)osobaObj).prezime + " (" + ((vozi)voziObj).vozilo + ")").ToArray();
            voziComboBox.SelectedItem = PodatkovniRedak.Cells["vozi"].Value;

            kolicinaTextBox.Text = PodatkovniRedak.Cells["kolicina"].Value.ToString();
        }

        private void dohvatiPodatke(int key)
        {
            var podaci =
                (from narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                 where ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id == key
                 select new PodaciZaOldInstance
                 {
                     artikl = ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl,
                     vozi = ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).vozi,
                     izdavatelj = ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).izdavatelj
                 }).ToArray();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenja = "Odaberite element";
            LabelaUpozorenja.Text = TekstUpozorenja;
            LabelaUpozorenja.Show();
        }

        private bool provjeriIspravnostDatuma()
        {
            return (datum_izdavanjaDateTimePicker.Value <= datum_potrazivanjaDateTimePicker.Value) ? true : false;
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (izdavateljComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeIzdavatelj);
            }
            if (voziComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeVozi);
            }
            if (artiklComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeArtikl);
            }
            if (kolicinaTextBox.Text == "")
            {
                UpozorenjeKolicina.Text = "Polje mora biti popunjeno";
                UpozorenjeKolicina.Show();
            }
            if (provjeriIspravnostDatuma() && izdavateljComboBox.SelectedIndex != -1 && voziComboBox.SelectedIndex != -1 && artiklComboBox.SelectedIndex != -1 && kolicinaTextBox.Text != "")
            {
                narudzbenica_bitumenske_mjesavine newInstance = new narudzbenica_bitumenske_mjesavine
                {
                    id=oldInstance.id,
                    datum_izdavanja = datum_izdavanjaDateTimePicker.Value,
                    datum_potrazivanja = datum_potrazivanjaDateTimePicker.Value,
                    izdavatelj = nadjiIzdavatelja(),
                    artikl = nadjiartikl(),
                    vozi = nadjivozi(),
                    kolicina = decimal.Parse(kolicinaTextBox.Text.ToString())
                };

                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                this.Close();
            }
        }
        private string nadjiIzdavatelja()
        {
            string[] imeIzdavatelja = izdavateljComboBox.SelectedValue.ToString().Split(' ');
            var izdavatelj =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 where ((osoba)zaposlenikObj).ime == imeIzdavatelja[0] && ((osoba)zaposlenikObj).prezime == imeIzdavatelja[1]
                 select ((osoba)zaposlenikObj).oib).ToArray();
            return izdavatelj[0];
        }
        private int nadjiartikl()
        {
            var artikl =
                (from artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 where ((artikl)artiklObj).naziv == artiklComboBox.SelectedValue.ToString()
                 select ((artikl)artiklObj).id).ToArray();
            return artikl[0];
        }
        private int nadjivozi()
        {
            string[] podniz = voziComboBox.SelectedValue.ToString().Split('(');
            string[] imeVozaca = podniz[0].Split(' ');
            string[] registracija = podniz[1].Split(')');
            var vozi =
                (from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                 join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((vozi)voziObj).vozac equals ((osoba)zaposlenikObj).oib
                 where ((vozi)voziObj).vozilo == registracija[0] &&
                       ((osoba)zaposlenikObj).ime == imeVozaca[0] && ((osoba)zaposlenikObj).prezime == imeVozaca[1]
                 select ((vozi)voziObj).id).ToArray();
            return vozi[0];
        }
        private void datum_izdavanjaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (provjeriIspravnostDatuma())
            {
                UpozorenjeDatumi.Hide();
            }
            else
            {
                UpozorenjeDatumi.Show();
            }
        }

        private void datum_potrazivanjaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (provjeriIspravnostDatuma())
            {
                UpozorenjeDatumi.Hide();
            }
            else
            {
                UpozorenjeDatumi.Show();
            }
        }

        private void izdavateljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeIzdavatelj.Hide();
        }

        private void artiklComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeArtikl.Hide();
        }

        private void voziComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeVozi.Hide();
        }

        private void kolicinaTextBox_Leave(object sender, EventArgs e)
        {
            if (kolicinaTextBox.Text == "")
            {
                UpozorenjeKolicina.Text = "Polje mora biti popunjeno";
                UpozorenjeKolicina.Show();
            }
            else
            {
                UpozorenjeKolicina.Hide();
            }
        }
    }
}

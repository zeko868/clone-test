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
        public frmNarudzbenicaBitumenskeMjesavineUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
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
                //pohraniti podatke u klasu i poslati u BP
                this.Close();
            }
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

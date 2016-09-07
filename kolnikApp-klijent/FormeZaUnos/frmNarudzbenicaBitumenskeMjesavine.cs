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
    public partial class frmNarudzbenicaBitumenskeMjesavine :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmNarudzbenicaBitumenskeMjesavine() : base(false)
        {
            InitializeComponent();
            izdavateljComboBox.DataSource =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 select new {
                     naziv = ((poduzece)poduzeceObj).naziv,
                     sifra = ((poduzece)poduzeceObj).oib
                 }).ToArray();
            izdavateljComboBox.DisplayMember = "naziv";
            izdavateljComboBox.ValueMember = "sifra";
            izdavateljComboBox.SelectedIndex = -1;

            artiklComboBox.DataSource =
                (from artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 select new
                 {
                     naziv = ((artikl)artiklObj).naziv,
                     sifra = ((artikl)artiklObj).id
                 }).ToArray();
            artiklComboBox.DisplayMember = "naziv";
            artiklComboBox.ValueMember = "sifra";
            artiklComboBox.SelectedIndex = -1;

            voziComboBox.DataSource =
                (from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                 join voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                 on ((vozi)voziObj).vozilo equals ((vozilo)voziloObj).registracijski_broj
                 join osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((vozi)voziObj).vozac equals ((osoba)osobaObj).oib
                 where ((vozi)voziObj).datum_zavrsetka == null
                 select new {
                     naziv = ((osoba)osobaObj).ime + " " + ((osoba)osobaObj).prezime + " (" + ((vozi)voziObj).vozilo + ")",
                     sifra = ((vozi)voziObj).id
                 }).ToArray();
            voziComboBox.DisplayMember = "naziv";
            voziComboBox.ValueMember = "sifra";
            voziComboBox.SelectedIndex = -1;

            izdavateljComboBox.DataSource =
                (from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 join osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((zaposlen)zaposlenObj).zaposlenik equals ((osoba)osobaObj).oib
                 join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 on ((zaposlen)zaposlenObj).poduzece equals ((poduzece)poduzeceObj).oib
                 join rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 on ((zaposlen)zaposlenObj).radno_mjesto equals ((radno_mjesto)rmObj).id
                 where ((radno_mjesto)rmObj).naziv == "naručitelj" && ((zaposlen)zaposlenObj).datum_zavrsetka == null
                 select new {
                     naziv=((osoba)osobaObj).ime + " " + ((osoba)osobaObj).prezime + " (" + ((poduzece)poduzeceObj).naziv + ")",
                     sifra=((osoba)osobaObj).oib
                 }).ToArray();
            izdavateljComboBox.DisplayMember = "naziv";
            izdavateljComboBox.ValueMember = "sifra";
            izdavateljComboBox.SelectedIndex = -1;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            datum_potrazivanjaDateTimePicker.Value = DateTime.Now;
            datum_izdavanjaDateTimePicker.Value = DateTime.Now;
            izdavateljComboBox.SelectedIndex = -1;
            voziComboBox.SelectedIndex = -1;
            artiklComboBox.SelectedIndex = -1;
            kolicinaTextBox.Text = "";
            UpozorenjeIzdavatelj.Hide();
            UpozorenjeDatumi.Hide();
            UpozorenjeArtikl.Hide();
            UpozorenjeDatumi.Hide();
            UpozorenjeKolicina.Hide();
            UpozorenjeVozi.Hide();
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
            if(izdavateljComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeIzdavatelj);
            }
            if(voziComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeVozi);
            }
            if (artiklComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeArtikl);
            }
            if(kolicinaTextBox.Text == "")
            {
                UpozorenjeKolicina.Text = "Polje mora biti popunjeno";
                UpozorenjeKolicina.Show();
            }
            if(provjeriIspravnostDatuma() && izdavateljComboBox.SelectedIndex != -1 && voziComboBox.SelectedIndex != -1 && artiklComboBox.SelectedIndex != -1 && kolicinaTextBox.Text != "")
            {
                narudzbenica_bitumenske_mjesavine newInstance = new narudzbenica_bitumenske_mjesavine
                {
                    datum_izdavanja = datum_izdavanjaDateTimePicker.Value,
                    datum_potrazivanja = datum_potrazivanjaDateTimePicker.Value,
                    izdavatelj = izdavateljComboBox.SelectedValue.ToString(),
                    artikl = int.Parse(artiklComboBox.SelectedValue.ToString()),
                    vozi = int.Parse(voziComboBox.SelectedValue.ToString()),
                    kolicina = int.Parse(kolicinaTextBox.Text)
                };
            string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newInstance), 'C');
            sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));

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
            if(kolicinaTextBox.Text == "")
            {
                UpozorenjeKolicina.Text= "Polje mora biti popunjeno";
                UpozorenjeKolicina.Show();
            }
            else
            {
                UpozorenjeKolicina.Hide();
            }
        }
    }
}

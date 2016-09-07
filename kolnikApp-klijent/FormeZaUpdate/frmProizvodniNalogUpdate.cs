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
    public partial class frmProizvodniNalogUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmProizvodniNalogUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();

            datum_izdavanjaDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_izdavanja"].Value;

            izdavateljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 where ((osoba)zaposlenikObj).oib == ((zaposlen)zaposlenObj).zaposlenik &&
                       ((zaposlen)zaposlenObj).radno_mjesto == ((radno_mjesto)radno_mjestoObj).id &&
                       ((radno_mjesto)radno_mjestoObj).naziv == "otpremitelj" &&
                       ((zaposlen)zaposlenObj).datum_zavrsetka == null
                 select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            izdavateljComboBox.SelectedItem = PodatkovniRedak.Cells["izdavatelj"].Value;

            narudzbenicaComboBox.DataSource=
                (from narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                select ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id.ToString() + " - " + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).datum_potrazivanja + " (" + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")").ToArray();
            narudzbenicaComboBox.SelectedItem = PodatkovniRedak.Cells["narudzbenica"].Value;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja, string VrstaLabele)
        {
            string TekstUpozorenja = "Polje mora biti popunjeno";
            string TekstUpozorenjaComboBox = "Odaberite element";
            if (VrstaLabele == "ComboBox")
            {
                LabelaUpozorenja.Text = TekstUpozorenjaComboBox;
                LabelaUpozorenja.Show();
            }
            else
            {
                LabelaUpozorenja.Text = TekstUpozorenja;
                LabelaUpozorenja.Show();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (temperaturaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeTemperatura, "TextBox");
            }
            if (izdavateljComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeIzdavatelj, "ComboBox");
            }
            if (narudzbenicaComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeNarudzbenica, "ComboBox");
            }
            int VarijablaZaProvjeru = 0;
            if (int.TryParse(temperaturaTextBox.Text, out VarijablaZaProvjeru) && temperaturaTextBox.Text != "" && izdavateljComboBox.SelectedIndex != -1 && narudzbenicaComboBox.SelectedIndex != -1)
            {
                //spremi podatke u klasu i pošalji u BP
                this.Close();
            }
        }

        private void temperaturaTextBox_Leave(object sender, EventArgs e)
        {
            int VarijablaZaProvjeru = 0;
            if (temperaturaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeTemperatura, "TextBox");
            }
            else if (!int.TryParse(temperaturaTextBox.Text, out VarijablaZaProvjeru))
            {
                UpozorenjeTemperatura.Text = "Polje mora sadržavati broj";
                UpozorenjeTemperatura.Show();
            }
            else
            {
                UpozorenjeTemperatura.Hide();
            }
        }

        private void narudzbenicaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeNarudzbenica.Hide();
        }

        private void izdavateljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            izdavateljComboBox.Hide();
        }
    }
}

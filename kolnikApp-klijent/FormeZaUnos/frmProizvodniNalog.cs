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
    public partial class frmProizvodniNalog :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmProizvodniNalog() : base(false)
        {
            InitializeComponent();
            
            string[] SveNarudzbenice=
                (from narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                 join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                 select ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id.ToString() + " - " + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).datum_potrazivanja + " (" + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")").ToArray();

            string[] SviProizvodniNalozi=
                (from nalogObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["proizvodni_nalog"]
                 join narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                 on ((proizvodni_nalog)nalogObj).narudzbenica equals ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id
                 join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((proizvodni_nalog)nalogObj).izdavatelj equals ((osoba)zaposlenikObj).oib
                 join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                 select ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id.ToString() + " - " + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).datum_potrazivanja + " (" + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")").ToArray();

            narudzbenicaComboBox.DataSource = SveNarudzbenice.Except(SviProizvodniNalozi).ToList();
            narudzbenicaComboBox.SelectedIndex = -1;

            izdavateljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 where ((osoba)zaposlenikObj).oib == ((zaposlen)zaposlenObj).zaposlenik &&
                       ((zaposlen)zaposlenObj).radno_mjesto == ((radno_mjesto)radno_mjestoObj).id &&
                       ((radno_mjesto)radno_mjestoObj).naziv == "otpremitelj" &&
                       ((zaposlen)zaposlenObj).datum_zavrsetka == null
                 select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            izdavateljComboBox.SelectedIndex = -1;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            datum_izdavanjaDateTimePicker.Value = DateTime.Now;
            temperaturaTextBox.Text = "";
            izdavateljComboBox.SelectedIndex = -1;
            narudzbenicaComboBox.SelectedIndex = -1;
            UpozorenjeNarudzbenica.Hide();
            UpozorenjeTemperatura.Hide();
            UpozorenjeIzdavatelj.Hide();

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
            if(int.TryParse(temperaturaTextBox.Text, out VarijablaZaProvjeru) && temperaturaTextBox.Text != ""  && izdavateljComboBox.SelectedIndex != -1 && narudzbenicaComboBox.SelectedIndex != -1)
            {
                //spremi podatke u klasu i pošalji u BP
                this.Close();
            }
        }

        private void narudzbenicaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeNarudzbenica.Hide();
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

        private void izdavateljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            izdavateljComboBox.Hide();
        }
    }
}

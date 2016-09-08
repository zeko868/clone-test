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
    public partial class frmOtpremnica :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmOtpremnica() : base(false)
        {
            InitializeComponent();

            string []SviOtpremljeniNalozi=
                (from otpremnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["otpremnica"]
                 join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((otpremnica)otpremnicaObj).otpremitelj equals ((osoba)zaposlenikObj).oib
                 join narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                 on ((otpremnica)otpremnicaObj).nalog equals ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id
                 join voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                 on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).vozi equals ((vozi)voziObj).id
                 join vozacObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((vozi)voziObj).vozac equals ((osoba)vozacObj).oib
                 join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                 select ((otpremnica)otpremnicaObj).nalog.ToString() + " - " + ((osoba)vozacObj).ime + " " + ((osoba)vozacObj).prezime + " (" + 
                 ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")").ToArray();

            string []SviProizvodniNalozi=
                (from nalogObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["proizvodni_nalog"]
                join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                on ((proizvodni_nalog)nalogObj).izdavatelj equals ((osoba)zaposlenikObj).oib
                join narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                on ((proizvodni_nalog)nalogObj).narudzbenica equals ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id
                join voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).vozi equals ((vozi)voziObj).id
                join vozacObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                on ((vozi)voziObj).vozac equals ((osoba)vozacObj).oib
                join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                select ((proizvodni_nalog)nalogObj).narudzbenica.ToString() + " - " + ((osoba)vozacObj).ime + " " + ((osoba)vozacObj).prezime + " (" +
                ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")").ToArray();

            narudzbenicaComboBox.DataSource = SviProizvodniNalozi.Except(SviOtpremljeniNalozi).ToList();
            narudzbenicaComboBox.SelectedIndex = -1;

            izdavateljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 on ((osoba)zaposlenikObj).oib equals ((zaposlen)zaposlenObj).zaposlenik
                 join radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 on ((zaposlen)zaposlenObj).radno_mjesto equals ((radno_mjesto)radno_mjestoObj).id 
                 where ((radno_mjesto)radno_mjestoObj).naziv == "otpremitelj" && ((zaposlen)zaposlenObj).datum_zavrsetka == null
                 select new {
                    naziv=((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime,
                    sifra=((osoba)zaposlenikObj).oib
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
            narudzbenicaComboBox.SelectedIndex = -1;
            datum_otpremeDateTimePicker.Value = DateTime.Now;
            izdavateljComboBox.SelectedIndex = -1;
            UpozorenjeIzdavatelj.Hide();
            UpozorenjeNarudzbenica.Hide();

        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenjaComboBox = "Odaberite element";
            LabelaUpozorenja.Text = TekstUpozorenjaComboBox;
            LabelaUpozorenja.Show();
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (narudzbenicaComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeNarudzbenica);
            }
            if (izdavateljComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeIzdavatelj);
            }
            if(narudzbenicaComboBox.SelectedIndex != -1  &&   izdavateljComboBox.SelectedIndex != -1)
            {
                string[] narudzbenica = narudzbenicaComboBox.SelectedItem.ToString().Split('-');
                otpremnica newInstance = new otpremnica
                {
                    nalog = int.Parse(narudzbenica[0]),
                    datum_otpreme = datum_otpremeDateTimePicker.Value,
                    otpremitelj = izdavateljComboBox.SelectedValue.ToString()
                };
                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newInstance), 'C');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                this.Close();
            }
            
        }

        private void temeljnicaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeNarudzbenica.Hide();
        }

        private void otpremiteljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeIzdavatelj.Hide();
        }
    }
}

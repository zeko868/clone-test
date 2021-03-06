﻿using System;
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
    public partial class frmOtpremnicaUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        otpremnica oldInstance = null;
        public frmOtpremnicaUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
            string []kljuc = PodatkovniRedak.Cells["narudzbenica"].Value.ToString().Split(' ');
            oldInstance = new otpremnica
            {
                nalog = int.Parse(kljuc[0]),
                datum_otpreme = datum_otpremeDateTimePicker.Value,
                otpremitelj = nadjiIzdavatelja(PodatkovniRedak.Cells["izdavatelj"].Value.ToString()),
                racun = nadjiRacun(int.Parse(kljuc[0]))
            };
            narudzbenicaComboBox.DataSource=
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
            narudzbenicaComboBox.SelectedItem = PodatkovniRedak.Cells["narudzbenica"].Value;

            izdavateljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 on ((osoba)zaposlenikObj).oib equals ((zaposlen)zaposlenObj).zaposlenik
                 join radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 on ((zaposlen)zaposlenObj).radno_mjesto equals ((radno_mjesto)radno_mjestoObj).id
                 where ((radno_mjesto)radno_mjestoObj).naziv == "otpremitelj" && ((zaposlen)zaposlenObj).datum_zavrsetka == null
                 select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            izdavateljComboBox.SelectedItem = PodatkovniRedak.Cells["izdavatelj"].Value;

            datum_otpremeDateTimePicker.Value = (DateTime)PodatkovniRedak.Cells["datum_otpreme"].Value;
        }

        private int? nadjiRacun(int kljuc)
        {
            var racun =
                (from otpremnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["otpremnica"]
                 where ((otpremnica)otpremnicaObj).nalog == kljuc
                 select ((otpremnica)otpremnicaObj).racun).ToArray();
            return racun[0];
        }
        private string nadjiIzdavatelja(string podatak)
        {
            string[] imeIzdavatelja = podatak.Split(' ');
            string[] izdavatelj =
                (from otpremnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["otpremnica"]
                 join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((otpremnica)otpremnicaObj).otpremitelj equals ((osoba)zaposlenikObj).oib
                 where ((osoba)zaposlenikObj).ime == imeIzdavatelja[0] && ((osoba)zaposlenikObj).prezime == imeIzdavatelja[1]
                 select ((osoba)zaposlenikObj).oib).ToArray();
            return izdavatelj[0];
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
            if (narudzbenicaComboBox.SelectedIndex != -1 && izdavateljComboBox.SelectedIndex != -1)
            {
                otpremnica newInstance = new otpremnica
                {
                    nalog = oldInstance.nalog,
                    otpremitelj = nadjiIzdavatelja(izdavateljComboBox.SelectedValue.ToString()),
                    datum_otpreme = datum_otpremeDateTimePicker.Value,
                    racun = oldInstance.racun
                };

                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                this.Close();
            }

        }

        private void narudzbenicaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeNarudzbenica.Hide();
        }

        private void izdavateljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeIzdavatelj.Hide();
        }
    }
}

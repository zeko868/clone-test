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
    public partial class frmRacun :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        private BindingList<otpremnica> pridruzeneOtpremnice;
        private BindingList<otpremnica> raspoloziveOtpremnice;
        public frmRacun() : base(false)
        {
            InitializeComponent();
            izdavateljComboBox.DataSource =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 where ((osoba)zaposlenikObj).oib == ((zaposlen)zaposlenObj).zaposlenik &&
                       ((zaposlen)zaposlenObj).radno_mjesto == ((radno_mjesto)radno_mjestoObj).id &&
                       ((radno_mjesto)radno_mjestoObj).naziv == "računovođa"
                 select new
                 {
                     naziv = ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime,
                     sifra = ((osoba)zaposlenikObj).oib
                 }).ToArray();
            izdavateljComboBox.DisplayMember = "naziv";
            izdavateljComboBox.ValueMember = "sifra";
            izdavateljComboBox.SelectedIndex = -1;

            raspoloziveOtpremnice = new BindingList<otpremnica>((from otpremnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["otpremnica"]
                                                                                 where ((otpremnica)otpremnicaObj).racun == null
                                                                                 select new otpremnica
                                                                                 {
                                                                                     nalog = ((otpremnica)otpremnicaObj).nalog,
                                                                                     datum_otpreme = ((otpremnica)otpremnicaObj).datum_otpreme,
                                                                                     otpremitelj = ((otpremnica)otpremnicaObj).otpremitelj,
                                                                                     racun = null
                                                                                 }).ToList());
            pridruzeneOtpremnice = new BindingList<otpremnica>();
            RefreshDGVs();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            datum_izdavanjaDateTimePicker.Value = DateTime.Now;
            izdavateljComboBox.SelectedIndex = -1;
            UpozorenjeIzdavatelj.Hide();
            UpozorenjeOtpremnice.Hide();

            int collectionSize = pridruzeneOtpremnice.Count();
            if (collectionSize > 0)
            {
                do
                {
                    collectionSize--;
                    raspoloziveOtpremnice.Add(pridruzeneOtpremnice[collectionSize]);
                    pridruzeneOtpremnice.RemoveAt(collectionSize);
                } while (collectionSize != 0);
                RefreshDGVs();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            bool performSave = true;
            if (izdavateljComboBox.SelectedIndex == -1)
            {
                UpozorenjeIzdavatelj.Text = "Odaberite element";
                UpozorenjeIzdavatelj.Show();
                performSave = false;
            }
            if (pridruzeneOtpremnice.Count() == 0)
            {
                UpozorenjeOtpremnice.Text = "Račun mora imati pridruženu minimalno jednu otpremnicu";
                UpozorenjeOtpremnice.Show();
                performSave = false;
            }
            if (performSave)
            {
                //stavi podatke u klasu i pošalji u BP
                racun newInstance = new racun
                {
                    datum_izdavanja = datum_izdavanjaDateTimePicker.Value,
                    izdavatelj = izdavateljComboBox.SelectedValue.ToString(),
                    placeno = placenoCheckBox.Checked
                };
                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newInstance), 'C');
                string otpremnice = "";
                foreach (otpremnica otpremnicaObj in pridruzeneOtpremnice)
                {
                    otpremnice += DataHandler.SerializeUpdatedObject(otpremnicaObj, otpremnicaObj);
                }
                dataForSending += DataHandler.AddHeaderInfoToXMLDatagroup(otpremnice, 'U');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                this.Close();
            }
        }

        private void izdavateljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeIzdavatelj.Hide();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (raspoloziveOtpremniceDgv.SelectedRows.Count > 0)
            {
                int indexOfSelectedRow = raspoloziveOtpremniceDgv.SelectedRows[0].Index;
                pridruzeneOtpremnice.Add(raspoloziveOtpremnice[indexOfSelectedRow]);
                raspoloziveOtpremnice.RemoveAt(indexOfSelectedRow);
                RefreshDGVs();
                UpozorenjeOtpremnice.Hide();
            }
        }

        private void btnDodajSve_Click(object sender, EventArgs e)
        {
            int collectionSize = raspoloziveOtpremnice.Count();
            if (collectionSize > 0)
            {
                do
                {
                    collectionSize--;
                    pridruzeneOtpremnice.Add(raspoloziveOtpremnice[collectionSize]);
                    raspoloziveOtpremnice.RemoveAt(collectionSize);
                } while (collectionSize != 0);
                RefreshDGVs();
                UpozorenjeOtpremnice.Hide();
            }
        }

        private void btnMakni_Click(object sender, EventArgs e)
        {
            if (pridruzeneOtpremniceDgv.SelectedRows.Count > 0)
            {
                int indexOfSelectedRow = pridruzeneOtpremniceDgv.SelectedRows[0].Index;
                raspoloziveOtpremnice.Add(pridruzeneOtpremnice[indexOfSelectedRow]);
                pridruzeneOtpremnice.RemoveAt(indexOfSelectedRow);
                RefreshDGVs();
            }
        }

        private void btnMakniSve_Click(object sender, EventArgs e)
        {
            int collectionSize = pridruzeneOtpremnice.Count();
            if (collectionSize > 0)
            {
                do
                {
                    collectionSize--;
                    raspoloziveOtpremnice.Add(pridruzeneOtpremnice[collectionSize]);
                    pridruzeneOtpremnice.RemoveAt(collectionSize);
                } while (collectionSize != 0);
                RefreshDGVs();
            }
        }
        private void RefreshDGVs()
        {
            raspoloziveOtpremniceDgv.DataSource = (from otpremnicaObj in raspoloziveOtpremnice
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
                                                   where ((otpremnica)otpremnicaObj).racun == null
                                                   select new
                                                   {
                                                       Narudžbenica = ((otpremnica)otpremnicaObj).nalog.ToString() + " - " + ((osoba)vozacObj).ime + " " + ((osoba)vozacObj).prezime + " (" + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")",
                                                       Izdavatelj = ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime,
                                                       Datum_otpreme = ((otpremnica)otpremnicaObj).datum_otpreme
                                                   }).ToList();
            pridruzeneOtpremniceDgv.DataSource = (from otpremnicaObj in pridruzeneOtpremnice
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
                                                  where ((otpremnica)otpremnicaObj).racun == null
                                                  select new
                                                  {
                                                      Narudžbenica = ((otpremnica)otpremnicaObj).nalog.ToString() + " - " + ((osoba)vozacObj).ime + " " + ((osoba)vozacObj).prezime + " (" + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")",
                                                      Izdavatelj = ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime,
                                                      Datum_otpreme = ((otpremnica)otpremnicaObj).datum_otpreme
                                                  }).ToList();
        }

        private void raspoloziveOtpremniceDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                pridruzeneOtpremnice.Add(raspoloziveOtpremnice[e.RowIndex]);
                raspoloziveOtpremnice.RemoveAt(e.RowIndex);
                RefreshDGVs();
                UpozorenjeOtpremnice.Hide();
            }
        }

        private void pridruzeneOtpremniceDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                raspoloziveOtpremnice.Add(pridruzeneOtpremnice[e.RowIndex]);
                pridruzeneOtpremnice.RemoveAt(e.RowIndex);
                RefreshDGVs();
            }
        }
    }
}

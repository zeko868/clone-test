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
    public partial class frmVozi :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmVozi() : base(false)
        {
            InitializeComponent();
            voziloComboBox.DataSource = (from voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                                         select ((vozilo)voziloObj).registracijski_broj).ToArray(); 
            voziloComboBox.SelectedIndex = -1;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            voziloComboBox.SelectedIndex = -1;
            vozacComboBox.SelectedIndex = -1;
            datum_pocetkaDateTimePicker.Value = DateTime.Now;
            datum_zavrsetkaDateTimePicker.Value = DateTime.Now;
            UpozorenjeVozac.Hide();
            UpozorenjeVozilo.Hide();
            UpozorenjeDatumi.Hide();
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
            if (vozacComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeVozac);
            }
            if (voziloComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeVozilo);
            }
            if (vozacComboBox.SelectedIndex != -1 && voziloComboBox.SelectedIndex != -1 && provjeriIspravnostDatuma())
            {
                //spremiti podatke u klasu i poslati u BP
                this.Close();
            }
                
        }

        private void voziloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeVozilo.Hide();
            if (voziloComboBox.SelectedValue != null) { 
            string[] VozaciKojiVozeVozilo = (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                                             from voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                                             from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                                             where ((osoba)zaposlenikObj).oib == ((vozi)voziObj).vozac &&
                                                   ((vozilo)voziloObj).registracijski_broj == ((vozi)voziObj).vozilo &&
                                                   ((vozilo)voziloObj).registracijski_broj == voziloComboBox.SelectedValue.ToString() &&
                                                   ((vozi)voziObj).datum_zavrsetka == null
                                             select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();

            string[] SviVozaci = (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                                  join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                                  on ((osoba)zaposlenikObj).oib equals ((zaposlen)zaposlenObj).zaposlenik
                                  join rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                  on ((zaposlen)zaposlenObj).radno_mjesto equals ((radno_mjesto)rmObj).id
                                  where ((radno_mjesto)rmObj).naziv == "vozač"
                                  select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            var Filtrirano = SviVozaci.Except(VozaciKojiVozeVozilo);
            vozacComboBox.DataSource = Filtrirano.ToList();
            vozacComboBox.SelectedIndex = -1;
        }
        }

        private void vozacComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeVozac.Hide();
        }

        private void datum_pocetkaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool IspravniDatum = provjeriIspravnostDatuma();
            {
                if (IspravniDatum)
                {
                    UpozorenjeDatumi.Hide();
                }
                else
                {
                    UpozorenjeDatumi.Show();
                }
            }
        }

        private void datum_zavrsetkaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            bool IspravniDatum = provjeriIspravnostDatuma();
            {
                if (IspravniDatum)
                {
                    UpozorenjeDatumi.Hide();
                }
                else
                {
                    UpozorenjeDatumi.Show();
                }
            }
        }
    }
}

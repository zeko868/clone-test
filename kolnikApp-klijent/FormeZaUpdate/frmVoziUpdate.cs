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
    public partial class frmVoziUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmVoziUpdate(DataGridViewRow PodatkovniRedak, DataGridViewRow DodatniRedak) : base(false)
        {
            InitializeComponent();
            vozacComboBox.DataSource=
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 on ((osoba)zaposlenikObj).oib equals ((zaposlen)zaposlenObj).zaposlenik
                 join rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 on ((zaposlen)zaposlenObj).radno_mjesto equals ((radno_mjesto)rmObj).id
                 where ((radno_mjesto)rmObj).naziv == "vozač"
                 select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            vozacComboBox.SelectedText = DodatniRedak.Cells["ime"].Value.ToString() + " " + DodatniRedak.Cells["prezime"].Value.ToString();

            voziloComboBox.DataSource = (from voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                                         select ((vozilo)voziloObj).registracijski_broj).ToArray();
            voziloComboBox.SelectedItem = PodatkovniRedak.Cells["registracijski_broj"].Value;

            datum_pocetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_pocetka"].Value;
            if(DodatniRedak.Cells["datum_zavrsetka"].Value == null)
            {
                datum_pocetkaDateTimePicker.Checked = false;
            }
            else
            {
                datum_pocetkaDateTimePicker.Checked = true;
                datum_zavrsetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_zavrsetka"].Value;
            }
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

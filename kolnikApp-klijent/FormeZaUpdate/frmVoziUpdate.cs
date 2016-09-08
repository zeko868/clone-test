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
        vozi oldInstance;
        public frmVoziUpdate(DataGridViewRow PodatkovniRedak, DataGridViewRow DodatniRedak) : base(false)
        {
            InitializeComponent();
            string vozilo = PodatkovniRedak.Cells["registracijski_broj"].Value.ToString();
            string vozac = DodatniRedak.Cells["OIB"].Value.ToString();
            if (DodatniRedak.Cells["datum_zavrsetka"].Value == null)
            {
                oldInstance = new vozi
                {
                    //id=nadjiId(vozilo,vozac),
                    vozac = vozac,
                    vozilo = vozilo,
                    datum_pocetka = (DateTime)DodatniRedak.Cells["datum_pocetka"].Value
                };
            }
            else
            {
                oldInstance = new vozi
                {
                    //id = nadjiId(vozilo, vozac),
                    vozac = DodatniRedak.Cells["OIB"].Value.ToString(),
                    vozilo = PodatkovniRedak.Cells["registracijski_broj"].Value.ToString(),
                    datum_pocetka = (DateTime)DodatniRedak.Cells["datum_pocetka"].Value,
                    datum_zavrsetka= (DateTime)DodatniRedak.Cells["datum_zavrsetka"].Value
                };
            }
            vozacComboBox.DataSource=
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                 on ((osoba)zaposlenikObj).oib equals ((zaposlen)zaposlenObj).zaposlenik
                 join rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                 on ((zaposlen)zaposlenObj).radno_mjesto equals ((radno_mjesto)rmObj).id
                 where ((radno_mjesto)rmObj).naziv == "vozač" && ((zaposlen)zaposlenObj).datum_zavrsetka == null
                 select ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime).ToArray();
            vozacComboBox.SelectedText = DodatniRedak.Cells["ime"].Value.ToString() + " " + DodatniRedak.Cells["prezime"].Value.ToString();

            voziloComboBox.DataSource = (from voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                                         select ((vozilo)voziloObj).registracijski_broj).ToArray();
            voziloComboBox.SelectedItem = PodatkovniRedak.Cells["registracijski_broj"].Value;

            datum_pocetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_pocetka"].Value;
            if(DodatniRedak.Cells["datum_zavrsetka"].Value == null)
            {
                datum_zavrsetkaDateTimePicker.Checked = false;
            }
            else
            {
                datum_zavrsetkaDateTimePicker.Checked = true;
                datum_zavrsetkaDateTimePicker.Value = (DateTime)DodatniRedak.Cells["datum_zavrsetka"].Value;
            }
        }

        private string nadjiVozaca(string key)
        {
            string[] ime = key.Split(' ');
            var vozac =
                (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 where ((osoba)zaposlenikObj).ime == ime[0] && ((osoba)zaposlenikObj).prezime == ime[1]
                 select ((osoba)zaposlenikObj).oib).ToArray();
            return vozac[0];
        }

        private int nadjiId(string vozilo, string vozac)
        {
            string[] ime = vozac.Split(' ');
            var id =
                (from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                 join osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                 on ((vozi)voziObj).vozac equals ((osoba)osobaObj).oib
                 where ((osoba)osobaObj).ime == ime[0] && ((osoba)osobaObj).prezime == ime[1] &&
                       ((vozi)voziObj).vozilo == vozilo && ((vozi)voziObj).datum_zavrsetka == null
                 select ((vozi)voziObj).id).ToArray();
            return id[0];
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
                string vozilo = voziloComboBox.SelectedValue.ToString();
                string vozac = nadjiVozaca(vozacComboBox.SelectedValue.ToString());
                vozi newInstance;
                if (datum_zavrsetkaDateTimePicker.Checked) {
                    newInstance = new vozi
                    {
                        vozilo = vozilo,
                        datum_pocetka=datum_pocetkaDateTimePicker.Value,
                        datum_zavrsetka = datum_zavrsetkaDateTimePicker.Value,
                        vozac = vozac,
                        //id=nadjiId(vozilo,vozac)
                    };
                }
                else
                {
                    newInstance = new vozi
                    {
                        vozilo = vozilo,
                        datum_pocetka = datum_pocetkaDateTimePicker.Value,
                        vozac = vozac,
                        //id = nadjiId(vozilo, vozac)
                    };
                }

            string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
            sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
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

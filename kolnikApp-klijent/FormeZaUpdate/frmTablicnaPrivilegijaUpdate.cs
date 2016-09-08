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
    public partial class frmTablicnaPrivilegijaUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        tablicna_privilegija oldInstance;
        public frmTablicnaPrivilegijaUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();

            oldInstance = new tablicna_privilegija
            {
                radno_mjesto = nadjiRadnoMjesto(PodatkovniRedak.Cells["radno_mjesto"].Value.ToString()),
                naziv_tablice = PodatkovniRedak.Cells["naziv_tablice"].Value.ToString(),
                operacija = izracunajOperaciju()
            };
            radno_mjestoComboBox.DataSource = (from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                               select ((radno_mjesto)radno_mjestoObj).naziv).ToArray();
            radno_mjestoComboBox.SelectedItem = PodatkovniRedak.Cells["radno_mjesto"].Value;
            radno_mjestoComboBox.Enabled = false;

            string[] tablice = DataHandler.entityNamesWithReferencesToBelongingDataStores.Keys.ToArray<string>();
            List<string> PopisTablica = new List<string>();
            foreach (var NazivTablice in tablice)
            {
                string uljepsanoIme = "";
                string[] ime = NazivTablice.Split('_');
                for (int i = 0; i < ime.Length; i++)
                {
                    uljepsanoIme += ime[i].First().ToString().ToUpper() + ime[i].Substring(1);
                    if (i + 1 != ime.Length)
                    {
                        uljepsanoIme += " ";
                    }
                }
                PopisTablica.Add(uljepsanoIme);
            }
            naziv_tabliceComboBox.DataSource = PopisTablica;
            for (int i = 0; i < tablice.Length; i++)
            {
                if (tablice[i] == PodatkovniRedak.Cells["naziv_tablice"].Value.ToString())
                {
                    naziv_tabliceComboBox.SelectedIndex = i;
                }
            }
            naziv_tabliceComboBox.Enabled = false;

            string[] operacije = PodatkovniRedak.Cells["operacija"].Value.ToString().Split(',');
            for (int i = 0; i < operacije.Count(); i++)
            {
                if (operacije[i].First() == ' ')
                {
                    operacije[i] = operacije[i].Substring(1);
                }
            }
            foreach (var op in operacije)
            {
                for (int i = 0; i < operacijeCheckedListBox.Items.Count; i++)
                {
                    if (operacijeCheckedListBox.Items[i].ToString() == (op.First().ToString().ToUpper() + op.Substring(1)))
                    {
                        operacijeCheckedListBox.SetItemChecked(i, true);
                        break;
                    }
                }
            }            
        }

        private int nadjiRadnoMjesto(string key)
        {
            var radMjesto=
                (from radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                where ((radno_mjesto)radno_mjestoObj).naziv== key
                select ((radno_mjesto)radno_mjestoObj).id).ToArray();
            return radMjesto[0];
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

        private byte izracunajOperaciju()
        {
            byte dopusteneOperacije = 0;
            for (int i = 0; i < operacijeCheckedListBox.Items.Count; i++)
            {
                if (operacijeCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    dopusteneOperacije += (byte)Math.Pow(2, i);
                }
            }
            return dopusteneOperacije;
        }
        private bool oznacenaBarJednaOpcija()
        {
            bool OznacenaOpcija = false;
            if (operacijeCheckedListBox.CheckedItems.Count > 0)
            {
                OznacenaOpcija = true;
                UpozorenjeCheckbox.Hide();
            }
            else
            {
                UpozorenjeCheckbox.Show();
            }
            return OznacenaOpcija;
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (radno_mjestoComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeRadnoMjesto);
            }
            if (naziv_tabliceComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeNazivTablice);
            }
            if (!oznacenaBarJednaOpcija())
            {
                UpozorenjeCheckbox.Show();
            }
            if (radno_mjestoComboBox.SelectedIndex != -1 && naziv_tabliceComboBox.SelectedIndex != -1 && oznacenaBarJednaOpcija())
            {

                tablicna_privilegija newInstance = new tablicna_privilegija
                {
                    radno_mjesto = nadjiRadnoMjesto(radno_mjestoComboBox.SelectedValue.ToString()),
                    naziv_tablice = oldInstance.naziv_tablice,
                    operacija = izracunajOperaciju()
                };

                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                this.Close();
            }

        }

        private void radno_mjestoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeRadnoMjesto.Hide();
        }

        private void naziv_tabliceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeNazivTablice.Hide();
        }

        private void operacijeCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpozorenjeCheckbox.Hide();
        }
    }
}

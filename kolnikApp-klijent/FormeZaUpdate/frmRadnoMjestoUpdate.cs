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
    public partial class frmRadnoMjestoUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        radno_mjesto oldInstance;
        public frmRadnoMjestoUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            oldInstance = new radno_mjesto
            {
                 id=int.Parse(PodatkovniRedak.Cells["id"].Value.ToString()),
                 naziv=PodatkovniRedak.Cells["naziv"].Value.ToString()
            };
            InitializeComponent();
            nazivTextBox.Text = PodatkovniRedak.Cells["naziv"].Value.ToString();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenja = "Polje mora biti popunjeno";
            LabelaUpozorenja.Text = TekstUpozorenja;
            LabelaUpozorenja.Show();
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (nazivTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeNaziv);
            }
            if (nazivTextBox.Text != "")
            {
                radno_mjesto newInstance = new radno_mjesto
                {
                    id = oldInstance.id,
                    naziv = nazivTextBox.Text
                };

                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));

                this.Close();
            }
        }

        private void nazivTextBox_Leave(object sender, EventArgs e)
        {
            if (nazivTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeNaziv);
            }
            else
            {
                UpozorenjeNaziv.Hide();
            }
        }
    }
}

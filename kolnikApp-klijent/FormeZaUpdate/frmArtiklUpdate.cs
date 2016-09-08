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
    /// <summary>
    /// Klasa za prikaz forme za modifikaciju artikala
    /// </summary>
    public partial class frmArtiklUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        /// <summary>
        /// Inicijalni mijenjani artikl
        /// </summary>
        artikl oldInstance = null;
        /// <summary>
        ///Kreira formu za modifikaciju artikala koja je naslijeđena od roditeljske forme sa definiranim svojstvima dizajna
        /// </summary>
        public frmArtiklUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();
            oldInstance = new artikl
            {
                id = int.Parse(PodatkovniRedak.Cells["id"].Value.ToString()),
                naziv = PodatkovniRedak.Cells["naziv"].Value.ToString(),
                jedinicna_cijena = decimal.Parse(PodatkovniRedak.Cells["jedinicna_cijena"].Value.ToString())
            };
            nazivTextBox.Text = PodatkovniRedak.Cells["naziv"].Value.ToString();
            jedinicna_cijenaTextBox.Text = PodatkovniRedak.Cells["jedinicna_cijena"].Value.ToString();
        }

        /// <summary>
        /// Zatvaranje forme pritiskom na naslijeđenu tipku za zatvaranje prozora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Prikaz pogrešaka koje su se dogodile kod (ne)unosa podataka u kontrole
        /// </summary>
        /// <param name="LabelaUpozorenja"></param>
        private void popuniLabeleUpozorenja(Label LabelaUpozorenja)
        {
            string TekstUpozorenja = "Polje mora biti popunjeno";
            LabelaUpozorenja.Text = TekstUpozorenja;
            LabelaUpozorenja.Show();
        }

        /// <summary>
        /// Prikaži potencijalnu pogrešku prilikom napuštanja kontrole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Prikaži potencijalnu pogrešku prilikom napuštanja kontrole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jedinicna_cijenaTextBox_Leave(object sender, EventArgs e)
        {
            float VarijablaZaProvjeru = 0;
            if (jedinicna_cijenaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeJedinicnaCijena);
            }
            else if (!float.TryParse(jedinicna_cijenaTextBox.Text, out VarijablaZaProvjeru))
            {
                UpozorenjeJedinicnaCijena.Text = "Polje mora sadržavati broj";
                UpozorenjeJedinicnaCijena.Show();
            }
            else
            {
                UpozorenjeJedinicnaCijena.Hide();
            }
        }

        /// <summary>
        /// Pokušaj slanja podataka poslužitelju ukoliko su ispravni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (jedinicna_cijenaTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeJedinicnaCijena);
            }
            if (nazivTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjeNaziv);
            }

            float VarijablaZaProvjeru = 0;
            if (float.TryParse(jedinicna_cijenaTextBox.Text, out VarijablaZaProvjeru) && nazivTextBox.Text != "" && jedinicna_cijenaTextBox.Text != "")
            {
                
                artikl newInstance = new artikl
                {
                    id = oldInstance.id,
                    naziv = nazivTextBox.Text,
                    jedinicna_cijena = decimal.Parse(jedinicna_cijenaTextBox.Text)
                };
                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                this.Close();
            }
        }
    }
}

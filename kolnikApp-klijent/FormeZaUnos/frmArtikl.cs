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

namespace kolnikApp_klijent.FormeZaUnos
{
    /// <summary>
    /// Klasa za prikaz forme za unos artikala
    /// </summary>
    public partial class frmArtikl :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        /// <summary>
        ///Kreira formu za unos artikala koja je naslijeđena od roditeljske forme sa definiranim svojstvima dizajna
        /// </summary>
        public frmArtikl() : base(false)
        {
            InitializeComponent();
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
        /// Resetiranje sadržaja svih kontrola za unos podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GumbReset_Click(object sender, EventArgs e)
        {
            nazivTextBox.Text = "";
            jedinicna_cijenaTextBox.Text = "";
            UpozorenjeJedinicnaCijena.Hide();
            UpozorenjeNaziv.Hide();
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
                artikl noviArtikl = new artikl
                {
                    naziv = nazivTextBox.Text,
                    jedinicna_cijena = int.Parse(jedinicna_cijenaTextBox.Text)
                };
                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(noviArtikl), 'C');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));

                this.Close();
            }      
        }
    }
}

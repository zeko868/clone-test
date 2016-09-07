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
    public partial class frmRabat :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        public frmRabat() : base(false)
        {
            InitializeComponent();
            artiklComboBox.DataSource =
                (from artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 select new
                 {
                     naziv = ((artikl)artiklObj).naziv,
                     sifra = ((artikl)artiklObj).id
                 }).ToArray();
            artiklComboBox.DisplayMember = "naziv";
            artiklComboBox.ValueMember = "sifra";
            artiklComboBox.SelectedIndex = -1;

            poslovni_partnerComboBox.DataSource =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 select new
                 {
                     naziv = ((poduzece)poduzeceObj).naziv,
                     sifra = ((poduzece)poduzeceObj).oib
                 }).ToArray();
            poslovni_partnerComboBox.DisplayMember = "naziv";
            poslovni_partnerComboBox.ValueMember = "sifra";
            poslovni_partnerComboBox.SelectedIndex = -1;
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            artiklComboBox.SelectedIndex = -1;
            poslovni_partnerComboBox.SelectedIndex = -1;
            popustTextBox.Text = "";
            UpozorenjeArtikl.Hide();
            UpozorenjePopust.Hide();
            UpozorenjePoslovniPartner.Hide();
        }

        private void popuniLabeleUpozorenja(Label LabelaUpozorenja, string VrstaLabele)
        {
            string TekstUpozorenja = "Polje mora biti popunjeno";
            string TekstUpozorenjaComboBox = "Odaberite element";
            if (VrstaLabele == "ComboBox")
            {
                LabelaUpozorenja.Text = TekstUpozorenjaComboBox;
                LabelaUpozorenja.Show();
            }
            else
            {
                LabelaUpozorenja.Text = TekstUpozorenja;
                LabelaUpozorenja.Show();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (artiklComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjeArtikl, "ComboBox");
            }
            if (poslovni_partnerComboBox.SelectedIndex == -1)
            {
                popuniLabeleUpozorenja(UpozorenjePoslovniPartner, "ComboBox");
            }
            if (popustTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjePopust, "TextBox");
            }
            float VarijablaZaProvjeru = 0;
            if (artiklComboBox.SelectedIndex != -1 && poslovni_partnerComboBox.SelectedIndex != -1 && popustTextBox.Text != "" && float.TryParse(popustTextBox.Text,out VarijablaZaProvjeru))
            {
                rabat newInstance = new rabat
                {
                    artikl = int.Parse(artiklComboBox.SelectedValue.ToString()),
                    poslovni_partner = poslovni_partnerComboBox.SelectedValue.ToString(),
                    popust = int.Parse(popustTextBox.Text)
                };
                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(newInstance), 'C');
                sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                this.Close();
            }
            
        }

        private void artiklComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeArtikl.Hide();
        }

        private void poslovni_partnerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjePoslovniPartner.Hide();
        }

        private void popustTextBox_Leave(object sender, EventArgs e)
        {
            float VarijablaZaProvjeru = 0;
            if (popustTextBox.Text == "")
            {
                popuniLabeleUpozorenja(UpozorenjePopust, "TextBox");
            }
            else if(!float.TryParse(popustTextBox.Text, out VarijablaZaProvjeru))
            {
                UpozorenjePopust.Text= "Polje mora sadržavati broj";
                UpozorenjePopust.Show();
            }
            else
            {
                UpozorenjePopust.Hide();
            }
        }
    }
}

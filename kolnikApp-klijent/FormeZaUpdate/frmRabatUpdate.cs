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
    public partial class frmRabatUpdate :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        rabat oldInstance;
        public frmRabatUpdate(DataGridViewRow PodatkovniRedak) : base(false)
        {
            InitializeComponent();

            oldInstance = new rabat
            {
                artikl = nadjiArtikl(PodatkovniRedak.Cells["artikl"].Value.ToString()),
                poslovni_partner = PodatkovniRedak.Cells["poslovni_partner"].Value.ToString(),
                popust = decimal.Parse(PodatkovniRedak.Cells["popust"].Value.ToString())
            };
            artiklComboBox.DataSource =
                (from artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 select ((artikl)artiklObj).naziv).ToArray();
            artiklComboBox.SelectedItem = PodatkovniRedak.Cells["artikl"].Value;

            poslovni_partnerComboBox.DataSource =
                (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                 select ((poduzece)poduzeceObj).naziv).ToArray();
            poslovni_partnerComboBox.SelectedItem = PodatkovniRedak.Cells["poslovni_partner"].Value;
            popustTextBox.Text = PodatkovniRedak.Cells["popust"].Value.ToString();
        }

        private int nadjiArtikl(string key)
        {
            var artikl =
                (from artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                 where ((artikl)artiklObj).naziv == key
                 select ((artikl)artiklObj).id).ToArray();
            return artikl[0];
        }
        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (artiklComboBox.SelectedIndex != -1 && poslovni_partnerComboBox.SelectedIndex != -1 && popustTextBox.Text != "" && float.TryParse(popustTextBox.Text, out VarijablaZaProvjeru))
            {
                rabat newInstance = new rabat
                {
                    artikl = nadjiArtikl(artiklComboBox.SelectedValue.ToString()),
                    poslovni_partner = poslovni_partnerComboBox.SelectedValue.ToString(),
                    popust = decimal.Parse(popustTextBox.Text)
                };

                string dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.SerializeUpdatedObject(oldInstance, newInstance), 'U');
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
            else if (!float.TryParse(popustTextBox.Text, out VarijablaZaProvjeru))
            {
                UpozorenjePopust.Text = "Polje mora sadržavati broj";
                UpozorenjePopust.Show();
            }
            else
            {
                UpozorenjePopust.Hide();
            }
        }
    }
}

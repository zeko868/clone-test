using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp_klijent.FormeZaUpdate
{
    public partial class frmRacunUpdate : Form
    {
        public frmRacunUpdate()
        {
            InitializeComponent();
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
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (izdavateljComboBox.SelectedIndex == -1)
            {
                UpozorenjeIzdavatelj.Text = "Odaberite element";
                UpozorenjeIzdavatelj.Show();
            }
            else
            {
                //stavi podatke u klasu i pošalji u BP
                this.Close();
            }
        }

        private void izdavateljComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpozorenjeIzdavatelj.Hide();
        }
    }
}

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
    public partial class frmGradilisteUpdate : Form
    {
        public frmGradilisteUpdate()
        {
            InitializeComponent();
        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            naziv_mjestaTextBox.Text = "";
        }

        string TekstUpozorenja = "Polje mora biti popunjeno";
        private void naziv_mjestaTextBox_Leave(object sender, EventArgs e)
        {
            if (naziv_mjestaTextBox.Text == "")
            {
                UpozorenjeNazivMjesta.Text = TekstUpozorenja;
                UpozorenjeNazivMjesta.Show();
            }
            else
            {
                UpozorenjeNazivMjesta.Hide();
            }
        }

        private void GumbPotvrda_Click(object sender, EventArgs e)
        {
            if (naziv_mjestaTextBox.Text != "")
            {
                //napuniti podacima klasu i poslati na server
                this.Close();
            }
        }
    }
}

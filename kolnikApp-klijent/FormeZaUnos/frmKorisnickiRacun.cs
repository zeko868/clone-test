using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp_klijent.FormeZaUnos
{
    public partial class frmKorisnickiRacun : Form
    {
        public frmKorisnickiRacun()
        {
            InitializeComponent();
        }

        private void korisnicki_racunBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.korisnicki_racunBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmKorisnickiRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.korisnicki_racun' table. You can move, or remove it, as needed.
            this.korisnicki_racunTableAdapter.Fill(this.privremeniDS.korisnicki_racun);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            zaposlenikTextBox.Text = "";
            korisnicko_imeTextBox.Text = "";
            lozinkaTextBox.Text = "";
        }
    }
}

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
    public partial class frmZaposlenik : Form
    {
        public frmZaposlenik()
        {
            InitializeComponent();
        }

        private void zaposlenikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposlenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmZaposlenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.privremeniDS.zaposlenik);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            oibTextBox.Text = "";
            imeTextBox.Text = "";
            prezimeTextBox.Text = "";
        }
    }
}

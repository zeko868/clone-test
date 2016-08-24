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
    public partial class frmVozilo : Form
    {
        public frmVozilo()
        {
            InitializeComponent();
        }

        private void voziloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voziloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmVozilo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.privremeniDS.vozilo);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            registracijski_brojTextBox.Text = "";
            proizvodjacTextBox.Text = "";
            modelTextBox.Text = "";
        }
    }
}

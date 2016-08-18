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
    public partial class frmRadnoMjesto : Form
    {
        public frmRadnoMjesto()
        {
            InitializeComponent();
        }

        private void radno_mjestoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.radno_mjestoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmRadnoMjesto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.radno_mjesto' table. You can move, or remove it, as needed.
            this.radno_mjestoTableAdapter.Fill(this.privremeniDS.radno_mjesto);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            nazivTextBox.Text = "";
        }
    }
}

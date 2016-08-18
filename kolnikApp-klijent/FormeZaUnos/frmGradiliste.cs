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
    public partial class frmGradiliste : Form
    {
        public frmGradiliste()
        {
            InitializeComponent();
        }

        private void gradilisteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradilisteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmGradiliste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.gradiliste' table. You can move, or remove it, as needed.
            this.gradilisteTableAdapter.Fill(this.privremeniDS.gradiliste);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            naziv_mjestaTextBox.Text = "";
        }
    }
}

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
    public partial class frmRabat : Form
    {
        public frmRabat()
        {
            InitializeComponent();
        }

        private void rabatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rabatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmRabat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.rabat' table. You can move, or remove it, as needed.
            this.rabatTableAdapter.Fill(this.privremeniDS.rabat);

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
        }

    }
}

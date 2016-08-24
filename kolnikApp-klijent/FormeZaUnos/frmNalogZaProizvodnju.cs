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
    public partial class frmNalogZaProizvodnju : Form
    {
        public frmNalogZaProizvodnju()
        {
            InitializeComponent();
        }

        private void nalog_za_proizvodnjuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nalog_za_proizvodnjuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmNalogZaProizvodnju_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.nalog_za_proizvodnju' table. You can move, or remove it, as needed.
            this.nalog_za_proizvodnjuTableAdapter.Fill(this.privremeniDS.nalog_za_proizvodnju);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            temeljnicaTextBox.Text = "";
            gradilisteComboBox.SelectedIndex = -1;
            izdavateljComboBox.SelectedIndex = -1;
        }
    }
}

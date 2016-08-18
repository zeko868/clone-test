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
    public partial class frmTablicaPrivilegija : Form
    {
        public frmTablicaPrivilegija()
        {
            InitializeComponent();
        }
        string[] Operacije = new string[4] { "C", "R", "U", "D" };
        private void tablicna_privilegijaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tablicna_privilegijaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmTablicaPrivilegija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.tablicna_privilegija' table. You can move, or remove it, as needed.
            this.tablicna_privilegijaTableAdapter.Fill(this.privremeniDS.tablicna_privilegija);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            radno_mjestoComboBox.SelectedIndex = -1;
            naziv_tabliceComboBox.SelectedIndex = -1;
            operacijaComboBox.SelectedIndex = -1;
        }
    }
}

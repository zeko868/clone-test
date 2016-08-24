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
    public partial class frmNarudzbenica : Form
    {
        public frmNarudzbenica()
        {
            InitializeComponent();
        }

        private void narudzbenica_bitumenske_mjesavineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.narudzbenica_bitumenske_mjesavineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.narudzbenica_bitumenske_mjesavine' table. You can move, or remove it, as needed.
            this.narudzbenica_bitumenske_mjesavineTableAdapter.Fill(this.privremeniDS.narudzbenica_bitumenske_mjesavine);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            temeljnicaTextBox.Text = "";
            datum_potrazivanjaDateTimePicker.Value = DateTime.Now;
            naruciteljComboBox.SelectedIndex = -1;
        }
    }
}

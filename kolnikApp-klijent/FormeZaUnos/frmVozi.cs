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
    public partial class frmVozi : Form
    {
        public frmVozi()
        {
            InitializeComponent();
        }

        private void voziBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voziBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmVozi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.vozi' table. You can move, or remove it, as needed.
            this.voziTableAdapter.Fill(this.privremeniDS.vozi);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            voziloComboBox.SelectedIndex = -1;
            vozacComboBox.SelectedIndex = -1;
            datum_pocetkaDateTimePicker.Value = DateTime.Now;
            datum_zavrsetkaDateTimePicker.Value = DateTime.Now;
        }
    }
}

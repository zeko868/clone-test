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
    public partial class frmZaposen : Form
    {
        public frmZaposen()
        {
            InitializeComponent();
        }

        private void zaposlenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposlenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmZaposen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.zaposlen' table. You can move, or remove it, as needed.
            this.zaposlenTableAdapter.Fill(this.privremeniDS.zaposlen);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            zaposlenikComboBox.SelectedIndex = -1;
            poduzeceComboBox.SelectedIndex = -1;
            datum_pocetkaDateTimePicker.Value = DateTime.Now;
            datum_zavrsetkaDateTimePicker.Value = DateTime.Now;
        }
    }
}

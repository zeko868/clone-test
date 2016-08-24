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
    public partial class frmRacun : Form
    {
        public frmRacun()
        {
            InitializeComponent();
        }

        private void racunBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racunBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.privremeniDS.racun);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            datum_izdavanjaDateTimePicker.Value = DateTime.Now;
            izdavateljComboBox.SelectedIndex = -1;
        }
    }
}

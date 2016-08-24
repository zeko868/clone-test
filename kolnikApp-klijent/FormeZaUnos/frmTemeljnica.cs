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
    public partial class frmTemeljnica : Form
    {
        public frmTemeljnica()
        {
            InitializeComponent();
        }

        private void temeljnicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.temeljnicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmTemeljnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.temeljnica' table. You can move, or remove it, as needed.
            this.temeljnicaTableAdapter.Fill(this.privremeniDS.temeljnica);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            datum_izdavanjaDateTimePicker.Value = DateTime.Now;
            kolicinaTextBox.Text = "";
            voziloComboBox.SelectedIndex = -1;
            vozacComboBox.SelectedIndex = -1;
            artiklComboBox.SelectedIndex = -1;
        }
    }
}

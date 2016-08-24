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
    public partial class frmOtpremnica : Form
    {
        public frmOtpremnica()
        {
            InitializeComponent();
        }

        private void otpremnicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otpremnicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmOtpremnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.otpremnica' table. You can move, or remove it, as needed.
            this.otpremnicaTableAdapter.Fill(this.privremeniDS.otpremnica);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            temeljnicaTextBox.Text = "";
            datum_otpremeDateTimePicker.Value = DateTime.Now;
            otpremiteljComboBox.SelectedIndex = -1;
            temperaturaTextBox.Text = "";
        }
    }
}

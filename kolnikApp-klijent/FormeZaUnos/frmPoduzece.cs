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
    public partial class frmPoduzece : Form
    {
        public frmPoduzece()
        {
            InitializeComponent();
        }

        private void poduzeceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.poduzeceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.privremeniDS);

        }

        private void frmPoduzece_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'privremeniDS.poduzece' table. You can move, or remove it, as needed.
            this.poduzeceTableAdapter.Fill(this.privremeniDS.poduzece);

        }

        private void GumbIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GumbReset_Click(object sender, EventArgs e)
        {
            oibTextBox.Text = "";
            nazivTextBox.Text = "";
            adresaTextBox.Text = "";
            ibanTextBox.Text = "";
        }
    }
}

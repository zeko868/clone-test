using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolnikApp
{
    public partial class glavnaForma : Form
    {
        public glavnaForma()
        {
            InitializeComponent();
        }

        private void glavnaForma_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
        }


     private void formaObrazac_FormClosed(object sender, FormClosedEventArgs e)
        {
        this.Close();
        }

    private void timerLoading_Tick(object sender, EventArgs e)
        {
            
            if (loadingTraka.Value == loadingTraka.Maximum)
            {                             
                //Login koji se kasnije implementira funkcionalnost
                /*Login login = new Login();
                this.Hide();
                login.Show();
                logo.Hide();
                loadingTraka.Hide();*/
                timerLoading.Stop();
                obrazac formaObrazac = new obrazac();
                formaObrazac.FormClosed += new FormClosedEventHandler(formaObrazac_FormClosed);
                formaObrazac.Show();
                this.Hide();
            }
            else
            {
                loadingTraka.PerformStep();
            }           
        }
    }
}

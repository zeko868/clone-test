using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kolnikApp_komponente;
using System.Threading;

namespace kolnikApp_klijent
{
    public partial class Login : Form
    {
        CommunicationHandler sockObj;
        bool loginUsingUsername;
        public Login(CommunicationHandler sockObj)
        {
            InitializeComponent();
            this.sockObj = sockObj;
            loginUsingUsername = true;
        }

        private void loginType_Click(object sender, EventArgs e)
        {
            loginUsingUsername = !loginUsingUsername;
            if (loginUsingUsername)
            {
                loginTypeLabel.Text = "Prijavi se korištenjem OIB-a";
                korisnickoIme.Text = "Korisničko ime:";
            }
            else
            {
                loginTypeLabel.Text = "Prijavi se korištenjem korisničkog imena";
                korisnickoIme.Text = "OIB:";
            }
        }

        private void loginGumb_Click(object sender, EventArgs e)
        {
            sockObj.SendLoginCredentials(textBox1.Text, textBox2.Text, loginUsingUsername);

            Thread.Sleep(1000);
            Nullable<bool> loginState = DataHandler.LoginState;
            if (!loginState.HasValue)
            {
                MessageBox.Show("Pogreška sa kontaktiranjem poslužitelja. Provjerite jeste li spojeni na mrežu ili je li poslužitelj dostupan");
            }
            else
            {
                if (loginState.Value == true)
                {
                    this.Hide();
                    glavnaForma newForm = new glavnaForma(sockObj, DataHandler.UserOib);                   
                    newForm.Closed += (s, args) => this.Close();
                    newForm.Show();
                }
            }

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

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
    public partial class Login :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        bool loginUsingUsername;
        public Login(CommunicationHandler sockObj) : base(sockObj)
        {
            InitializeComponent();
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

            while (DataHandler.UserLoginState == (byte)DataHandler.LoginState.waiting)
            {
                ;
            }
            if (DataHandler.UserLoginState == (byte)DataHandler.LoginState.success)
            {
                this.Hide();
                glavnaForma newForm = new glavnaForma();
                newForm.Closed += (s, args) => this.Close();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Pogrešno uneseni podaci za prijavu ili je već netko s navedenim korisničkim imenom već prijavljen!");
                DataHandler.UserLoginState = (byte)DataHandler.LoginState.waiting;
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

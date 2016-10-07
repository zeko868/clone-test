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
    /// <summary>
    /// Klasa za prikaz početne forme namijenjene za prijavu u sustav
    /// </summary>
    public partial class Login :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        /// <summary>
        /// Je li odabrana prijava korištenjem korisničkog imena ili OIB-a
        /// </summary>
        bool loginUsingUsername;

        /// <summary>
        /// Konstruktor istoimene klase koji, naravno, instancira objekt navedene klase
        /// </summary>
        /// <param name="sockObj">Mrežna utičnica putem kojem se osluškuje mrežna sabirnica kao što se i lansiraju podaci prema njoj</param>
        public Login(CommunicationHandler sockObj) : base(sockObj)
        {
            InitializeComponent();
            loginUsingUsername = true;
        }

        /// <summary>
        /// Mijenja vrstu načina prijave u sustav (iz autentifikacije putem OIB-a u onu putem korisničkog imena i obratno)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Šalje unesene podatke za prijavu poslužitelju na provjeru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginGumb_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty)
            {
                MessageBox.Show("Niste unijeli sve podatke za prijavu u sustav");
                return;
            }
            sockObj.SendLoginCredentials(textBox1.Text, textBox2.Text, loginUsingUsername);

            long loginAttemptTime = DateTime.Now.Ticks;
            while (DataHandler.UserLoginState == (byte)DataHandler.LoginState.waiting && DateTime.Now.Ticks - 30000000 <= loginAttemptTime)
            {
                ;
            }
            if (DataHandler.UserLoginState == (byte)DataHandler.LoginState.waiting)
            {
                MessageBox.Show("Pogreška sa kontaktiranjem poslužiteljske aplikacije. Provjerite jeste li spojeni na mrežu ili je li poslužitelj dostupan");
            }
            else if (DataHandler.UserLoginState == DataHandler.LoginState.success)
            {
                this.Hide();
                glavnaForma newForm = new glavnaForma();
                newForm.Closed += (s, args) => this.Close();
                newForm.Show();
            }
            else
            {
                switch (DataHandler.UserLoginState)
                {
                    case DataHandler.LoginState.accountInUse:
                        MessageBox.Show("Korisnik s navedenim korisničkim imenom je već prijavljen!");
                        break;
                    case DataHandler.LoginState.dbInaccessible:
                        MessageBox.Show("Poslužitelj na kojem se nalazi baza podataka nije dostupan!");
                        break;
                    case DataHandler.LoginState.invalidCredentials:
                        MessageBox.Show("Pogrešno uneseni podaci za prijavu!");
                        break;
                }
                DataHandler.UserLoginState = (byte)DataHandler.LoginState.waiting;
            }

        }

        /// <summary>
        /// Zatvara prozor za prijavu (pa tako i cjelokupnu aplikaciju) pritiskom tipke "Esc"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

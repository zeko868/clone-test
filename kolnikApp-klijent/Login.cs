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

namespace kolnikApp_klijent
{
    public partial class Login : Form
    {
        CommunicationHandler sockObj;
        bool loginUsingUsername;
        List<object> prijavaLista;
        public Login(CommunicationHandler sockObj)
        {
            InitializeComponent();
            this.sockObj = sockObj;
            loginUsingUsername = true;
            prijavaLista = new List<object>();
            DataHandler.entityNamesWithReferencesToBelongingDataStores = new Dictionary<string, List<object>>();
            DataHandler.entityNamesWithReferencesToBelongingDataStores["korisnicki_racun"] = prijavaLista;
            DataHandler.LoginInfoReturned += DataHandler_LoginInfoReturned;
        }

        private void DataHandler_LoginInfoReturned(bool obj)
        {
            MessageBox.Show("Okinut je dogadjaj o primitku podataka za prijavu! ");
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
        }
    }
}

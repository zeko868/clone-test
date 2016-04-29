using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp
{
    public partial class Registracija : Form
    {
        public Registracija(string predefiniraniUsername, string predefiniraniPassword)
        {
            InitializeComponent();
            tboxUsername.Text = predefiniraniUsername;
            tboxPassword.Text = predefiniraniPassword;
        }

        private void tipkaOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipkaRegistracija_Click(object sender, EventArgs e)
        {
            if (tboxPassword.Text!=tboxRepeatPassword.Text)
            {
                MessageBox.Show("Lozinka se ne poklapa sa ponovljenom lozinkom! Znate li što ste uopće upisali?");
                return;
            }
            foreach (Control item in Controls)
            {
                if (item.GetType()==typeof(TextBox) && item.Text.Trim()=="")
                {
                    MessageBox.Show("Postoje polja za unos koja nisu popunjena!");
                    return;
                }
            }
            if (tboxOIB.Text.Length!=11)
            {
                MessageBox.Show("OIB se sastoji od točno 11 brojčanih znakova!");
                return;
            }
            if (!tboxOIB.Text.All(znak => znak>='0' && znak<='9'))
            {
                MessageBox.Show("OIB ne moze sadrzavati znakove koji nisu numericki!");
                return;
            }

            List<Entitet> podaci = FileData.Instanca.GetFileData("zaposlenik");
            if (podaci!=null)
            {
                bool postojiOIB = false;
                foreach (Zaposlenik korisnik in podaci)
                {
                    if (korisnik.Oib == tboxOIB.Text)
                    {
                        postojiOIB = true;
                        break;
                    }
                }
                if (postojiOIB)
                {
                    MessageBox.Show("Vi već imate svoje korisničko ime!");
                }
                if (podaci.Count(zaposlenik => ((Zaposlenik)zaposlenik).Oib == tboxOIB.Text)!=0)
                {
                    MessageBox.Show("Vi već imate svoje korisničko ime!");
                }
                else if (podaci.Count(zaposlenik => ((Zaposlenik)zaposlenik).KorisnickoIme == tboxUsername.Text)!=0)
                {
                    MessageBox.Show("Korisnicko ime je vec zauzeto! Molimo da unesete neko drugo");
                }
            }
            else
            {
                MessageBox.Show("Izvoriste podataka ne postoji! Trenutno se ne mozete registrirati.");
            }
        }

        private void tboxOIB_TextChanged(object sender, EventArgs e)
        {
            if (!tboxOIB.Text.All(znak => znak>='0' && znak<='9'))
            {
                int zapamtiPozicijuKursora = tboxOIB.SelectionStart;
                tboxOIB.Text = tboxOIB.Text.Remove(tboxOIB.SelectionStart-1,1);
                tboxOIB.SelectionStart = zapamtiPozicijuKursora -1;
            }
        }

        private void Registracija_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "https://github.com/foivz/r16001/wiki");
        }
    }
}

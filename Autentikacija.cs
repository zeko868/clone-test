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
    public partial class Autentikacija : Form
    {
        public Autentikacija()
        {
            InitializeComponent();
            FileData singleInstance = new FileData();
            singleInstance.PostaviDefaultnuLokacijuDoSpremistaPodataka();
            foreach (string putanja in singleInstance.PribaviSveLokacijeDoSpremistaPodataka())
            {
                cboxUdaljeneLokacije.Items.Add(putanja);
            }
        }
        private void tipkaPrijava_Click(object sender, EventArgs e)
        {
            bool valjaniKorisnickiPodaci = false;
            List<Entitet> lista = FileData.Instanca.GetFileData("zaposlenik");
            if (lista==null)
            {
                MessageBox.Show("Izvoriste podataka ne postoji! Trenutno se ne mozete prijaviti.");
            }
            else
            {
                Zaposlenik nadjenZaposlenik = null;
                foreach (Zaposlenik element in lista)
                {
                    if (element.KorisnickoIme == tboxUsername.Text && element.Lozinka == tboxPassword.Text)
                    {
                        valjaniKorisnickiPodaci = true;
                        nadjenZaposlenik = element;
                        break;
                    }
                }
                if (!valjaniKorisnickiPodaci)
                {
                    MessageBox.Show("Podaci za prijavu su pogresno uneseni!");
                }
                else
                {
                    (new Funkcionalnosti(nadjenZaposlenik.KorisnickoIme,nadjenZaposlenik.Ime,nadjenZaposlenik.Prezime,nadjenZaposlenik.Oib)).Show();
                    this.Close();
                }
            }
        }

        private void tipkaRegistracija_Click(object sender, EventArgs e)
        {
            (new Registracija(tboxUsername.Text, tboxPassword.Text)).ShowDialog(this);
        }

        private void tipkaIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autentikacija_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "https://github.com/foivz/r16001/wiki");
        }

        private void tipkaPrimijeni_Click(object sender, EventArgs e)
        {
            FileData.Instanca.PromijeniLokacijuDoSpremistaPodataka(cboxUdaljeneLokacije.Text);
            if (!cboxUdaljeneLokacije.Items.Contains(cboxUdaljeneLokacije.Text))
            {
                cboxUdaljeneLokacije.Items.Add(cboxUdaljeneLokacije.Text);
            }
        }
    }
}

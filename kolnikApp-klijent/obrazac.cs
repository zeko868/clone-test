using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kolnikApp_komponente;
using System.Runtime.InteropServices;

namespace kolnikApp_klijent
{
    public partial class obrazac : Form
    {
        private CommunicationHandler sockObj;
        private string userOib;
        public obrazac(CommunicationHandler sockObj, string userOib, string[] tableNames)
        {
            this.sockObj = sockObj;
            this.userOib = userOib;
            this.tablice = tableNames;
            InitializeComponent();
        }
        string[] tablice;// = new string[17] { "Artikl", "Rabat", "Zaposlen", "Poduzeće", "Vozi", "Vozilo", "Temeljnica", "Narudžbenica", "Zaposlenik", "Radi", "Korisnički račun", "Račun", "Otpremnica", "Tablična privilegija", "Gradilište", "Nalog za proizvodnju", "Radno mjesto" };
        
        String exeDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        private void HelpSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            String HelpFilepath = "file://" + Path.Combine(exeDirectory, "KolnikAppHelp.chm");
            Help.ShowHelp(this, HelpFilepath);     
        }

        //pomicanje forme
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void obrazac_Load(object sender, EventArgs e)
        {
            //dohvatiti broj tablica nad kojima korisnik ima pravo raditi
            //napraviti buttone za te tablice
            //--------------------------------------------
            //inicijalno rješenje za sve tablice
            for (int i = 0; i < 17; i++)
            {
                Button GumbMenija = new Button();
                GumbMenija.Location = new Point(0, 30 * i);
                GumbMenija.Height = 30;
                GumbMenija.Width = panel1.Width - 5;
                GumbMenija.ForeColor = Color.White;
                GumbMenija.BackColor = Color.Black;
                GumbMenija.FlatStyle = FlatStyle.Flat;

                switch (i)
                {
                    case 0:
                        GumbMenija.Text = "Artikl";
                        GumbMenija.Click += new EventHandler(ButtonClick1);
                        break;
                    case 1:
                        GumbMenija.Text = "Gradilište";
                        GumbMenija.Click += new EventHandler(ButtonClick2);
                        break;
                    case 2:
                        GumbMenija.Text = "Korisnički račun";
                        GumbMenija.Click += new EventHandler(ButtonClick3);
                        break;
                    case 3:
                        GumbMenija.Text = "Nalog za proizvodnju";
                        GumbMenija.Click += new EventHandler(ButtonClick4);
                        break;
                    case 4:
                        GumbMenija.Text = "Narudžbenica";
                        GumbMenija.Click += new EventHandler(ButtonClick5);
                        break;
                    case 5:
                        GumbMenija.Text = "Otpremnica";
                        GumbMenija.Click += new EventHandler(ButtonClick6);
                        break;
                    case 6:
                        GumbMenija.Text = "Poduzeće";
                        GumbMenija.Click += new EventHandler(ButtonClick7);
                        break;
                    case 7:
                        GumbMenija.Text = "Rabat";
                        GumbMenija.Click += new EventHandler(ButtonClick8);
                        break;
                    case 8:
                        GumbMenija.Text = "Račun";
                        GumbMenija.Click += new EventHandler(ButtonClick9);
                        break;
                    case 9:
                        GumbMenija.Text = "Radi";
                        GumbMenija.Click += new EventHandler(ButtonClick10);
                        break;
                    case 10:
                        GumbMenija.Text = "Radno mjesto";
                        GumbMenija.Click += new EventHandler(ButtonClick11);
                        break;
                    case 11:
                        GumbMenija.Text = "Tablica privilegija";
                        GumbMenija.Click += new EventHandler(ButtonClick12);
                        break;
                    case 12:
                        GumbMenija.Text = "Temeljnica";
                        GumbMenija.Click += new EventHandler(ButtonClick13);
                        break;
                    case 13:
                        GumbMenija.Text = "Vozi";
                        GumbMenija.Click += new EventHandler(ButtonClick14);
                        break;
                    case 14:
                        GumbMenija.Text = "Vozilo";
                        GumbMenija.Click += new EventHandler(ButtonClick15);
                        break;
                    case 15:
                        GumbMenija.Text = "Zaposlen";
                        GumbMenija.Click += new EventHandler(ButtonClick16);
                        break;
                    case 16:
                        GumbMenija.Text = "Zaposlenik";
                        GumbMenija.Click += new EventHandler(ButtonClick17);
                        break;
                }
                this.MeniPanel.Controls.Add(GumbMenija);
            }
        }

        private void oznaciGumb(object sender)
        {
            foreach (Control Gumb in this.MeniPanel.Controls)
            {
                Gumb.ForeColor = Color.White;
            }
            Button Gumbic = sender as Button;
            Gumbic.ForeColor = Color.Orange;
        }
    
        private void ButtonClick1(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick2(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick3(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick4(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick5(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick6(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick7(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick8(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick9(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick10(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick11(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick12(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick13(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick14(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick15(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick16(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }
        private void ButtonClick17(object sender, EventArgs e)
        {
            oznaciGumb(sender);
        }

        //prikazivanje i skrivanje naziva ikona
        private void HomeSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaPocetna.Show();
        }

        private void HomeSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaPocetna.Hide();
        }

        private void CreateSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaNovi.Show();
        }

        private void CreateSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaNovi.Hide();
        }

        private void UpdateSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaUpdate.Show();
        }

        private void UpdateSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaUpdate.Hide();
        }

        private void DeleteSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaIzbrisi.Show();
        }

        private void DeleteSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaIzbrisi.Hide();
        }

        private void HelpSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaPomoc.Show();
        }

        private void HelpSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaPomoc.Hide();
        }

        private void CreateSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            FormeZaUnos.frmPoduzece frmUnosArtikl = new FormeZaUnos.frmPoduzece();
            frmUnosArtikl.ShowDialog();
            /*FormeZaUnos.frmNalogZaProizvodnju frmUnosNalog = new FormeZaUnos.frmNalogZaProizvodnju();
            frmUnosNalog.ShowDialog();*/
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void RestoreDown_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void ImeKorisnika_Click(object sender, EventArgs e)
        {
            if (LogoutButton.Visible)
            {
                LogoutButton.Hide();
            }
            else
            {
                LogoutButton.Show();
            }            
        }

        private void obrazac_MouseClick(object sender, MouseEventArgs e)
        {
            LogoutButton.Hide();
        }

        private void MenuLista_MouseClick(object sender, MouseEventArgs e)
        {
            LogoutButton.Hide();
        }

        private void HomeSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
        }

        private void UpdateSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
        }

        private void DeleteSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
        }

        private void obrazac_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LijeviIzbornik_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LogoutButton.Visible)
            {
                LogoutButton.Hide();
            }
        }

        private void LijeviIzbornik_MouseClick(object sender, MouseEventArgs e)
        {
            if (LogoutButton.Visible)
            {
                LogoutButton.Hide();
            }
        }

        private void Header_MouseClick(object sender, MouseEventArgs e)
        {
            if (LogoutButton.Visible)
            {
                LogoutButton.Hide();
            }
        }
    }
}

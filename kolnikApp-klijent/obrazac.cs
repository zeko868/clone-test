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
        }       
        
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


        private void izgradiMeni()
        {
            foreach (var item in tablice)
            {
                MenuLista.Items.Add(item);
            }
        }

        private void obrazac_Load(object sender, EventArgs e)
        {
            izgradiMeni();
        }

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

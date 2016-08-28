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
        public obrazac(CommunicationHandler sockObj, string[] tableNames)
        {
            this.sockObj = sockObj;
            this.tablice = tableNames;
            DataHandler.entityNamesWithReferencesToBelongingDataStores.Clear();
            foreach (string nazivTablice in tablice)
            {
                DataHandler.entityNamesWithReferencesToBelongingDataStores[nazivTablice] = new BindingList<object>();
                DataHandler.entityNamesWithReferencesToBelongingDataStores[nazivTablice].ListChanged += ProcessChanges;
            }
            sockObj.SendRequestForSendingUsedData();
            InitializeComponent();
            ImeKorisnika.Text = DataHandler.LoggedUser.ime + " " + DataHandler.LoggedUser.prezime;            
        }     

        void ProcessChanges (object obj, ListChangedEventArgs e)
        {
            if (DataHandler.ChangesCommited)
            {
                Console.Beep(300,300);
                //refresh controls and perform queries on lists in which data is stored
            }
        }

        //popis svih tablica kojima korisnik ima pravo pristupati
        string[] tablice;
        //string u koji se sprema put do izvršnog direktorija aplikacije gdje se nalazi .exe datoteka
        String exeDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        //Event handler za klik na ikonicu "Help"
        private void HelpSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            //koristimo exeDirectory gdje je spremljena putanja i dodajemo naziv help file-a 
            String HelpFilepath = "file://" + Path.Combine(exeDirectory, "KolnikAppHelp.chm");
            Help.ShowHelp(this, HelpFilepath);     
        }

        //Maknuli smo boarder pa omogućujemo micanje aplikacije
        //detaljnije komentirati!!!!!!!!!!!!!
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //funkcija koja vraća uljepšani naziv za ime tablice koje je prosljeđeno
        private string UrediImeGumba(string NazivTablice)
        {
            string PravoIme = "";
            switch (NazivTablice)
            {
                case "artikl": PravoIme = "Artikl";
                    break;
                case "rabat": PravoIme = "Rabat";
                    break;
                case "zaposlen": PravoIme = "Zaposlen";
                    break;
                case "poduzece": PravoIme = "Poduzeće";
                    break;
                case "vozi": PravoIme = "Vozi";
                    break;
                case "vozilo": PravoIme = "Vozilo";
                    break;                        
                case "temeljnica": PravoIme = "Temeljnica";
                    break;
                case "narudzbenica_bitumenske_mjesavine": PravoIme = "Narudžbenica";
                    break;
                case "zaposlenik": PravoIme = "Zaposlenik";
                    break;
                case "radi": PravoIme = "Radi";
                    break;
                case "korisnicki_racun": PravoIme = "Korisnički račun";
                    break;
                case "racun": PravoIme = "Račun";
                    break;
                case "otpremnica": PravoIme = "Otpremnica";
                    break;
                case "tablicna_privilegija": PravoIme = "Tablična privilegija";
                    break;
                case "gradiliste": PravoIme = "Gradilište";
                    break;
                case "nalog_za_proizvodnju": PravoIme = "Nalog za proizvodnju";
                    break;
                case "radno_mjesto":PravoIme = "Radno mjesto";
                    break;
                default: PravoIme = "Krivi podaci";
                    break;
            }
            return PravoIme;
        }

        private void obrazac_Load(object sender, EventArgs e)
        {
            //dinamički se stvaraju gumbi na temelju broja tablica kojima korisnik ima pravo pristupa
            for (int i = 0; i < tablice.Length; i++)
            {
                Button GumbMenija = new Button();
                GumbMenija.Name = tablice[i];
                //šalje se ime tablice na "uljepšavanje"
                GumbMenija.Text = UrediImeGumba(tablice[i]);
                GumbMenija.Tag = tablice[i];
                GumbMenija.Location = new Point(0, 30 * i);
                GumbMenija.Height = 30;
                GumbMenija.Width = MeniPanel.Width - 7;
                GumbMenija.BackColor = Color.Black;
                GumbMenija.ForeColor = Color.White;
                GumbMenija.FlatStyle = FlatStyle.Flat;
                GumbMenija.Click += new EventHandler(ButtonClick1);

                this.MeniPanel.Controls.Add(GumbMenija);
            }
        }

        //sve gumbe resetiramo na početni dizajn, označvamo kliknuti gumb
        private void oznaciGumb(object sender)
        {
            foreach (Control Gumb in this.MeniPanel.Controls)
            {
                Gumb.ForeColor = Color.White;
            }
            Button Gumbic = sender as Button;
            Gumbic.ForeColor = Color.Orange;
        }

        //inicijalizacija stoga za omogućavanje povratka unatrag kroz aplikaciju
        Stack<string> StogZaVracanjeUnatrag = new Stack<string>();

        private void SakrijNebitneStupceUDataGridView(string NaslovTablice)
        {
            switch (NaslovTablice)
            {
                case "Korisnički račun":
                    for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if(this.PodaciIzTablica.Columns[i].HeaderText == "zaposlenik1")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                    break;
                case "Nalog za proizvodnju":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                         {
                        if (this.PodaciIzTablica.Columns[i].HeaderText == "zaposlenik" || this.PodaciIzTablica.Columns[i].HeaderText == "gradiliste1" || this.PodaciIzTablica.Columns[i].HeaderText == "temeljnica1")
                        {
                                 this.PodaciIzTablica.Columns[i].Visible = false;
                             }
                         }
                         break;
                     case "Narudžbenica":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if(this.PodaciIzTablica.Columns[i].HeaderText == "poduzece")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                         break;
                     case "Otpremnica":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if (this.PodaciIzTablica.Columns[i].HeaderText == "zaposlenik" || this.PodaciIzTablica.Columns[i].HeaderText == "racun1" || this.PodaciIzTablica.Columns[i].HeaderText == "temeljnica1")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                         break;
                     case "Rabat":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if(this.PodaciIzTablica.Columns[i].HeaderText == "artikl1" || this.PodaciIzTablica.Columns[i].HeaderText == "poduzece")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                         break;
                     case "Račun":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if(this.PodaciIzTablica.Columns[i].HeaderText == "zaposlenik")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                         break;
                     case "Radi":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if(this.PodaciIzTablica.Columns[i].HeaderText == "zaposlenik1" || this.PodaciIzTablica.Columns[i].HeaderText == "radno_mjesto1")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                         break;
                     case "Tablična privilegija":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if(this.PodaciIzTablica.Columns[i].HeaderText == "radno_mjesto1")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                         break;
                     case "Temeljnica":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if(this.PodaciIzTablica.Columns[i].HeaderText == "zaposlenik" || this.PodaciIzTablica.Columns[i].HeaderText == "vozilo1" || this.PodaciIzTablica.Columns[i].HeaderText == "artikl1" || this.PodaciIzTablica.Columns[i].HeaderText == "otpremnica" || this.PodaciIzTablica.Columns[i].HeaderText == "nalog_za_proizvodnju")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                         break;
                     case "Vozi":
                         for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if (this.PodaciIzTablica.Columns[i].HeaderText == "zaposlenik" || this.PodaciIzTablica.Columns[i].HeaderText == "vozilo1" || this.PodaciIzTablica.Columns[i].HeaderText == "vozi2" || this.PodaciIzTablica.Columns[i].HeaderText == "vozi1")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                         break;                    
                    case "Zaposlenik":
                    for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if (this.PodaciIzTablica.Columns[i].HeaderText == "korisnicki_racun")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                    break;
                case "Zaposlen":
                    for (int i = 0; i < PodaciIzTablica.ColumnCount; i++)
                    {
                        if (this.PodaciIzTablica.Columns[i].HeaderText == "zaposlenik1" || this.PodaciIzTablica.Columns[i].HeaderText == "poduzece1")
                        {
                            this.PodaciIzTablica.Columns[i].Visible = false;
                        }
                    }
                    break;
            }
        }
        //dodajemo naziv prethodne "stranice" na stog i promijenimo na novu "stranicu"
        private void ButtonClick1(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            Button Gumb = sender as Button;
            oznaciGumb(sender);
            if (NaslovTablice.Text != "Dobro došli!")
            {
                StogZaVracanjeUnatrag.Push(NaslovTablice.Tag.ToString());
            }
            PodaciIzTablica.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores[Gumb.Tag.ToString()];
            NaslovTablice.Text = Gumb.Text;
            NaslovTablice.Tag = Gumb.Tag;
            SakrijNebitneStupceUDataGridView(Gumb.Text);
            this.PodaciIzTablica.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //vraćamo se unatrag za jednu "stranicu"
        private void NatragSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            if(StogZaVracanjeUnatrag.Count > 0)
            {
                string ImeStranice = StogZaVracanjeUnatrag.Pop();
                Button GumbMenija = (Button)this.MeniPanel.Controls.Find(ImeStranice, false).FirstOrDefault();
                oznaciGumb(GumbMenija);
                PodaciIzTablica.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores[GumbMenija.Tag.ToString()];
                SakrijNebitneStupceUDataGridView(GumbMenija.Text);
                NaslovTablice.Text = GumbMenija.Text;
                NaslovTablice.Tag = GumbMenija.Tag;
            }          
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
        //kraj prikazivanja i skrivanja naziva ikona

        //funkcija koja iz naziva tablice stvara ime forme i stavlja ga u string
        private string pretvoriUImeForme(string vrsta)
        {
            string ImeForme = "frm";
            char Separator = '_';
            string[] dijelovi = NaslovTablice.Tag.ToString().Split(Separator);
            foreach (var item in dijelovi)
            {
                ImeForme += item.First().ToString().ToUpper() + item.Substring(1);
            }
            if (vrsta == "Update")
            {
                ImeForme += "Update";
            }
            return ImeForme;
        }
        //otvaranje nove forme za "Create" na temelju dobivenog imena
        private void CreateSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            string ImeForme=pretvoriUImeForme("Create");
            Type TipForme = Type.GetType("kolnikApp_klijent.FormeZaUnos." + ImeForme);
            Form nextForm2 = (Form)Activator.CreateInstance(TipForme);
            nextForm2.ShowDialog();

        }

        //zatvaranje aplikacije klikom na "X"
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //minimiziranje aplikacije klikom na "_"
        private void Minimize_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        //stavljanje aplikacije u "window" mode
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

        //vidljivost gumba logout
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

        //skrivanje logout gumba
        private void obrazac_MouseClick(object sender, MouseEventArgs e)
        {
            LogoutButton.Hide();
        }
        //skrivanje logout gumba
        private void MenuLista_MouseClick(object sender, MouseEventArgs e)
        {
            LogoutButton.Hide();
        }

        //otvaranje nove forme za "Update" na temelju dobivenog imena
        private void UpdateSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
            string ImeForme = pretvoriUImeForme("Update");
            Type Tipforme = Type.GetType("kolnikApp_klijent.FormeZaUpdate." + ImeForme);
            Form FormaZaUpdate = (Form)Activator.CreateInstance(Tipforme);
            FormaZaUpdate.ShowDialog();

        }

        //skrivanje logout gumba
        private void DeleteSlika_Click(object sender, EventArgs e)
        {
            LogoutButton.Hide();
        }

        //omogućavanje micanje forme po ekranu ako smo pozicionirani na formi
        //i držimo pritisnutu tipku miša 
        private void obrazac_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //omogućavanje micanje forme po ekranu ako smo pozicionirani na lijevom panelu
        //i držimo pritisnutu tipku miša 
        private void LijeviIzbornik_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //omogućavanje micanje forme po ekranu ako smo pozicionirani na logu
        //i držimo pritisnutu tipku miša 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //omogućavanje micanje forme po ekranu ako smo pozicionirani na panelu s ikonama
        //i držimo pritisnutu tipku miša 
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //skirvanje logout gumba
        private void LogoSlika_Click(object sender, EventArgs e)
        {
            if (LogoutButton.Visible)
            {
                LogoutButton.Hide();
            }
        }
        //skirvanje logout gumba
        private void LijeviIzbornik_MouseClick(object sender, MouseEventArgs e)
        {
            if (LogoutButton.Visible)
            {
                LogoutButton.Hide();
            }
        }
        //skirvanje logout gumba
        private void Header_MouseClick(object sender, MouseEventArgs e)
        {
            if (LogoutButton.Visible)
            {
                LogoutButton.Hide();
            }
        }

        //logout
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            sockObj.SendLogoutRequest();
            Application.Restart();
        }

        
    }
}

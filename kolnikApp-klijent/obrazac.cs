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
        private DataGridView additionalDgv = new DataGridView();

        public obrazac(CommunicationHandler sockObj)
        {
            this.sockObj = sockObj;
            this.tablice = DataHandler.entityNamesWithReferencesToBelongingDataStores.Keys.ToArray<string>();
            InitializeComponent();
            ImeKorisnika.Text = DataHandler.LoggedUser.ime + " " + DataHandler.LoggedUser.prezime;
            additionalDgv.AllowUserToAddRows = false;
            additionalDgv.AllowUserToDeleteRows = false;
            additionalDgv.AllowUserToResizeRows = false;
            additionalDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            additionalDgv.MultiSelect = false;
            additionalDgv.Name = "drugaTablica";
            additionalDgv.ReadOnly = true;
            additionalDgv.RowHeadersVisible = false;
            additionalDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            additionalDgv.ColumnWidthChanged += PodaciIzTablica_ColumnWidthChanged;
            PanelZaSadrzaj.Controls.Add(additionalDgv);
        }

        void ProcessChanges (object obj, ListChangedEventArgs e)
        {
            if (DataHandler.ChangesCommited)
            {
                Console.Beep(300,300);
                //refresh controls and perform queries on lists in which data is stored
                //mislim da gdje je direkt BindingList objekt dodijeljen kao DataSource da nije potrebno refreshati
                //nakon primitka novih podataka
                //ako se vrši LINQ upit nad njima, tada je potrebno ponovno izvršiti LINQ upit nad ažuriranim lokalnim
                //kolekcijama
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

        private void AutomaticallyResizeColumns(ref DataGridView dgvObj)
        {
            for (int i = 0; i < dgvObj.Columns.Count; i++)
            {
                if (i == dgvObj.Columns.Count -1)
                {
                    dgvObj.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvObj.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                int widthCol = dgvObj.Columns[i].Width;
                dgvObj.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvObj.Columns[i].Width = widthCol;
            }
        }

        private void ContentOfDGV(string tableName, ref DataGridView dgvObj)
        {
            switch (tableName)
            {
                case "rabat":
                    dgvObj.DataSource = (from rabatObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["rabat"]
                                join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                                on ((rabat)rabatObj).artikl equals ((artikl)artiklObj).id
                                join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                                on ((rabat)rabatObj).poslovni_partner equals ((poduzece)poduzeceObj).oib
                                select new {
                                    poslovni_partner = ((poduzece)poduzeceObj).naziv,
                                    artikl = ((artikl)artiklObj).naziv,
                                    popust = ((rabat)rabatObj).popust
                                }).ToArray();
                    break;
                case "radi":
                case "zaposlen":
                    dgvObj.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"];
                    additionalDgv.Visible = true;
                    break;
                case "vozi":
                    dgvObj.DataSource = (from vozac in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                                         join radiObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radi"]
                                         on ((zaposlenik)vozac).oib equals ((radi)radiObj).zaposlenik
                                         join rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                         on ((radi)radiObj).radno_mjesto equals ((radno_mjesto)rmObj).id
                                         where ((radno_mjesto)rmObj).naziv == "vozač"
                                         select ((zaposlenik)vozac)).ToArray();
                    break;
                default:
                    dgvObj.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores[tableName];
                    break;
            }
            switch (tableName)
            {
                case "radi":
                case "vozi":
                case "zaposlen":
                    dgvObj.Dock = DockStyle.None;
                    AdjustDGVsWhenTheyAreNotDocked();
                    additionalDgv.Visible = true;
                    break;
                default:
                    dgvObj.Dock = DockStyle.Fill;
                    additionalDgv.Visible = false;
                    break;
            }
        }

        //dodajemo naziv prethodne "stranice" na stog i promijenimo na novu "stranicu"
        private void ButtonClick1(object sender, EventArgs e)
        {
            PodaciIzTablica.ClearSelection();
            additionalDgv.DataSource = null;
            LogoutButton.Hide();
            Button Gumb = sender as Button;
            oznaciGumb(sender);
            if (NaslovTablice.Text != "Dobro došli!")
            {
                StogZaVracanjeUnatrag.Push(NaslovTablice.Tag.ToString());
            }
            NaslovTablice.Text = Gumb.Text;
            NaslovTablice.Tag = Gumb.Tag;
            ContentOfDGV(Gumb.Tag.ToString(), ref PodaciIzTablica);
            AutomaticallyResizeColumns(ref PodaciIzTablica);
        }

        //vraćamo se unatrag za jednu "stranicu"
        private void NatragSlika_Click(object sender, EventArgs e)
        {
            PodaciIzTablica.ClearSelection();
            additionalDgv.DataSource = null;
            LogoutButton.Hide();
            if(StogZaVracanjeUnatrag.Count > 0)
            {
                string ImeStranice = StogZaVracanjeUnatrag.Pop();
                Button GumbMenija = (Button)this.MeniPanel.Controls.Find(ImeStranice, false).FirstOrDefault();
                oznaciGumb(GumbMenija);
                ContentOfDGV(GumbMenija.Tag.ToString(), ref PodaciIzTablica);
                AutomaticallyResizeColumns(ref PodaciIzTablica);
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

        //ovo služi kada se ručno promijeni širina stupca DGV-u, pa da se ne pojave horizontalni klizači
        private void PodaciIzTablica_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            ((DataGridView)sender).Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void PodaciIzTablica_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            switch (NaslovTablice.Tag.ToString())
            {
                case "zaposlen":
                    additionalDgv.DataSource = (from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                                            join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                                            on ((zaposlen)zaposlenObj).poduzece equals ((poduzece)poduzeceObj).oib
                                            where ((zaposlen)zaposlenObj).zaposlenik == PodaciIzTablica[0, e.RowIndex].Value.ToString()
                                            select new
                                            {
                                                poduzece = ((poduzece)poduzeceObj).naziv,
                                                datum_pocetka = ((zaposlen)zaposlenObj).datum_pocetka,
                                                datum_zavrsetka = ((zaposlen)zaposlenObj).datum_zavrsetka
                                            }).ToArray();
                    break;
                case "radi":
                    additionalDgv.DataSource = (from radiObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radi"]
                                                join rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                                on ((radi)radiObj).radno_mjesto equals ((radno_mjesto)rmObj).id
                                                where ((radi)radiObj).zaposlenik == PodaciIzTablica[0, e.RowIndex].Value.ToString()
                                                select new
                                                {
                                                    radno_mjesto = ((radno_mjesto)rmObj).naziv,
                                                    datum_pocetka = ((radi)radiObj).datum_pocetka,
                                                    datum_zavrsetka = ((radi)radiObj).datum_zavrsetka
                                                }).ToArray();
                    break;
                case "vozi":
                    additionalDgv.DataSource = (from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                                                where ((vozi)voziObj).vozac == PodaciIzTablica[0, e.RowIndex].Value.ToString()
                                                select new
                                                {
                                                    vozilo = ((vozi)voziObj).vozilo,
                                                    datum_pocetka = ((vozi)voziObj).datum_pocetka,
                                                    datum_zavrsetka = ((vozi)voziObj).datum_zavrsetka
                                                }).ToArray();
                    break;
            }
        }

        private void obrazac_Resize(object sender, EventArgs e)
        {
            AdjustDGVsWhenTheyAreNotDocked();
        }

        private void AdjustDGVsWhenTheyAreNotDocked()
        {
            PodaciIzTablica.Height = additionalDgv.Height = (int)(PanelZaSadrzaj.Height * 0.48);
            additionalDgv.Top = PodaciIzTablica.Height + (int)(PanelZaSadrzaj.Height * 0.04);
            additionalDgv.Width = PodaciIzTablica.Width = PanelZaSadrzaj.Width;
            additionalDgv.Left = PodaciIzTablica.Left;
            AutomaticallyResizeColumns(ref PodaciIzTablica);
            AutomaticallyResizeColumns(ref additionalDgv);
        }
    }
}

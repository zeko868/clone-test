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
    public partial class obrazac :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        private DataGridView additionalDgv = new DataGridView();

        public obrazac() : base()
        {
            this.tablice = DataHandler.entityNamesForButtons.ToArray();
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
            //koristimo exeDirectory gdje je spremljena putanja i dodajemo naziv help file-a 
            String HelpFilepath = "file://" + Path.Combine(exeDirectory, "KolnikAppHelp.chm");
            Help.ShowHelp(this, HelpFilepath);     
        }

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
            int PomakZbogTabliceManje = 0;
            //dinamički se stvaraju gumbi na temelju broja tablica kojima korisnik ima pravo pristupa
            for (int i = 0; i < tablice.Length; i++)
            {              
               if (tablice[i] != "korisnicki_racun") { 
                    Button GumbMenija = new Button();
                    GumbMenija.Name = tablice[i];
                    //šalje se ime tablice na "uljepšavanje"
                    GumbMenija.Text = UrediImeGumba(tablice[i]);
                    GumbMenija.Tag = tablice[i];
                    GumbMenija.Location = new Point(0, 30 * (i-PomakZbogTabliceManje));
                    GumbMenija.Height = 30;
                    GumbMenija.Width = MeniPanel.Width - 7;
                    GumbMenija.BackColor = Color.Black;
                    GumbMenija.ForeColor = Color.White;
                    GumbMenija.FlatStyle = FlatStyle.Flat;
                    GumbMenija.Click += new EventHandler(ButtonClick1);

                    this.MeniPanel.Controls.Add(GumbMenija);
                }
                else
                {
                    PomakZbogTabliceManje += 1;
                }
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
                case "zaposlenik":
                    if (DataHandler.entityNamesWithReferencesToBelongingDataStores.ContainsKey("korisnicki_racun"))
                    {
                        dgvObj.DataSource =
                            (from korisnicki_racunObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["korisnicki_racun"]
                             join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                             on ((korisnicki_racun)korisnicki_racunObj).zaposlenik equals ((zaposlenik)zaposlenikObj).oib
                             select new
                             {
                                 OIB = ((zaposlenik)zaposlenikObj).oib,
                                 Ime = ((zaposlenik)zaposlenikObj).ime,
                                 Prezime = ((zaposlenik)zaposlenikObj).prezime,
                                 korisnicko_ime = ((korisnicki_racun)korisnicki_racunObj).korisnicko_ime
                             }).ToArray();

                    }
                    else
                    {
                        dgvObj.DataSource =
                            (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                             select new
                             {
                                 OIB = ((zaposlenik)zaposlenikObj).oib,
                                 Ime = ((zaposlenik)zaposlenikObj).ime,
                                 Prezime = ((zaposlenik)zaposlenikObj).prezime
                             }).ToArray();
                    }
                    break;
                case "racun":
                    dgvObj.DataSource =
                        (from racunObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["racun"]
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                         on ((racun)racunObj).izdavatelj equals ((zaposlenik)zaposlenikObj).oib
                         select new
                         {
                             id_racun = ((racun)racunObj).id,
                             datum_izdavanja = ((racun)racunObj).datum_izdavanja,
                             izdavatelj = ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime,
                             placeno = ((racun)racunObj).placeno ? "da" : "ne"
                         }).ToArray();
                    break;
                case "tablicna_privilegija":
                    dgvObj.DataSource =
                        (from tablicna_privilegijaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["tablicna_privilegija"]
                         join radno_mjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                         on ((tablicna_privilegija)tablicna_privilegijaObj).radno_mjesto equals ((radno_mjesto)radno_mjestoObj).id
                         select new
                         {
                             radno_mjesto = ((radno_mjesto)radno_mjestoObj).naziv,
                             naziv_tablice = ((tablicna_privilegija)tablicna_privilegijaObj).naziv_tablice,
                             operacija = String.Join(", ", GetListOfOperationNames(((tablicna_privilegija)tablicna_privilegijaObj).operacija))
                         }).ToArray();
                    break;
                case "temeljnica":
                    dgvObj.DataSource =
                        (from temeljnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["temeljnica"]
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                         on ((temeljnica)temeljnicaObj).vozac equals ((zaposlenik)zaposlenikObj).oib
                         join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                         on ((temeljnica)temeljnicaObj).artikl equals ((artikl)artiklObj).id
                         select new
                         {
                             id = ((temeljnica)temeljnicaObj).id,
                             datum_izdavanja = ((temeljnica)temeljnicaObj).datum_izdavanja,
                             kolicina = ((temeljnica)temeljnicaObj).kolicina,
                             vozilo = ((temeljnica)temeljnicaObj).vozilo,
                             vozac = ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime,
                             artikl = ((artikl)artiklObj).naziv
                         }).ToArray();
                    break;
                case "nalog_za_proizvodnju":
                    dgvObj.DataSource =
                        (from nalog_za_proizvodnjuObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["nalog_za_proizvodnju"]
                         join gradilisteObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["gradiliste"]
                         on ((nalog_za_proizvodnju)nalog_za_proizvodnjuObj).gradiliste equals ((gradiliste)gradilisteObj).id
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                         on ((nalog_za_proizvodnju)nalog_za_proizvodnjuObj).izdavatelj equals ((zaposlenik)zaposlenikObj).oib
                         select new
                         {
                             temeljnica = ((nalog_za_proizvodnju)nalog_za_proizvodnjuObj).temeljnica,
                             gradiliste = ((gradiliste)gradilisteObj).naziv_mjesta,
                             izdavatelj = ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime
                         }).ToArray();
                    break;
                case "narudzbenica_bitumenske_mjesavine":
                    dgvObj.DataSource =
                        (from narudzbenica_bitumenske_mjesavineObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                         join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenica_bitumenske_mjesavineObj).narucitelj equals ((poduzece)poduzeceObj).oib
                         select new
                         {
                             temeljnica = ((narudzbenica_bitumenske_mjesavine)narudzbenica_bitumenske_mjesavineObj).temeljnica,
                             datum_potrazivanja = ((narudzbenica_bitumenske_mjesavine)narudzbenica_bitumenske_mjesavineObj).datum_potrazivanja,
                             narucitelj = ((poduzece)poduzeceObj).naziv
                         }).ToArray();
                    break;
                case "otpremnica":
                    dgvObj.DataSource =
                        (from otpremnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["otpremnica"]
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                         on ((otpremnica)otpremnicaObj).otpremitelj equals ((zaposlenik)zaposlenikObj).oib
                         select new
                         {
                             temeljnica = ((otpremnica)otpremnicaObj).temeljnica,
                             izdavatelj = ((zaposlenik)zaposlenikObj).ime + " " + ((zaposlenik)zaposlenikObj).prezime,
                             datum_otpreme = ((otpremnica)otpremnicaObj).datum_otpreme,
                             racun = ((otpremnica)otpremnicaObj).racun,
                             temperatura = ((otpremnica)otpremnicaObj).temperatura
                         }).ToArray();
                    break;
                case "radi":
                    dgvObj.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"];             
                    break;
                case "zaposlen":
                    dgvObj.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"];                  
                    break;
                case "vozi":
                    dgvObj.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"];                  
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

        IEnumerable<string> GetListOfOperationNames(byte mixOfOperations)
        {
            if (Convert.ToBoolean(mixOfOperations & (byte)DataHandler.Operations.C))
            {
                yield return "create";
            }
            if (Convert.ToBoolean(mixOfOperations & (byte)DataHandler.Operations.R))
            {
                yield return "read";
            }
            if (Convert.ToBoolean(mixOfOperations & (byte)DataHandler.Operations.U))
            {
                yield return "update";
            }
            if (Convert.ToBoolean(mixOfOperations & (byte)DataHandler.Operations.D))
            {
                yield return "delete";
            }
        }

        //dodajemo naziv prethodne "stranice" na stog i promijenimo na novu "stranicu"
        private void ButtonClick1(object sender, EventArgs e)
        {
            PodaciIzTablica.ClearSelection();
            additionalDgv.DataSource = null;
            Button Gumb = sender as Button;
            oznaciGumb(sender);
            if (NaslovTablice.Text != "Dobro došli!" && Gumb.Text != NaslovTablice.Text)
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
            if (NaslovTablice.Text != "Dobro došli!")
            {
                string ImeForme = pretvoriUImeForme("Create");
                Type TipForme = Type.GetType("kolnikApp_klijent.FormeZaUnos." + ImeForme);
                Form nextForm2 = (Form)Activator.CreateInstance(TipForme);
                nextForm2.ShowDialog();
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
                LogoutButton.Focus();
            }            
        }

        //otvaranje nove forme za "Update" na temelju dobivenog imena
        private void UpdateSlika_Click(object sender, EventArgs e)
        {
            DataGridViewRow SelektiraniRedak=null;
            if (PodaciIzTablica.SelectedRows.Count != 0) {
                foreach (DataGridViewRow Red in PodaciIzTablica.SelectedRows)
                {
                   SelektiraniRedak = Red;
                }                
                string ImeForme = pretvoriUImeForme("Update");
                Type Tipforme = Type.GetType("kolnikApp_klijent.FormeZaUpdate." + ImeForme);
                Form FormaZaUpdate=null;
                if(additionalDgv.SelectedRows.Count != 0)
                {
                    DataGridViewRow addSelektiraniRedak = null;
                    foreach (DataGridViewRow addRed in additionalDgv.SelectedRows)
                    {
                        addSelektiraniRedak = addRed;
                    }
                    FormaZaUpdate = (Form)Activator.CreateInstance(Tipforme, SelektiraniRedak, addSelektiraniRedak);
                }
                else
                {
                    FormaZaUpdate = (Form)Activator.CreateInstance(Tipforme, SelektiraniRedak);
                }
                
                FormaZaUpdate.ShowDialog();
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
                    additionalDgv.DataSource =(from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                                               from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                                               from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                                               where ((zaposlenik)zaposlenikObj).oib == ((zaposlen)zaposlenObj).zaposlenik && 
                                                     ((poduzece)poduzeceObj).oib == ((zaposlen)zaposlenObj).poduzece &&
                                                     ((zaposlen)zaposlenObj).poduzece == PodaciIzTablica[0, e.RowIndex].Value.ToString()
                                               select new
                                               {
                                                   OIB= ((zaposlenik)zaposlenikObj).oib,
                                                   Ime= ((zaposlenik)zaposlenikObj).ime,
                                                   Prezime= ((zaposlenik)zaposlenikObj).prezime,
                                                   datum_pocetka = ((zaposlen)zaposlenObj).datum_pocetka,
                                                   datum_zavrsetka = ((zaposlen)zaposlenObj).datum_zavrsetka
                                               }).ToArray();
                    break;
                case "radi":
                    additionalDgv.DataSource = (from radiObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radi"]
                                                from rmObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                                from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                                                where ((radi)radiObj).radno_mjesto == ((radno_mjesto)rmObj).id &&
                                                      ((radi)radiObj).zaposlenik == ((zaposlenik)zaposlenikObj).oib &&
                                                      ((radi)radiObj).radno_mjesto.ToString() == PodaciIzTablica[0, e.RowIndex].Value.ToString()
                                                select new
                                                {
                                                    OIB = ((zaposlenik)zaposlenikObj).oib,
                                                    Ime = ((zaposlenik)zaposlenikObj).ime,
                                                    Prezime = ((zaposlenik)zaposlenikObj).prezime,                                                    
                                                    datum_pocetka = ((radi)radiObj).datum_pocetka,
                                                    datum_zavrsetka = ((radi)radiObj).datum_zavrsetka                                                    
                                                }).ToArray();
                    break;
                case "vozi":
                    additionalDgv.DataSource = (from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                                                from voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                                                from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlenik"]
                                                where ((vozi)voziObj).vozac == ((zaposlenik)zaposlenikObj).oib &&
                                                      ((vozi)voziObj).vozilo == ((vozilo)voziloObj).registracijski_broj &&
                                                      ((vozi)voziObj).vozilo == PodaciIzTablica[0, e.RowIndex].Value.ToString()
                                                select new
                                                {
                                                    OIB = ((zaposlenik)zaposlenikObj).oib,
                                                    Ime = ((zaposlenik)zaposlenikObj).ime,
                                                    Prezime = ((zaposlenik)zaposlenikObj).prezime,                                                    
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

        private void LogoutButton_Leave(object sender, EventArgs e)
        {
            LogoutButton.Hide();
        }

        private void obrazac_FormClosing(object sender, FormClosingEventArgs e)
        {
            sockObj.SendLogoutRequest();
        }

        private void ImeKorisnika_Resize(object sender, EventArgs e)
        {
            int distanceDifference = ImeKorisnika.Right - Minimize.Left;
            if (distanceDifference > 0)
            {
                ImeKorisnika.Left = ImeKorisnika.Left - distanceDifference;
            }
        }
    }
}

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
using System.Reflection;
using System.Text.RegularExpressions;

namespace kolnikApp_klijent
{
    /// <summary>
    /// Klasa za prikaz glavne forme namijenjene za prikaz i rad s podacima
    /// </summary>
    public partial class obrazac :
#if DEBUG
            PosrednaFormaZaDebugVerziju
#else
            ApstraktnaForma
#endif

    {
        /// <summary>
        /// Kontrola za prikaz detalja (podstavaka) vezanih uz odabranu stavku iz glavne kontrole iste namjene
        /// </summary>
        private DataGridView additionalDgv = new DataGridView();

        /// <summary>
        /// Popis svih tablica kojima korisnik ima pravo pristupati
        /// </summary>
        string[] tablice;

        /// <summary>
        /// Znakovni niz u koji se sprema put do izvršnog direktorija aplikacije gdje se nalazi izvršna datoteka
        /// </summary>
        String exeDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        /// <summary>
        /// Konstruktor glavne forme namijenjene za prikaz i rad s podacima
        /// </summary>
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
            //additionalDgv.ColumnWidthChanged += PodaciIzTablica_ColumnWidthChanged;
            PanelZaSadrzaj.Controls.Add(additionalDgv);
        }

        /// <summary>
        /// Obrađuje informacije o dodanim, promijenjenim i obrisanim zapisima te te promjene pohranjuje u kolekcijama u memoriji i iskazuje u tablicama
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        void ProcessChanges(object obj, ListChangedEventArgs e)
        {
            if (DataHandler.ChangesCommited)
            {
                Console.Beep(300, 300);
                int indexOfSelectedRowBeforeRefreshing = -1;
                List<string> valuesOfSelectedRowBeforeRefreshing = null;
                int indexOfSelectedRowBeforeRefreshing2 = -1;
                List<string> valuesOfSelectedRowBeforeRefreshing2 = null;

                if (mainDgvObj.DataSource != null)
                {
                    if (mainDgvObj.SelectedRows.Count > 0)
                    {
                        indexOfSelectedRowBeforeRefreshing = mainDgvObj.SelectedRows[0].Index;
                        valuesOfSelectedRowBeforeRefreshing = new List<string>();
                        for (byte i = 0; i < mainDgvObj.ColumnCount; i++)
                        {
                            valuesOfSelectedRowBeforeRefreshing.Add(mainDgvObj[i, indexOfSelectedRowBeforeRefreshing].Value.ToString());
                        }
                        if (additionalDgv.DataSource != null)
                        {
                            if (additionalDgv.SelectedRows.Count > 0)
                            {
                                indexOfSelectedRowBeforeRefreshing2 = additionalDgv.SelectedRows[0].Index;
                                valuesOfSelectedRowBeforeRefreshing2 = new List<string>();
                                for (byte i = 0; i < additionalDgv.ColumnCount; i++)
                                {
                                    if(additionalDgv[i, indexOfSelectedRowBeforeRefreshing2].Value == null)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        valuesOfSelectedRowBeforeRefreshing2.Add(additionalDgv[i, indexOfSelectedRowBeforeRefreshing2].Value.ToString());
                                    }                                    
                                }
                            }
                        }
                    }
                }
                if (NaslovTablice.Tag != null)
                {
                    mainDgvObj.ClearSelection();
                    additionalDgv.ClearSelection();
                    mainDgvObj.Invoke((MethodInvoker)delegate
                    {
                        FillDgvWithContent(NaslovTablice.Tag.ToString());
                        AutomaticallyResizeColumns(ref mainDgvObj);
                    });
                    if (indexOfSelectedRowBeforeRefreshing != -1)
                    {
                        bool previouslySelectedRecordFound = false;
                        int i;
                        for (i = 0; i < mainDgvObj.RowCount && !previouslySelectedRecordFound; i++)
                        {
                            previouslySelectedRecordFound = true;
                            for (byte j = 0; j < mainDgvObj.ColumnCount; j++)
                            {
                                if (mainDgvObj[j, i].ToString() != valuesOfSelectedRowBeforeRefreshing[j])
                                {
                                    previouslySelectedRecordFound = false;
                                    break;
                                }
                            }
                        }
                        if (previouslySelectedRecordFound)
                        {
                            mainDgvObj.Rows[i].Selected = true;
                        }
                        else
                        {
                            if (indexOfSelectedRowBeforeRefreshing < mainDgvObj.RowCount)
                            {
                                mainDgvObj.Rows[indexOfSelectedRowBeforeRefreshing].Selected = true;
                                additionalDgv.Invoke((MethodInvoker)delegate
                                {
                                    FillDataInAdditionalDgv(indexOfSelectedRowBeforeRefreshing);
                                });
                                
                            }
                            else
                            {
                                indexOfSelectedRowBeforeRefreshing2 = -1;
                            }
                        }
                        if (indexOfSelectedRowBeforeRefreshing2 != -1)
                        {
                            previouslySelectedRecordFound = false;
                            for (i = 0; i < additionalDgv.RowCount && !previouslySelectedRecordFound; i++)
                            {
                                previouslySelectedRecordFound = true;
                                for (byte j = 0; j < additionalDgv.ColumnCount; j++)
                                {
                                    if (additionalDgv[j, i].ToString() != valuesOfSelectedRowBeforeRefreshing2[j])
                                    {
                                        previouslySelectedRecordFound = false;
                                        break;
                                    }
                                }
                            }
                            if (previouslySelectedRecordFound)
                            {
                                additionalDgv.Rows[i].Selected = true;
                            }
                            else
                            {
                                if (indexOfSelectedRowBeforeRefreshing2 < additionalDgv.RowCount)
                                {
                                    additionalDgv.Rows[indexOfSelectedRowBeforeRefreshing2].Selected = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Funkcija koja se izvodi nakon što korisnik klikne na ikonicu "Help"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpSlika_Click(object sender, EventArgs e)
        {
            //koristimo exeDirectory gdje je spremljena putanja i dodajemo naziv help file-a 
            String HelpFilepath = "file://" + Path.Combine(exeDirectory, "KolnikAppHelp.chm");
            Help.ShowHelp(this, HelpFilepath);     
        }

        /// <summary>
        /// Vraća tekst za prikaz na tipci za prikaz instanci entiteta proslijeđenog naziva/šifre
        /// </summary>
        /// <param name="NazivTablice">Naziv tablice, odnosno entiteta</param>
        /// <returns>"Uljepšani" naziv tablice koji će biti prikazan korisniku</returns>
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
                case "proizvodni_nalog": PravoIme = "Proizvodni nalog";
                    break;
                case "narudzbenica_bitumenske_mjesavine": PravoIme = "Narudžbenica";
                    break;
                case "osoba": PravoIme = "Osoba";
                    break;
                case "korisnicki_racun": PravoIme = "Korisnički račun";
                    break;
                case "racun": PravoIme = "Račun";
                    break;
                case "otpremnica": PravoIme = "Otpremnica";
                    break;
                case "tablicna_privilegija": PravoIme = "Tablična privilegija";
                    break;
                case "radno_mjesto":PravoIme = "Radno mjesto";
                    break;
                default: PravoIme = "Krivi podaci";
                    break;
            }
            return PravoIme;
        }

        /// <summary>
        /// Definira niz postavke nakon što se sama forma očita do kraja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    GumbMenija.Click += new EventHandler(ClickOnButtonFromButtonList);

                    this.MeniPanel.Controls.Add(GumbMenija);
                }
                else
                {
                    PomakZbogTabliceManje += 1;
                }
                DataHandler.entityNamesWithReferencesToBelongingDataStores[tablice[i]].ListChanged += ProcessChanges;
            }
        }

        /// <summary>
        /// Resetira sve gumbe na početni dizajn, a označava gumb sa tekstom jednakim onom proslijeđenom
        /// </summary>
        /// <param name="kontrola">Kontrola (tipka) kojoj se želi promijetiti dizajn (tj. boja)</param>
        private void OznaciGumb(object kontrola)
        {
            foreach (Control Gumb in this.MeniPanel.Controls)
            {
                Gumb.ForeColor = Color.White;
            }
            Button Gumbic = kontrola as Button;
            Gumbic.ForeColor = Color.Orange;
        }

        /// <summary>
        /// Stog za pohranu prethodno promatranih vrsta entiteta te povratak unatrag kroz aplikaciju
        /// </summary>
        Stack<string> StogZaVracanjeUnatrag = new Stack<string>();

        /// <summary>
        /// Prilagođava širinu stupaca unutar tablice za prikaz podataka samim podacima pri čemu zadnji stupac dobiva na korištenje preostali prostor
        /// </summary>
        /// <param name="dgvObj">Kontrola za prikaz podataka za koju je potrebno prilagoditi širine stupaca</param>
        private void AutomaticallyResizeColumns(ref DataGridView dgvObj)
        {
            if (dgvObj.Columns.Count > 0)
            {
                for (int i = 0; i < dgvObj.Columns.Count; i++)
                {
                    dgvObj.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    int widthCol = dgvObj.Columns[i].Width;
                    dgvObj.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvObj.Columns[i].Width = widthCol;
                }
                int widthOfVerticalScrollBar = SystemInformation.VerticalScrollBarWidth;
                const byte widthToRemoveToPossiblyAvoidHorizontalScrollbars = 3;
                int availableWidthToStretchLastColumn = dgvObj.Width - dgvObj.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) - widthToRemoveToPossiblyAvoidHorizontalScrollbars;
                if (dgvObj.Controls.OfType<VScrollBar>().First().Visible)
                {
                    availableWidthToStretchLastColumn -= widthOfVerticalScrollBar;
                    if (!dgvObj.Controls.OfType<HScrollBar>().First().Visible)
                    {
                        
                    }
                }
                if (availableWidthToStretchLastColumn > 0)
                {
                    dgvObj.Columns[dgvObj.Columns.Count - 1].Width += availableWidthToStretchLastColumn;
                }
            }
        }

        /// <summary>
        /// Popunjava tablicu sa instancama vrste entiteta čiji naziv je identičan proslijeđenom znakovnom nizu
        /// </summary>
        /// <param name="tableName">Naziv vrste entiteta čije instance se žele prikazati u tablici</param>
        private void FillDgvWithContent(string tableName)
        {
            switch (tableName)
            {
                case "rabat":
                    mainDgvObj.DataSource = (from rabatObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["rabat"]
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
                case "osoba":
                    if (DataHandler.entityNamesWithReferencesToBelongingDataStores.ContainsKey("korisnicki_racun"))
                    {
                        mainDgvObj.DataSource =
                            (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                             join korisnicki_racunObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["korisnicki_racun"]
                             on ((osoba)zaposlenikObj).oib equals ((korisnicki_racun)korisnicki_racunObj).zaposlenik
                             into korisnicki_racuni
                             from sub_korisnicki_racun in korisnicki_racuni.DefaultIfEmpty()
                             select new
                             {
                                 OIB = ((osoba)zaposlenikObj).oib,
                                 Ime = ((osoba)zaposlenikObj).ime,
                                 Prezime = ((osoba)zaposlenikObj).prezime,
                                 Korisnicko_ime = sub_korisnicki_racun == null ? "" : ((korisnicki_racun)sub_korisnicki_racun).korisnicko_ime
                             }).ToArray();

                    }
                    else
                    {
                        mainDgvObj.DataSource =
                            (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                             select new
                             {
                                 OIB = ((osoba)zaposlenikObj).oib,
                                 Ime = ((osoba)zaposlenikObj).ime,
                                 Prezime = ((osoba)zaposlenikObj).prezime
                             }).ToArray();
                    }
                    break;
                case "tablicna_privilegija":
                    mainDgvObj.DataSource =
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
                case "narudzbenica_bitumenske_mjesavine":
                    mainDgvObj.DataSource =
                        (from narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                         join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                         join voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).vozi equals ((vozi)voziObj).id
                         join vozacObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         on ((vozi)voziObj).vozac equals ((osoba)vozacObj).oib
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).izdavatelj equals ((osoba)zaposlenikObj).oib
                         join zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                         on ((osoba)zaposlenikObj).oib equals ((zaposlen)zaposlenObj).zaposlenik
                         join poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                         on ((zaposlen)zaposlenObj).poduzece equals ((poduzece)poduzeceObj).oib
                         where ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).datum_izdavanja >= ((zaposlen)zaposlenObj).datum_pocetka && (((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).datum_izdavanja <= ((zaposlen)zaposlenObj).datum_zavrsetka || ((zaposlen)zaposlenObj).datum_zavrsetka == null)
                         select new
                         {
                             id_narudzbenica = ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id,
                             datum_izdavanja = ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).datum_izdavanja,
                             datum_potrazivanja = ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).datum_potrazivanja,
                             artikl = ((artikl)artiklObj).naziv,
                             kolicina = ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina,
                             vozi = ((osoba)vozacObj).ime + " " + ((osoba)vozacObj).prezime + " (" + ((vozi)voziObj).vozilo + ")",
                             izdavatelj = ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime + " (" + ((poduzece)poduzeceObj).naziv + ")"
                         }
                         ).ToArray();
                    break;
                case "proizvodni_nalog":
                    mainDgvObj.DataSource =
                        (from nalogObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["proizvodni_nalog"]
                         join narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                         on ((proizvodni_nalog)nalogObj).narudzbenica equals ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         on ((proizvodni_nalog)nalogObj).izdavatelj equals ((osoba)zaposlenikObj).oib
                         join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                         select new
                         {
                             narudzbenica = ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id.ToString() + " - " + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).datum_potrazivanja + " (" + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")",
                             izdavatelj = ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime,
                             datum_izdavanja = ((proizvodni_nalog)nalogObj).datum_izdavanja,
                             temperatura = ((proizvodni_nalog)nalogObj).temperatura
                         }
                         ).ToArray();
                    break;
                case "otpremnica":
                    mainDgvObj.DataSource =
                        (from otpremnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["otpremnica"]
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         on ((otpremnica)otpremnicaObj).otpremitelj equals ((osoba)zaposlenikObj).oib
                         join narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                         on ((otpremnica)otpremnicaObj).nalog equals ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id
                         join voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).vozi equals ((vozi)voziObj).id
                         join vozacObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         on ((vozi)voziObj).vozac equals ((osoba)vozacObj).oib
                         join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                         select new
                         {
                             narudzbenica = ((otpremnica)otpremnicaObj).nalog.ToString() + " - " + ((osoba)vozacObj).ime + " " + ((osoba)vozacObj).prezime +" (" + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")",
                             izdavatelj = ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime,
                             datum_otpreme = ((otpremnica)otpremnicaObj).datum_otpreme
                         }).ToArray();
                    break;
                case "zaposlen":
                    mainDgvObj.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"];                  
                    break;
                case "vozi":
                    mainDgvObj.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"];                  
                    break;
                case "racun":
                    mainDgvObj.DataSource =
                        (from racunObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["racun"]
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         on ((racun)racunObj).izdavatelj equals ((osoba)zaposlenikObj).oib
                         select new
                         {
                             id_racun = ((racun)racunObj).id,
                             datum_izdavanja = ((racun)racunObj).datum_izdavanja,
                             izdavatelj = ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime,
                             placeno = ((racun)racunObj).placeno ? "da" : "ne"
                         }).ToArray();
                    break;
                default:
                    mainDgvObj.DataSource = DataHandler.entityNamesWithReferencesToBelongingDataStores[tableName].ToList();
                    break;
            }
            switch (tableName)
            {
                case "vozi":
                case "zaposlen":
                case "racun":
                    mainDgvObj.Dock = DockStyle.None;
                    AdjustDGVsWhenTheyAreNotDocked();
                    additionalDgv.Visible = true;
                    break;
                default:
                    mainDgvObj.Dock = DockStyle.Fill;
                    additionalDgv.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Vraća pune nazive kratica C, R, U i D operacija za proslijeđeni niz kratica
        /// </summary>
        /// <param name="mixOfOperations">Niz kratica operacija</param>
        /// <returns>Niz punih naziva operacija pripadajućih proslijeđenom nizu kratica</returns>
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

        /// <summary>
        /// Dodaje naziv prethodne stranice (promatrane vrste entiteta) na stog i mijenja podnaslov forme (tj. naslov tablice) na naziv ekvivalentan tekstu sadržanom u kliknutoj tipci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickOnButtonFromButtonList(object sender, EventArgs e)
        {
            mainDgvObj.ClearSelection();
            additionalDgv.DataSource = null;
            Button Gumb = sender as Button;
            OznaciGumb(sender);
            if (NaslovTablice.Text != "Dobro došli!" && Gumb.Text != NaslovTablice.Text)
            {
                StogZaVracanjeUnatrag.Push(NaslovTablice.Tag.ToString());
            }
            NaslovTablice.Text = Gumb.Text;
            NaslovTablice.Tag = Gumb.Tag;
            FillDgvWithContent(Gumb.Tag.ToString());
            AutomaticallyResizeColumns(ref mainDgvObj);
        }

        /// <summary>
        /// Vraća na pregled tablicu entiteta prethodno pregledavane vrste entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NatragSlika_Click(object sender, EventArgs e)
        {
            mainDgvObj.ClearSelection();
            additionalDgv.DataSource = null;
            if(StogZaVracanjeUnatrag.Count > 0)
            {
                string ImeStranice = StogZaVracanjeUnatrag.Pop();
                Button GumbMenija = (Button)this.MeniPanel.Controls.Find(ImeStranice, false).FirstOrDefault();
                OznaciGumb(GumbMenija);
                NaslovTablice.Text = GumbMenija.Text;
                NaslovTablice.Tag = GumbMenija.Tag;
                FillDgvWithContent(GumbMenija.Tag.ToString());
                AutomaticallyResizeColumns(ref mainDgvObj);
                
            }          
        }

        /// <summary>
        /// Prikazuje tekst tipke s ikonicom za vraćanje na prethodnu stranicu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaPocetna.Show();
        }

        /// <summary>
        /// Sakriva tekst tipke s ikonicom za vraćanje na prethodnu stranicu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaPocetna.Hide();
        }

        /// <summary>
        /// Prikazuje tekst tipke s ikonicom za kreiranje nove instance entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaNovi.Show();
        }

        /// <summary>
        /// Sakriva tekst tipke s ikonicom za kreiranje nove instance entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaNovi.Hide();
        }

        /// <summary>
        /// Prikazuje tekst tipke s ikonicom za modificiranje označene instance entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaUpdate.Show();
        }

        /// <summary>
        /// Sakriva tekst tipke s ikonicom za modificiranje označene instance entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaUpdate.Hide();
        }

        /// <summary>
        /// Prikazuje tekst tipke s ikonicom za brisanje označene instance entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaIzbrisi.Show();
        }

        /// <summary>
        /// Sakriva tekst tipke s ikonicom za brisanje označene instance entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaIzbrisi.Hide();
        }

        /// <summary>
        /// Prikazuje tekst tipke s ikonicom za otvaranje prozora za pomoć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaPomoc.Show();
        }

        /// <summary>
        /// Sakriva tekst tipke s ikonicom za otvaranje prozora za pomoć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaPomoc.Hide();
        }

        /// <summary>
        /// Vraća iz naziva trenutne vrste entiteta (odnosno naziva tablice) ime forme za rad s instancama navedene vrste entiteta
        /// </summary>
        /// <param name="operacija">Naziv operacije koja se želi izvesti nad kolekcijom instanci entiteta/označenog entiteta ("Update" ako se želi dohvatiti naziv forme za ažuriranje; inače se dohvaća naziv forme za dodavanje)</param>
        /// <returns>Naziv forme za vršenje definirane operacije nad trenutno prikazanom vrstom entiteta</returns>
        private string VratiImeFormeZaRadSTrenutnomVrstomEntiteta(string operacija)
        {            
            string ImeForme = "frm";
            char Separator = '_';
            string[] dijelovi = NaslovTablice.Tag.ToString().Split(Separator);
            foreach (var dio in dijelovi)
            {
                ImeForme += dio.First().ToString().ToUpper() + dio.Substring(1);
            }
            if (operacija == "Update")
            {
                ImeForme += "Update";
            }
            return ImeForme;
        }

        /// <summary>
        /// Otvara novu formu za unos (Create) novog entiteta trenutno promatrane vrste entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateSlika_Click(object sender, EventArgs e)
        {
            if (NaslovTablice.Text != "Dobro došli!")
            {
                string ImeForme = VratiImeFormeZaRadSTrenutnomVrstomEntiteta("Create");
                Type TipForme = Type.GetType("kolnikApp_klijent.FormeZaUnos." + ImeForme);
                Form nextForm2 = (Form)Activator.CreateInstance(TipForme);
                nextForm2.ShowDialog();
            }
        }

        /// <summary>
        /// Pokazuje ili sakriva tipku za odjavu iz sustava klikom na naziv samog prijavljenog korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Otvara novu formu za ažuriranje (Update) novog entiteta trenutno promatrane vrste entiteta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateSlika_Click(object sender, EventArgs e)
        {
            DataGridViewRow SelektiraniRedak = null;
            if (mainDgvObj.SelectedRows.Count != 0) {
                foreach (DataGridViewRow Red in mainDgvObj.SelectedRows)
                {
                   SelektiraniRedak = Red;
                }                
                string ImeForme = VratiImeFormeZaRadSTrenutnomVrstomEntiteta("Update");
                Type Tipforme = Type.GetType("kolnikApp_klijent.FormeZaUpdate." + ImeForme);
                Form FormaZaUpdate = null;
                if (additionalDgv.Visible && NaslovTablice.Tag.ToString() != "racun")
                {
                    if (additionalDgv.SelectedRows.Count == 0)
                    {
                        return;
                    }
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

        /// <summary>
        /// Odjavljuje se sa sustava te ponovno pokreće aplikaciju (tj. dio za prijavu u sustav)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            sockObj.SendLogoutRequest();
            Application.Restart();
        }

        /// <summary>
        /// Ispunjava sadržaj sekundarne tablice ovisno o zapisu iz primarne tablice čiji redak je korisnik upravo označio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleDataRepresentationInAdditionalDgvAfterRowSelectInMainDgv(object sender, DataGridViewCellEventArgs e)
        {
            FillDataInAdditionalDgv(e.RowIndex);
        }

        /// <summary>
        /// Ispunjava sadržaj sekundarne tablice ovisno o zapisu iz primarne tablice koji se nalazi u retku čiji indeks je proslijeđen
        /// </summary>
        /// <param name="rowIndex">Indeks retka na kojem se nalazi zapis na temelju kojeg se ispunjava sekundarna tablica s podacima za prikaz</param>
        private void FillDataInAdditionalDgv(int rowIndex)
        {
            switch (NaslovTablice.Tag.ToString())
            {
                case "zaposlen":
                    additionalDgv.DataSource = (from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                                                from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                                                from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                                                from radnoMjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                                                where ((osoba)zaposlenikObj).oib == ((zaposlen)zaposlenObj).zaposlenik &&
                                                      ((poduzece)poduzeceObj).oib == ((zaposlen)zaposlenObj).poduzece &&
                                                      ((radno_mjesto)radnoMjestoObj).id == ((zaposlen)zaposlenObj).radno_mjesto &&
                                                      ((zaposlen)zaposlenObj).poduzece == mainDgvObj[0, rowIndex].Value.ToString()
                                                select new
                                                {
                                                    OIB = ((osoba)zaposlenikObj).oib,
                                                    Ime = ((osoba)zaposlenikObj).ime,
                                                    Prezime = ((osoba)zaposlenikObj).prezime,
                                                    datum_pocetka = ((zaposlen)zaposlenObj).datum_pocetka,
                                                    datum_zavrsetka = ((zaposlen)zaposlenObj).datum_zavrsetka,
                                                    radno_mjesto = ((radno_mjesto)radnoMjestoObj).naziv
                                                }).ToArray();
                    break;
                case "vozi":
                    additionalDgv.DataSource = (from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                                                from voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                                                from zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                                                where ((vozi)voziObj).vozac == ((osoba)zaposlenikObj).oib &&
                                                      ((vozi)voziObj).vozilo == ((vozilo)voziloObj).registracijski_broj &&
                                                      ((vozi)voziObj).vozilo == mainDgvObj[0, rowIndex].Value.ToString()
                                                select new
                                                {
                                                    OIB = ((osoba)zaposlenikObj).oib,
                                                    Ime = ((osoba)zaposlenikObj).ime,
                                                    Prezime = ((osoba)zaposlenikObj).prezime,
                                                    datum_pocetka = ((vozi)voziObj).datum_pocetka,
                                                    datum_zavrsetka = ((vozi)voziObj).datum_zavrsetka
                                                }).ToArray();
                    break;
                case "racun":
                    additionalDgv.DataSource =
                        (from otpremnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["otpremnica"]
                         join zaposlenikObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         on ((otpremnica)otpremnicaObj).otpremitelj equals ((osoba)zaposlenikObj).oib
                         join narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                         on ((otpremnica)otpremnicaObj).nalog equals ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id
                         join voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).vozi equals ((vozi)voziObj).id
                         join vozacObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         on ((vozi)voziObj).vozac equals ((osoba)vozacObj).oib
                         join artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                         on ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).artikl equals ((artikl)artiklObj).id
                         where ((otpremnica)otpremnicaObj).racun == int.Parse(mainDgvObj[0, rowIndex].Value.ToString())
                         select new
                         {
                             narudzbenica = ((otpremnica)otpremnicaObj).nalog.ToString() + " - " + ((osoba)vozacObj).ime + " " + ((osoba)vozacObj).prezime + " (" + ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).kolicina.ToString() + " tona " + ((artikl)artiklObj).naziv + ")",
                             izdavatelj = ((osoba)zaposlenikObj).ime + " " + ((osoba)zaposlenikObj).prezime,
                             datum_otpreme = ((otpremnica)otpremnicaObj).datum_otpreme
                         }).ToArray();
                    break;
            }
        }

        /// <summary>
        /// Brine se za promjenu veličina tablica za prikaz podataka prilikom mijenjanja veličine cjelokupne forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void obrazac_Resize(object sender, EventArgs e)
        {
            AdjustDGVsWhenTheyAreNotDocked();
        }

        /// <summary>
        /// Definira margine tablica za prikaz podataka kao i njihove veličine u odnosu na cjelokupnu veličinu forme na kojoj se nalaze te adaptacija širina stupaca unutar tablice ovisno o novoj širini tablica
        /// </summary>
        private void AdjustDGVsWhenTheyAreNotDocked()
        {
            mainDgvObj.Height = additionalDgv.Height = (int)(PanelZaSadrzaj.Height * 0.48);
            additionalDgv.Top = mainDgvObj.Height + (int)(PanelZaSadrzaj.Height * 0.04);
            additionalDgv.Width = mainDgvObj.Width = PanelZaSadrzaj.Width;
            additionalDgv.Left = mainDgvObj.Left;
            AutomaticallyResizeColumns(ref mainDgvObj);
            AutomaticallyResizeColumns(ref additionalDgv);
        }

        /// <summary>
        /// Sakriva tipku za odjavu sa sustava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Leave(object sender, EventArgs e)
        {
            LogoutButton.Hide();
        }

        /// <summary>
        /// Odjavljuje se sa sustava nakon što korisnik zatvori glavnu formu, a ujedno i cjelokupnu aplikaciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void obrazac_FormClosing(object sender, FormClosingEventArgs e)
        {
            sockObj.SendLogoutRequest();
        }

        /// <summary>
        /// Brine se da se naziv korisnika nalazi nužno u gornjem desnom kutu pokraj tipke za minimiziranje prozora (slično bi se dalo postići i korištenjem Alignment opcije Right, ali tada bi morala biti isključena opcija AutoSize što bi ujedno rezultiralo potrebnim definiranjem širine oznake (labela) što nije moguće unaprijed odrediti)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImeKorisnika_Resize(object sender, EventArgs e)
        {
            int distanceDifference = ImeKorisnika.Right - Minimize.Left;
            if (distanceDifference > 0)
            {
                ImeKorisnika.Left = ImeKorisnika.Left - distanceDifference;
            }
        }

        /// <summary>
        /// Briše trenutno označeni entitet iz primarne tablice ukoliko samo ona postoji, a u supronom označeni entitet iz sekundarne tablice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSlika_Click(object sender, EventArgs e)
        {
            if (additionalDgv.Visible)
            {
                if (additionalDgv.SelectedRows.Count > 0)
                {
                    List<object> result = ReturnObjectsThatAreContainedInSelectedEntities(mainDgvObj.SelectedRows[0], additionalDgv.SelectedRows[0]);
                    string dataForSending;
                    if (result.Count == 1)
                    {
                        dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(result.First()), 'D');
                    }
                    else
                    {
                        dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(result), 'D');
                    }
                    sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (mainDgvObj.SelectedRows.Count > 0)
                {
                    List<object> result = ReturnObjectsThatAreContainedInSelectedEntities(mainDgvObj.SelectedRows[0]);
                    string dataForSending;
                    if (result.Count == 1)
                    {
                        dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(result.First()), 'D');
                    }
                    else
                    {
                        dataForSending = DataHandler.AddHeaderInfoToXMLDatagroup(DataHandler.ConvertObjectsToXMLData(result), 'D');
                    }
                    sockObj.SendSerializedData(DataHandler.AddWrapperOverXMLDatagroups(dataForSending));
                }
                else
                {
                    return;
                }
            }
        }

        private List<object> ReturnObjectsThatAreContainedInSelectedEntities(DataGridViewRow selectedRowFromPrimary, DataGridViewRow selectedRowFromSecondary = null)
        {
            List<object> objectsToReturn = new List<object>();
            switch (NaslovTablice.Tag.ToString())
            {
                case "artikl":
                    objectsToReturn.Add(
                        (from artiklObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["artikl"]
                         where ((artikl)artiklObj).id == int.Parse(selectedRowFromPrimary.Cells[0].Value.ToString())
                         select (artikl)artiklObj).First()
                    );
                    break;
                case "narudzbenica_bitumenske_mjesavine":
                    objectsToReturn.Add(
                        (from narudzbenicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["narudzbenica_bitumenske_mjesavine"]
                        where ((narudzbenica_bitumenske_mjesavine)narudzbenicaObj).id == int.Parse(selectedRowFromPrimary.Cells[0].Value.ToString())
                         select (narudzbenica_bitumenske_mjesavine)narudzbenicaObj).First()
                    );
                    break;
                case "osoba":
                    List<korisnicki_racun> userAccount = (from korisnickiRacunObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["korisnicki_racun"]
                     where ((korisnicki_racun)korisnickiRacunObj).zaposlenik == selectedRowFromPrimary.Cells[0].Value.ToString()
                                                          select (korisnicki_racun)korisnickiRacunObj).ToList();
                    if (userAccount.Count > 0)
                    {
                        objectsToReturn.Add(userAccount[0]);
                    }
                    objectsToReturn.Add(
                        (from osobaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["osoba"]
                         where ((osoba)osobaObj).oib == selectedRowFromPrimary.Cells[0].Value.ToString()
                         select (osoba)osobaObj).First()
                    );
                    break;
                case "otpremnica":
                    objectsToReturn.Add(
                        (from otpremnicaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["otpremnica"]
                         where ((otpremnica)otpremnicaObj).nalog == int.Parse(Regex.Match(selectedRowFromPrimary.Cells[0].Value.ToString(), @"^\d+").Value)
                         select (otpremnica)otpremnicaObj).First()
                    );
                    break;
                case "poduzece":
                    objectsToReturn.Add(
                        (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                         where ((poduzece)poduzeceObj).oib == selectedRowFromPrimary.Cells[0].Value.ToString()
                         select (poduzece)poduzeceObj).First()
                    );
                    break;
                case "proizvodni_nalog":
                    objectsToReturn.Add(
                        (from nalogObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["proizvodni_nalog"]
                         where ((proizvodni_nalog)nalogObj).narudzbenica == int.Parse(Regex.Match(selectedRowFromPrimary.Cells[0].Value.ToString(), @"^\d+").Value)
                         select (proizvodni_nalog)nalogObj).First()
                    );
                    break;
                case "rabat":
                    objectsToReturn.Add(
                        (from poduzeceObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["poduzece"]
                         where ((poduzece)poduzeceObj).naziv == selectedRowFromPrimary.Cells[0].Value.ToString()
                         join rabatObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["rabat"]
                         on ((poduzece)poduzeceObj).oib equals ((rabat)rabatObj).poslovni_partner
                         select (otpremnica)rabatObj).First()
                    );
                    break;
                case "racun":
                    objectsToReturn.Add(
                        (from racunObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["racun"]
                         where ((racun)racunObj).id == int.Parse(selectedRowFromPrimary.Cells[0].Value.ToString())
                         select (otpremnica)racunObj).First()
                    );
                    break;
                case "radno_mjesto":
                    objectsToReturn.Add(
                        (from radnoMjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                         where ((radno_mjesto)radnoMjestoObj).id == int.Parse(selectedRowFromPrimary.Cells[0].Value.ToString())
                         select (radno_mjesto)radnoMjestoObj).First()
                    );
                    break;
                case "tablicna_privilegija":
                    objectsToReturn.Add(
                        (from radnoMjestoObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["radno_mjesto"]
                         where ((radno_mjesto)radnoMjestoObj).naziv == selectedRowFromPrimary.Cells[0].Value.ToString()
                         join tablicnaPrivilegijaObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["tablicna_privilegija"]
                         on ((radno_mjesto)radnoMjestoObj).id equals ((tablicna_privilegija)tablicnaPrivilegijaObj).radno_mjesto
                         where ((tablicna_privilegija)tablicnaPrivilegijaObj).naziv_tablice == selectedRowFromPrimary.Cells[1].Value.ToString()
                         select (tablicna_privilegija)tablicnaPrivilegijaObj).First()
                    );
                    break;
                case "vozi":
                    objectsToReturn.Add(
                        (from voziObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozi"]
                         where ((vozi)voziObj).vozilo == selectedRowFromPrimary.Cells[0].Value.ToString()
                         && ((vozi)voziObj).vozac == selectedRowFromSecondary.Cells[0].Value.ToString()
                         && ((vozi)voziObj).datum_pocetka.ToString() == selectedRowFromSecondary.Cells[3].Value.ToString()
                         select (vozi)voziObj).First()
                    );
                    break;
                case "vozilo":
                    objectsToReturn.Add(
                        (from voziloObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["vozilo"]
                         where ((vozilo)voziloObj).registracijski_broj == selectedRowFromPrimary.Cells[0].Value.ToString()
                         select ((vozilo)voziloObj)).First()
                    );
                    break;
                case "zaposlen":
                    objectsToReturn.Add(
                        (from zaposlenObj in DataHandler.entityNamesWithReferencesToBelongingDataStores["zaposlen"]
                         where ((zaposlen)zaposlenObj).poduzece == selectedRowFromPrimary.Cells[0].Value.ToString()
                         && ((zaposlen)zaposlenObj).zaposlenik == selectedRowFromSecondary.Cells[0].Value.ToString()
                         && ((zaposlen)zaposlenObj).datum_pocetka.ToString() == selectedRowFromSecondary.Cells[3].Value.ToString()
                         select (zaposlen)zaposlenObj).First()
                    );
                    break;
            }
            return objectsToReturn;
        }
    }
}

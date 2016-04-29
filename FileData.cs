using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp
{
    interface Entitet
    {
        void SetData(string nazivAtributa, string vrijednostAtributa);
        Dictionary<string, string> PrimaryKeysWithValues();
    }
    class JedinicaMjere : Entitet
    {
        private int idJedinicaMjere;
        private string oznaka;
        public int IdJedinicaMjere {
            get { return idJedinicaMjere; }
        }
        public string Oznaka {
            get { return oznaka; }
        }
        public JedinicaMjere(string idJedinicaMjere, string oznaka, bool upisiUDatoteku = false)
        {
            if (!int.TryParse(idJedinicaMjere,out this.idJedinicaMjere))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.oznaka = oznaka;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idJedinicaMjere"] = idJedinicaMjere.ToString();
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idJedinicaMjere":
                    if (!int.TryParse(vrijednostAtributa, out this.idJedinicaMjere))
                        {
                            MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                            return;
                        }
                    break;
                case "oznaka":
                    this.oznaka = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Artikl : Entitet
    {
        private int idArtikla;
        private string naziv;
        private double jedinicnaCijena;
        private int jedinicaMjere;

        public int IdArtikla
        {
            get { return idArtikla; }
        }
        public string Naziv
        {
            get { return naziv; }
        }
        public double JedinicnaCijena
        {
            get { return jedinicnaCijena; }
        }
        public int JedinicaMjere
        {
            get { return jedinicaMjere; }
        }
        public Artikl(string idArtikla, string naziv, string jedinicnaCijena, string jedinicaMjere, bool upisiUDatoteku = false)
        {
            if (!(int.TryParse(idArtikla, out this.idArtikla) && int.TryParse(jedinicaMjere, out this.jedinicaMjere) && double.TryParse(jedinicnaCijena, out this.jedinicnaCijena)))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.naziv = naziv;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idArtikla"] = idArtikla.ToString();
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idArtikla":
                    if (!int.TryParse(vrijednostAtributa, out this.idArtikla))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "naziv":
                    this.naziv = vrijednostAtributa;
                    break;
                case "jedinicnaCijena":
                    if (!double.TryParse(vrijednostAtributa, out this.jedinicnaCijena))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;

                case "jedinicaMjere":
                    if (!int.TryParse(vrijednostAtributa, out this.jedinicaMjere))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Rabat : Entitet
    {
        private int idArtikla;
        private string oibPartnera;
        private double popust;

        public int IdArtikla
        {
            get { return idArtikla; }
        }
        public string OibPartnera
        {
            get { return oibPartnera; }
        }
        public double Popust
        {
            get { return popust; }
        }
        public Rabat(string idArtikla, string oibPartnera, string popust, bool upisiUDatoteku = false)
        {
            if (!(int.TryParse(idArtikla, out this.idArtikla) && double.TryParse(popust, out this.popust)))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.oibPartnera = oibPartnera;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idArtikla"] = idArtikla.ToString();
            rjecnik["oibPartnera"] = oibPartnera;
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idArtikla":
                    if (!int.TryParse(vrijednostAtributa, out this.idArtikla))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "oibPartnera":
                    this.oibPartnera = vrijednostAtributa;
                    break;
                case "popust":
                    if (!double.TryParse(vrijednostAtributa, out this.popust))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Vozac : Entitet
    {
        private string oib;
        private string ime;
        private string prezime;
        private int prijevoznickaKompanija;

        public string Oib
        {
            get { return oib; }
        }
        public string Ime
        {
            get { return ime; }
        }
        public string Prezime
        {
            get { return prezime; }
        }
        public int PrijevoznickaKompanija
        {
            get { return prijevoznickaKompanija; }
        }
        public Vozac(string oib, string ime, string prezime, string prijevoznickaKompanija, bool upisiUDatoteku = false)
        {
            if (!int.TryParse(prijevoznickaKompanija, out this.prijevoznickaKompanija))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.oib = oib;
            this.ime = ime;
            this.prezime = prezime;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["oib"] = oib;
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "oib":
                    this.oib = vrijednostAtributa;
                    break;
                case "ime":
                    this.ime = vrijednostAtributa;
                    break;
                case "prezime":
                    this.prezime = vrijednostAtributa;
                    break;
                case "prijevoznickaKompanija":
                    if (!int.TryParse(vrijednostAtributa, out this.prijevoznickaKompanija))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class PoslovniPartner : Entitet
    {
        private string oib;
        private string naziv;
        private string adresa;
        private string iban;

        public string Oib
        {
            get { return oib; }
        }
        public string Naziv
        {
            get { return naziv; }
        }
        public string Adresa
        {
            get { return adresa; }
        }
        public string Iban
        {
            get { return iban; }
        }
        public PoslovniPartner(string oib, string naziv, string adresa, string iban, bool upisiUDatoteku = false)
        {
            this.oib = oib;
            this.naziv = naziv;
            this.adresa = adresa;
            this.iban = iban;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["oib"] = oib;
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "oib":
                    this.oib = vrijednostAtributa;
                    break;
                case "naziv":
                    this.naziv = vrijednostAtributa;
                    break;
                case "adresa":
                    this.adresa = vrijednostAtributa;
                    break;
                case "iban":
                    this.iban = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Vozi : Entitet
    {
        private string vozac;
        private string vozilo;
        private string datumPocetka;
        private string datumZavrsetka;

        public string Vozac
        {
            get { return vozac; }
        }
        public string Vozilo
        {
            get { return vozilo; }
        }
        public string DatumPocetka
        {
            get { return datumPocetka; }
        }
        public string DatumZavrsetka
        {
            get { return datumZavrsetka; }
        }
        public Vozi(string vozac, string vozilo, string datumPocetka, string datumZavrsetka, bool upisiUDatoteku = false)
        {
            this.vozac = vozac;
            this.vozilo = vozilo;
            this.datumPocetka = datumPocetka;
            this.datumZavrsetka = datumZavrsetka;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["vozac"] = vozac;
            rjecnik["vozilo"] = vozilo;
            rjecnik["datumPocetka"] = datumPocetka;
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "vozac":
                    this.vozac = vrijednostAtributa;
                    break;
                case "vozilo":
                    this.vozilo = vrijednostAtributa;
                    break;
                case "datumPocetka":
                    this.datumPocetka = vrijednostAtributa;
                    break;
                case "datumZavrsetka":
                    this.datumZavrsetka = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Vozilo : Entitet
    {
        private string registarskiBroj;
        private string proizvodjacVozila;
        private string modelVozila;

        public string RegistarskiBroj
        {
            get { return registarskiBroj; }
        }
        public string ProizvodjacVozila
        {
            get { return proizvodjacVozila; }
        }
        public string ModelVozila
        {
            get { return modelVozila; }
        }
        public Vozilo(string registarskiBroj, string proizvodjacVozila, string modelVozila, bool upisiUDatoteku = false)
        {
            this.registarskiBroj = registarskiBroj;
            this.proizvodjacVozila = proizvodjacVozila;
            this.modelVozila = modelVozila;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["registarskiBroj"] = registarskiBroj;
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "registarskiBroj":
                    this.registarskiBroj = vrijednostAtributa;
                    break;
                case "proizvodjacVozila":
                    this.proizvodjacVozila = vrijednostAtributa;
                    break;
                case "modelVozila":
                    this.modelVozila = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class NarudzbenicaBitumenskeMjesavine : Entitet
    {
        private int idNarudzbenice;
        private string datumIzdavanja;
        private double kolicina;
        private string datumPotrazivanja;
        private string narucitelj;
        private int artikl;
        private string vozac;
        private string vozilo;

        public int IdNarudzbenice
        {
            get { return idNarudzbenice; }
        }
        public string DatumIzdavanja
        {
            get { return datumIzdavanja; }
        }
        public double Kolicina
        {
            get { return kolicina; }
        }
        public string DatumPotrazivanja
        {
            get { return datumPotrazivanja; }
        }
        public string Narucitelj
        {
            get { return narucitelj; }
        }
        public int Artikl
        {
            get { return artikl; }
        }
        public string Vozac
        {
            get { return vozac; }
        }
        public string Vozilo
        {
            get { return vozilo; }
        }
        public NarudzbenicaBitumenskeMjesavine(string idNarudzbenice, string datumIzdavanja, string kolicina, string datumPotrazivanja, string narucitelj, string artikl, string vozac, string vozilo, bool upisiUDatoteku = false)
        {
            if (!(int.TryParse(idNarudzbenice, out this.idNarudzbenice) && double.TryParse(kolicina, out this.kolicina) && int.TryParse(artikl, out this.artikl)))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.datumIzdavanja = datumIzdavanja;
            this.datumPotrazivanja = datumPotrazivanja;
            this.narucitelj = narucitelj;
            this.vozac = vozac;
            this.vozilo = vozilo;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idNarudzbenice"] = idNarudzbenice.ToString();
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idNarudzbenice":
                    if (!int.TryParse(vrijednostAtributa, out this.idNarudzbenice))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "datumIzdavanja":
                    this.datumIzdavanja = vrijednostAtributa;
                    break;
                case "kolicina":
                    if (!double.TryParse(vrijednostAtributa, out this.kolicina))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "datumPotrazivanja":
                    this.datumPotrazivanja = vrijednostAtributa;
                    break;
                case "narucitelj":
                    this.narucitelj = vrijednostAtributa;
                    break;
                case "artikl":
                    if (!int.TryParse(vrijednostAtributa, out this.artikl))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "vozac":
                    this.vozac = vrijednostAtributa;
                    break;
                case "vozilo":
                    this.vozilo = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class NalogZaProizvodnju : Entitet
    {
        private int idNaloga;
        private string vrijemeIzdavanja;
        private double kolicina;
        private int gradiliste;
        private string izdavatelj;
        private int artikl;
        private string vozac;
        private string vozilo;

        public int IdNaloga
        {
            get { return idNaloga; }
        }
        public string VrijemeIzdavanja
        {
            get { return vrijemeIzdavanja; }
        }
        public double Kolicina
        {
            get { return kolicina; }
        }
        public int Gradiliste
        {
            get { return gradiliste; }
        }
        public string Izdavatelj
        {
            get { return izdavatelj; }
        }
        public int Artikl
        {
            get { return artikl; }
        }
        public string Vozac
        {
            get { return vozac; }
        }
        public string Vozilo
        {
            get { return vozilo; }
        }
        public NalogZaProizvodnju(string idNaloga, string vrijemeIzdavanja, string kolicina, string gradiliste, string izdavatelj, string artikl, string vozac, string vozilo, bool upisiUDatoteku = false)
        {
            if (!(int.TryParse(idNaloga, out this.idNaloga) && double.TryParse(kolicina, out this.kolicina) && int.TryParse(gradiliste, out this.gradiliste) && int.TryParse(artikl, out this.artikl)))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.vrijemeIzdavanja = vrijemeIzdavanja;
            this.izdavatelj = izdavatelj;
            this.vozac = vozac;
            this.vozilo = vozilo;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idNaloga"] = idNaloga.ToString();
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idNaloga":
                    if (!int.TryParse(vrijednostAtributa, out this.idNaloga))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "vrijemeIzdavanja":
                    this.vrijemeIzdavanja = vrijednostAtributa;
                    break;
                case "kolicina":
                    if (!double.TryParse(vrijednostAtributa, out this.kolicina))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "gradiliste":
                    if (!int.TryParse(vrijednostAtributa, out this.gradiliste))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "izdavatelj":
                    this.izdavatelj = vrijednostAtributa;
                    break;
                case "artikl":
                    if (!int.TryParse(vrijednostAtributa, out this.artikl))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "vozac":
                    this.vozac = vrijednostAtributa;
                    break;
                case "vozilo":
                    this.vozilo = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Gradiliste : Entitet
    {
        private int idGradilista;
        private string nazivMjesta;
        public int IdGradilista
        {
            get { return idGradilista; }
        }
        public string NazivMjesta
        {
            get { return nazivMjesta; }
        }
        public Gradiliste(string idGradilista, string nazivMjesta, bool upisiUDatoteku = false)
        {
            if (!int.TryParse(idGradilista, out this.idGradilista))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.nazivMjesta = nazivMjesta;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idGradilista"] = idGradilista.ToString();
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idGradilista":
                    if (!int.TryParse(vrijednostAtributa, out this.idGradilista))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "nazivMjesta":
                    this.nazivMjesta = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Zaposlenik : Entitet
    {
        private string oib;
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string lozinka;

        public string Oib
        {
            get { return oib; }
        }
        public string Ime
        {
            get { return ime; }
        }
        public string Prezime
        {
            get { return prezime; }
        }
        public string KorisnickoIme
        {
            get { return korisnickoIme; }
        }
        public string Lozinka
        {
            get { return lozinka; }
        }
        public Zaposlenik(string oib, string ime, string prezime, string korisnickoIme, string lozinka, bool upisiUDatoteku = false)
        {
            this.oib = oib;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["oib"] = oib;
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "oib":
                    this.oib = vrijednostAtributa;
                    break;
                case "ime":
                    this.ime = vrijednostAtributa;
                    break;
                case "prezime":
                    this.prezime = vrijednostAtributa;
                    break;
                case "korisnickoIme":
                    this.korisnickoIme = vrijednostAtributa;
                    break;
                case "lozinka":
                    this.lozinka = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Racun : Entitet
    {
        private int idRacuna;
        private string datumIzdavanja;
        private string izdavatelj;

        public int IdRacuna
        {
            get { return idRacuna; }
        }
        public string DatumIzdavanja
        {
            get { return datumIzdavanja; }
        }
        public string Izdavatelj
        {
            get { return izdavatelj; }
        }
        public Racun(string idRacuna, string datumIzdavanja, string izdavatelj, bool upisiUDatoteku = false)
        {
            if (!int.TryParse(idRacuna, out this.idRacuna))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.datumIzdavanja = datumIzdavanja;
            this.izdavatelj = izdavatelj;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idRacuna"] = idRacuna.ToString();
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idRacuna":
                    if (!int.TryParse(vrijednostAtributa, out this.idRacuna))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "datumIzdavanja":
                    this.datumIzdavanja = vrijednostAtributa;
                    break;
                case "izdavatelj":
                    this.izdavatelj = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Otpremnica : Entitet
    {
        private int idOtpremnice;
        private string datumOtpreme;
        private char tipTemeljnice;
        private int temeljnica;
        private int racun;
        private string otpremitelj;

        public int IdOtpremnice
        {
            get { return idOtpremnice; }
        }
        public string DatumOtpreme
        {
            get { return datumOtpreme; }
        }
        public char TipTemeljnice
        {
            get { return tipTemeljnice; }
        }
        public int Temeljnica
        {
            get { return temeljnica; }
        }
        public int Racun
        {
            get { return racun; }
        }
        public string Otpremitelj
        {
            get { return otpremitelj; }
        }
        public Otpremnica(string idOtpremnice, string datumOtpreme, string tipTemeljnice, string temeljnica, string racun, string otpremitelj, bool upisiUDatoteku = false)
        {
            if (!(int.TryParse(idOtpremnice, out this.idOtpremnice) && char.TryParse(tipTemeljnice, out this.tipTemeljnice) && int.TryParse(temeljnica, out this.temeljnica) && int.TryParse(racun, out this.racun)))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.datumOtpreme = datumOtpreme;
            this.otpremitelj = otpremitelj;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idOtpremnice"] = idOtpremnice.ToString();
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idOtpremnice":
                    if (!int.TryParse(vrijednostAtributa, out this.idOtpremnice))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "temeljnica":
                    if (!int.TryParse(vrijednostAtributa, out this.temeljnica))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "racun":
                    if (!int.TryParse(vrijednostAtributa, out this.racun))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "tipTemeljnice":
                    if (!char.TryParse(vrijednostAtributa, out this.tipTemeljnice))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "datumOtpreme":
                    this.datumOtpreme = vrijednostAtributa;
                    break;
                case "otpremitelj":
                    this.otpremitelj = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Radi : Entitet
    {
        private string zaposlenik;
        private int radnoMjesto;
        private string datumPocetka;
        private string datumZavrsetka;

        public string Zaposlenik
        {
            get { return zaposlenik; }
        }
        public int RadnoMjesto
        {
            get { return radnoMjesto; }
        }
        public string DatumPocetka
        {
            get { return datumPocetka; }
        }
        public string DatumZavrsetka
        {
            get { return datumZavrsetka; }
        }
        public Radi(string zaposlenik, string radnoMjesto, string datumPocetka, string datumZavrsetka, bool upisiUDatoteku = false)
        {
            this.zaposlenik = zaposlenik;
            if (!int.TryParse(radnoMjesto, out this.radnoMjesto))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.datumPocetka = datumPocetka;
            this.datumZavrsetka = datumZavrsetka;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["zaposlenik"] = zaposlenik;
            rjecnik["radnoMjesto"] = radnoMjesto.ToString();
            rjecnik["datumPocetka"] = datumPocetka;
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "zaposlenik":
                    this.zaposlenik = vrijednostAtributa;
                    break;
                case "radnoMjesto":
                    if (!int.TryParse(vrijednostAtributa, out this.radnoMjesto))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "datumPocetka":
                    this.datumPocetka = vrijednostAtributa;
                    break;
                case "datumZavrsetka":
                    this.datumZavrsetka = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class RadnoMjesto : Entitet
    {
        private int idRadnogMjesta;
        private string naziv;
        public int IdRadnogMjesta
        {
            get { return idRadnogMjesta; }
        }
        public string Naziv
        {
            get { return naziv; }
        }
        public RadnoMjesto(string idRadnogMjesta, string naziv, bool upisiUDatoteku = false)
        {
            if (!int.TryParse(idRadnogMjesta, out this.idRadnogMjesta))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.naziv = naziv;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idRadnogMjesta"] = idRadnogMjesta.ToString();
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idRadnogMjesta":
                    if (!int.TryParse(vrijednostAtributa, out this.idRadnogMjesta))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "naziv":
                    this.naziv = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class Privilegija : Entitet
    {
        private int idRadnogMjesta;
        private string tablica;
        private string dozvoljeneOperacije;
        public int IdRadnogMjesta
        {
            get { return idRadnogMjesta; }
        }
        public string Tablica
        {
            get { return tablica; }
        }
        public string DozvoljeneOperacije
        {
            get { return dozvoljeneOperacije; }
        }
        public Privilegija(string idRadnogMjesta, string tablica, string dozvoljeneOperacije, bool upisiUDatoteku = false)
        {
            if (!int.TryParse(idRadnogMjesta, out this.idRadnogMjesta))
            {
                MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                return;
            }
            this.tablica = tablica;
            this.dozvoljeneOperacije = dozvoljeneOperacije;
            if (upisiUDatoteku)
            {
                FileData.Instanca.ZapisiUDatoteku(this);
            }
        }
        public Dictionary<string, string> PrimaryKeysWithValues()
        {
            Dictionary<string, string> rjecnik = new Dictionary<string, string>();
            rjecnik["idRadnogMjesta"] = idRadnogMjesta.ToString();
            rjecnik["tablica"] = tablica;
            return rjecnik;
        }
        void Entitet.SetData(string nazivAtributa, string vrijednostAtributa)
        {
            Dictionary<string, string> stareVrijednostiKljuceva = PrimaryKeysWithValues();
            switch (nazivAtributa)
            {
                case "idRadnogMjesta":
                    if (!int.TryParse(vrijednostAtributa, out this.idRadnogMjesta))
                    {
                        MessageBox.Show("Javila se pogreška prilikom pretvorbe!");
                        return;
                    }
                    break;
                case "tablica":
                    this.tablica = vrijednostAtributa;
                    break;
                case "dozvoljeneOperacije":
                    this.dozvoljeneOperacije = vrijednostAtributa;
                    break;
            }
            FileData.Instanca.ZapisiUDatoteku(this, stareVrijednostiKljuceva);
        }
    }
    class FileData
    {
        private static FileData instanca;
        public static FileData Instanca
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new FileData();
                }
                return instanca;
            }
        }

        static private string domenaPosluzitelja = null;

        public void PostaviDefaultnuLokacijuDoSpremistaPodataka()
        {
            if (File.Exists("postavke.ini"))
            {
                string sadrzajPostavki = File.ReadAllText("postavke.ini");
                if (sadrzajPostavki=="")
                {
                    domenaPosluzitelja = null;
                    return;
                }
                domenaPosluzitelja = sadrzajPostavki.Split(';')[0];
            }
            else
            {
                File.Create("postavke.ini");
                MessageBox.Show("Lokacija do spremista podataka nije definirana! Možete ju ručno definirati u postavkama (tipa gore-desno)");
                domenaPosluzitelja = null;
            }
        }

        public List<string> PribaviSveLokacijeDoSpremistaPodataka()
        {
            List<string> putanje = new List<string>();
            if (File.Exists("postavke.ini"))
            {
                string sadrzajPostavki = File.ReadAllText("postavke.ini");
                foreach (string putanja in sadrzajPostavki.Split(';'))
                {
                    putanje.Add(putanja);
                }
                return putanje;
            }

            MessageBox.Show("Lokacija do spremista podataka nije definirana! Možete ju ručno definirati u postavkama (tipa gore-desno)");
            return null;
        }

        public void PromijeniLokacijuDoSpremistaPodataka(string novaLokacija)
        {
            if (File.Exists("postavke.ini"))
            {
                string sadrzajPostavki = File.ReadAllText("postavke.ini");
                if (sadrzajPostavki!="")
                {
                    File.WriteAllText("postavke.ini", novaLokacija);
                    foreach (string putanja in sadrzajPostavki.Split(';'))
                    {
                        if (putanja!=novaLokacija)
                        {
                            File.AppendAllText("postavke.ini", ";" + putanja);
                        }
                    }

                }
                else
                {
                    File.WriteAllText("postavke.ini",novaLokacija);
                }
            }
        }


        public void ZapisiUDatoteku(Entitet slog,Dictionary<string,string> kljucevi=null)
        {
            if (kljucevi!=null)
            {
                string fileContents = System.IO.File.ReadAllText(domenaPosluzitelja + "jedinica_mjere.dat");
                bool nadjen = false;
                long pozicijaPocetkaMijenjanogSloga = 0, pozicijaZavrsetkaMijenjanogSloga = 0;
                using (BinaryReader reader = new BinaryReader(File.Open(domenaPosluzitelja + "jedinica_mjere.dat", FileMode.Open)))
                {
                    if (slog.GetType() == typeof(JedinicaMjere))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            JedinicaMjere tmpObj = new JedinicaMjere(reader.ReadInt32().ToString(), reader.ReadString());
                            if (kljucevi["idJedinicaMjere"] == tmpObj.IdJedinicaMjere.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Artikl))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Artikl tmpObj = new Artikl(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadDouble().ToString(), reader.ReadInt32().ToString());
                            if (kljucevi["idArtikla"] == tmpObj.IdArtikla.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Rabat))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Rabat tmpObj = new Rabat(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadDouble().ToString());
                            if (kljucevi["idArtikla"] == tmpObj.IdArtikla.ToString() && kljucevi["oibPartnera"] == tmpObj.OibPartnera)
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Vozac))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Vozac tmpObj = new Vozac(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadInt32().ToString());
                            if (kljucevi["oib"] == tmpObj.Oib)
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(PoslovniPartner))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            PoslovniPartner tmpObj = new PoslovniPartner(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["oib"] == tmpObj.Oib)
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Vozi))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Vozi tmpObj = new Vozi(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["vozac"] == tmpObj.Vozac && kljucevi["vozilo"] == tmpObj.Vozilo && kljucevi["datumPocetka"] == tmpObj.DatumPocetka)
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Vozilo))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Vozilo tmpObj = new Vozilo(reader.ReadString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["registarskiBroj"] == tmpObj.RegistarskiBroj)
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(NarudzbenicaBitumenskeMjesavine))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            NarudzbenicaBitumenskeMjesavine tmpObj = new NarudzbenicaBitumenskeMjesavine(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadDouble().ToString(), reader.ReadString(), reader.ReadInt32().ToString(), reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["idNarudzbenice"] == tmpObj.IdNarudzbenice.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(NalogZaProizvodnju))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            NalogZaProizvodnju tmpObj = new NalogZaProizvodnju(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadDouble().ToString(), reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["idNaloga"] == tmpObj.IdNaloga.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Gradiliste))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Gradiliste tmpObj = new Gradiliste(reader.ReadInt32().ToString(), reader.ReadString());
                            if (kljucevi["idGradilista"] == tmpObj.IdGradilista.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Zaposlenik))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Zaposlenik tmpObj = new Zaposlenik(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["oib"] == tmpObj.Oib.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Racun))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Racun tmpObj = new Racun(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["idRacuna"] == tmpObj.IdRacuna.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Otpremnica))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Otpremnica tmpObj = new Otpremnica(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadChar().ToString(), reader.ReadInt32().ToString(), reader.ReadInt32().ToString(),reader.ReadString());
                            if (kljucevi["idOtpremnica"] == tmpObj.IdOtpremnice.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Radi))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Radi tmpObj = new Radi(reader.ReadString(), reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["zaposlenik"] == tmpObj.Zaposlenik && kljucevi["radnoMjesto"] == tmpObj.RadnoMjesto.ToString() && kljucevi["datumPocetka"] == tmpObj.DatumPocetka)
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(RadnoMjesto))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            RadnoMjesto tmpObj = new RadnoMjesto(reader.ReadInt32().ToString(), reader.ReadString());
                            if (kljucevi["idRadnogMjesta"] == tmpObj.IdRadnogMjesta.ToString())
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    else if (slog.GetType() == typeof(Privilegija))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            pozicijaPocetkaMijenjanogSloga = reader.BaseStream.Position;
                            Privilegija tmpObj = new Privilegija(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString());
                            if (kljucevi["radnoMjesto"] == tmpObj.IdRadnogMjesta.ToString() && kljucevi["tablica"] == tmpObj.Tablica)
                            {
                                nadjen = true;
                                break;
                            }
                        }
                    }
                    pozicijaZavrsetkaMijenjanogSloga = reader.BaseStream.Position;
                }
                if (nadjen)     //trebalo bi uvijek biti true jer se vrijednosti primarnih kljuceva ne bi pozvale u ovu funkciju i ne bi se izvrsavao ovaj dio koda
                {
                    File.WriteAllText(domenaPosluzitelja + "jedinica_mjere.dat", fileContents.Substring(0, (int)pozicijaPocetkaMijenjanogSloga));
                    using (MemoryStream ms = new MemoryStream())
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(ms, ((JedinicaMjere)slog));
                        using (BinaryWriter writer = new BinaryWriter(File.Open(domenaPosluzitelja + "jedinica_mjere.dat", FileMode.Append)))
                        {
                            writer.Write(ms.ToArray());
                        }
                    }
                    File.AppendAllText(domenaPosluzitelja + "jedinica_mjere.dat", fileContents.Substring((int)pozicijaZavrsetkaMijenjanogSloga));
                }
            }
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, ((JedinicaMjere)slog));
                    using (BinaryWriter writer = new BinaryWriter(File.Open(domenaPosluzitelja + "jedinica_mjere.dat", FileMode.Append)))
                    {
                        writer.Write(ms.ToArray());
                    }
                }
            }
        }


        /// <summary>
        /// Dohvaća podatke o instancama tipa entiteta 'tipEntiteta' iz izvorišta podataka
        /// </summary>
        /// <param name="tipEntiteta">Tip entiteta o kojem se dohvaćaju podaci</param>
        /// <returns>Lista sa listom svih atributa instanci za svaku instancu određenog tipa entiteta</returns>
        public List<Entitet> GetFileData(string tipEntiteta)
        {
            string putanja = domenaPosluzitelja + tipEntiteta + ".dat";
            List<Entitet> lista = new List<Entitet>();
            if (File.Exists(putanja))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(putanja, FileMode.Open)))
                {
                        switch (tipEntiteta)
                        {
                            case "jedinica_mjere":
                                while (reader.BaseStream.Position != reader.BaseStream.Length)
                                {
                                    lista.Add(new JedinicaMjere(reader.ReadInt32().ToString(), reader.ReadString()) );
                                }
                            break;
                        case "artikl":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Artikl(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadDouble().ToString(), reader.ReadInt32().ToString()));
                            }
                            break;
                        case "rabat":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Rabat(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadDouble().ToString()));
                            }
                            break;
                        case "vozac":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Vozac(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadInt32().ToString()));
                            }
                            break;
                        case "poslovni_partner":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new PoslovniPartner(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                        case "vozi":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Vozi(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                        case "vozilo":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Vozilo(reader.ReadString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                        case "narudzbenica_bitumenske_mjesavine":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new NarudzbenicaBitumenskeMjesavine(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadDouble().ToString(), reader.ReadString(), reader.ReadInt32().ToString(), reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                        case "nalog_za_proizvodnju":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new NalogZaProizvodnju(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadDouble().ToString(), reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                        case "gradiliste":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Gradiliste(reader.ReadInt32().ToString(), reader.ReadString()));
                            }
                            break;
                        case "zaposlenik":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Zaposlenik(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                        case "racun":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Racun(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                        case "otpremnica":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Otpremnica(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadChar().ToString(), reader.ReadInt32().ToString(), reader.ReadInt32().ToString(),reader.ReadString()));
                            }
                            break;
                        case "radi":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Radi(reader.ReadString(), reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                        case "radno_mjesto":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new RadnoMjesto(reader.ReadInt32().ToString(), reader.ReadString()));
                            }
                            break;
                        case "privilegija":
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                lista.Add(new Privilegija(reader.ReadInt32().ToString(), reader.ReadString(), reader.ReadString()));
                            }
                            break;
                    }
                }
                return lista;
            }
            else
            {
                return null;
            }
        }
        /*  //POMOĆU OVOG KODA BI SE TAKOĐER DALO ELEGANTNO PRISTUPATI I RADITI S PODACIMA, NO IZBACEN JE ZBOG NEDOSTATKA OOP KONCEPATA
        static public Dictionary<Dictionary<string, string>, Dictionary<string, string>> GetData(string tipEntiteta)
                {
                    Dictionary<Dictionary<string,string>,Dictionary<string,string>> rjecnik = new Dictionary<Dictionary<string,string>, Dictionary<string, string>>();
                    string putanja;

                    if (tipEntiteta=="postavke")    //lokalne postavke (medju njima se nalazi i definirana domenaPosluzitelja)
                    {
                        putanja = tipEntiteta + ".ini";
                        if (File.Exists(putanja))
                        {
                            string sadrzajPostavki = File.ReadAllText(putanja);
                            int redniBrojProfila = 0;
                            foreach (string postavkeProfila in sadrzajPostavki.Split('\n'))
                            {
                                Dictionary<string,string> kljuc = new Dictionary<string, string>();
                                Dictionary<string, string> stavke = new Dictionary<string, string>();
                                foreach (string postavka in postavkeProfila.Split(';'))
                                {
                                    string[] kljucVrijednost = postavka.Split('=');
                                    if (kljucVrijednost[0]=="nazivProfila")
                                    {
                                        kljuc[redniBrojProfila.ToString()] = kljucVrijednost[1];
                                    }
                                    else
                                    {
                                        stavke[kljucVrijednost[0]] = kljucVrijednost[1];
                                    }
                                }
                                rjecnik[kljuc] = stavke;
                                redniBrojProfila++;
                            }
                        }
                    }
                    else
                    {
                        putanja = domenaPosluzitelja + tipEntiteta + ".dat";
                        if (File.Exists(putanja))
                        {
                            using (BinaryReader reader = new BinaryReader(File.Open(tipEntiteta, FileMode.Open)))
                            {
                                while (reader.BaseStream.Position != reader.BaseStream.Length)
                                {
                                    switch (tipEntiteta)
                                    {
                                        case "jedinica_mjere":
                                            {
                                                Dictionary<string,string> kljuc = new Dictionary<string, string>();
                                                kljuc["idJedinicaMjere"] = reader.ReadUInt16().ToString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["oznaka"] = reader.ReadString();
                                                break;
                                            }
                                        case "artikl":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["idArtikla"] = reader.ReadUInt16().ToString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["naziv"] = reader.ReadString();
                                                rjecnik[kljuc]["jedinicaMjere"] = reader.ReadUInt16().ToString();
                                                break;
                                            }
                                        case "rabat":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["idArtikla"] = reader.ReadUInt16().ToString();
                                                kljuc["oibPartnera"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["popust"] = reader.ReadDouble().ToString();
                                                break;
                                            }
                                        case "vozac":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["oib"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["ime"] = reader.ReadString();
                                                rjecnik[kljuc]["prezime"] = reader.ReadString();
                                                rjecnik[kljuc]["prijevoznickaKompanija"] = reader.ReadUInt16().ToString();
                                                break;
                                            }
                                        case "poslovni_partner":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["oib"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["naziv"] = reader.ReadString();
                                                rjecnik[kljuc]["adresa"] = reader.ReadString();
                                                rjecnik[kljuc]["iban"] = reader.ReadString();
                                                break;
                                            }
                                        case "vozi":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["vozac"] = reader.ReadString();
                                                kljuc["vozilo"] = reader.ReadString();
                                                kljuc["datumPocetka"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["datumZavrsetka"] = reader.ReadString();
                                                break;
                                            }
                                        case "vozilo":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["registarskiBroj"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["proizvodjacVozila"] = reader.ReadString();
                                                rjecnik[kljuc]["modelVozila"] = reader.ReadString();
                                                break;
                                            }
                                        case "narudzbenica_bitumenske_mjesavine":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["idNarudzbenice"] = reader.ReadUInt32().ToString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["datumIzdavanja"] = reader.ReadString();
                                                rjecnik[kljuc]["kolicina"] = reader.ReadDouble().ToString();
                                                rjecnik[kljuc]["datumPotrazivanja"] = reader.ReadString();
                                                rjecnik[kljuc]["narucitelj"] = reader.ReadString();
                                                rjecnik[kljuc]["artikl"] = reader.ReadUInt16().ToString();
                                                rjecnik[kljuc]["vozac"] = reader.ReadString();
                                                rjecnik[kljuc]["vozilo"] = reader.ReadString();
                                                break;
                                            }
                                        case "nalog_za_proizvodnju":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["idNaloga"] = reader.ReadUInt32().ToString();
                                                rjecnik[kljuc] = new Dictionary<string,string>();
                                                rjecnik[kljuc]["vrijemeIzdavanja"] = reader.ReadString();
                                                rjecnik[kljuc]["kolicina"] = reader.ReadDouble().ToString();
                                                rjecnik[kljuc]["gradiliste"] = reader.ReadUInt16().ToString();
                                                rjecnik[kljuc]["izdavatelj"] = reader.ReadString();
                                                rjecnik[kljuc]["artikl"] = reader.ReadUInt16().ToString();
                                                rjecnik[kljuc]["vozac"] = reader.ReadString();
                                                rjecnik[kljuc]["vozilo"] = reader.ReadString();
                                                break;
                                            }
                                        case "gradiliste":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["idGradilista"] = reader.ReadInt16().ToString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["nazivMjesta"] = reader.ReadString();
                                                break;
                                            }
                                        case "zaposlenik":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["oib"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["ime"] = reader.ReadString();
                                                rjecnik[kljuc]["prezime"] = reader.ReadString();
                                                rjecnik[kljuc]["korisnickoIme"] = reader.ReadString();
                                                rjecnik[kljuc]["lozinka"] = reader.ReadString();
                                                break;
                                            }
                                        case "racun":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["idRacuna"] = reader.ReadUInt32().ToString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["datumIzdavanja"] = reader.ReadString();
                                                rjecnik[kljuc]["izdavatelj"] = reader.ReadString();
                                                break;
                                            }
                                        case "otpremnica":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["idOtpremnice"] = reader.ReadUInt32().ToString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["datumOtpreme"] = reader.ReadString();
                                                rjecnik[kljuc]["tipTemeljnice"] = reader.ReadChar().ToString();
                                                rjecnik[kljuc]["temeljnica"] = reader.ReadUInt32().ToString();
                                                rjecnik[kljuc]["racun"] = reader.ReadUInt32().ToString();
                                                break;
                                            }
                                        case "radi":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["zaposlenik"] = reader.ReadString();
                                                kljuc["radnoMjesto"] = reader.ReadUInt16().ToString();
                                                kljuc["datumPocetka"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["datumZavrsetka"] = reader.ReadString();
                                                break;
                                            }
                                        case "radno_mjesto":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["idRadnogMjesta"] = reader.ReadUInt16().ToString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["naziv"] = reader.ReadString();
                                                break;
                                            }
                                        case "privilegija":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["radnoMjesto"] = reader.ReadUInt16().ToString();
                                                kljuc["tablica"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                rjecnik[kljuc]["dozvoljeneOperacije"] = reader.ReadString();
                                                break;
                                            }
                                        case "tablica":
                                            {
                                                Dictionary<string, string> kljuc = new Dictionary<string, string>();
                                                kljuc["naziv"] = reader.ReadString();
                                                rjecnik[kljuc] = new Dictionary<string, string>();
                                                break;
                                            }
                                    }
                                }
                            }
                        }
                        else
                        {
                            return null;
                        }

                    }
                    return rjecnik;
                }
                */
            }
}

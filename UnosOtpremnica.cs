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
    public partial class UnosOtpremnica : Form
    {
        private string oibNum;
        public UnosOtpremnica(string oibNum)
        {
            this.oibNum = oibNum;
            InitializeComponent();
            inputDatum.Text = DateTime.Now.Date.ToString();
        }

        private void tboxVrijeme_Enter(object sender, EventArgs e)
        {
            if (tboxVrijeme.Text=="")
            {
                tboxVrijeme.Text = DateTime.Now.TimeOfDay.ToString();
            }
        }

        private void tipkaOsvjezi_Click(object sender, EventArgs e)
        {
            int trenutniRedak = 0;
            foreach (NarudzbenicaBitumenskeMjesavine narudzbenica in FileData.Instanca.GetFileData("narudzbenica_bitumenske_mjesavine"))
            {
                popisTemeljnica["sifra", trenutniRedak].Value = narudzbenica.IdNarudzbenice;
                popisTemeljnica["tip", trenutniRedak].Value = "Narudžbenica";
                popisTemeljnica["oib", trenutniRedak].Value = narudzbenica.Narucitelj;
                foreach (PoslovniPartner partner in FileData.Instanca.GetFileData("poslovni_partner"))
                {
                    if (partner.Oib==narudzbenica.Narucitelj)
                    {
                        popisTemeljnica["naziv", trenutniRedak].Value = partner.Naziv;
                        break;
                    }
                }
                foreach (Artikl artikl in FileData.Instanca.GetFileData("artikl"))
                {
                    if (artikl.IdArtikla==narudzbenica.Artikl)
                    {
                        popisTemeljnica["artikl", trenutniRedak].Value = artikl.Naziv;
                        break;
                    }
                }
                popisTemeljnica["kolicina", trenutniRedak].Value = narudzbenica.Kolicina;
                popisTemeljnica["datum", trenutniRedak].Value = narudzbenica.DatumPotrazivanja;
                foreach (Vozac vozac in FileData.Instanca.GetFileData("vozac"))
                {
                    if (vozac.Oib==narudzbenica.Vozac)
                    {
                        popisTemeljnica["vozac", trenutniRedak].Value = vozac.Ime + " " + vozac.Prezime;
                        break;
                    }

                }
                popisTemeljnica["regoznaka", trenutniRedak].Value = narudzbenica.Vozilo;
                trenutniRedak++;
            }
            foreach (NalogZaProizvodnju nalog in FileData.Instanca.GetFileData("nalog_za_proizvodnju"))
            {
                popisTemeljnica["sifra", trenutniRedak].Value = nalog.IdNaloga;
                popisTemeljnica["tip", trenutniRedak].Value = "Nalog";
                popisTemeljnica["oib", trenutniRedak].Value = nalog.Izdavatelj;
                foreach (Zaposlenik zaposlenik in FileData.Instanca.GetFileData("zaposlenik"))
                {
                    if (zaposlenik.Oib == nalog.Izdavatelj)
                    {
                        popisTemeljnica["naziv", trenutniRedak].Value = zaposlenik.Ime + " " + zaposlenik.Prezime;
                        break;
                    }
                }
                foreach (Artikl artikl in FileData.Instanca.GetFileData("artikl"))
                {
                    if (artikl.IdArtikla == nalog.Artikl)
                    {
                        popisTemeljnica["artikl", trenutniRedak].Value = artikl.Naziv;
                        break;
                    }
                }
                popisTemeljnica["kolicina", trenutniRedak].Value = nalog.Kolicina;
                popisTemeljnica["datum", trenutniRedak].Value = nalog.VrijemeIzdavanja;
                foreach (Vozac vozac in FileData.Instanca.GetFileData("vozac"))
                {
                    if (vozac.Oib == nalog.Vozac)
                    {
                        popisTemeljnica["vozac", trenutniRedak].Value = vozac.Ime + " " + vozac.Prezime;
                        break;
                    }

                }
                popisTemeljnica["regoznaka", trenutniRedak].Value = nalog.Vozilo;
                trenutniRedak++;
            }
        }

        private void UnosOtpremnica_Load(object sender, EventArgs e)
        {
            tipkaOsvjezi_Click(sender, e);
        }

        private void ocistiOtpremnicu_Click(object sender, EventArgs e)
        {
            popisTemeljnica.ClearSelection();
        }

        private void kreirajOtpremnicu_Click(object sender, EventArgs e)
        {
            new Otpremnica(
                FileData.Instanca.GetFileData("otpremnica").Count().ToString(),
                inputDatum.Text + " " + tboxVrijeme.Text,
                (popisTemeljnica["tip",popisTemeljnica.SelectedRows[0].Index].Value.ToString()=="Narudzba"?"R":"L"),
                popisTemeljnica["sifra", popisTemeljnica.SelectedRows[0].Index].Value.ToString(),
                "-1",
                oibNum
                ,
                true
                );
        }
    }
}

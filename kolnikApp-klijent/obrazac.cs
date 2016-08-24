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

namespace kolnikApp_klijent
{
    public partial class obrazac : Form
    {
        public obrazac()
        {
            InitializeComponent();
        }       
        string[] tablice = new string[17] { "Artikl", "Rabat", "Zaposlen", "Poduzeće", "Vozi", "Vozilo", "Temeljnica", "Narudžbenica", "Zaposlenik", "Radi", "Korisnički račun", "Račun", "Otpremnica", "Tablična privilegija", "Gradilište", "Nalog za proizvodnju", "Radno mjesto" };

        String exeDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        private void HelpSlika_Click(object sender, EventArgs e)
        {
            String HelpFilepath = "file://" + Path.Combine(exeDirectory, "KolnikAppHelp.chm");
            Help.ShowHelp(this, HelpFilepath);     
        }

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

        private void NatragSlika_MouseEnter(object sender, EventArgs e)
        {
            LabelaNatrag.Show();
        }

        private void NatragSlika_MouseLeave(object sender, EventArgs e)
        {
            LabelaNatrag.Hide();
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
            /*FormeZaUnos.frmArtikl frmUnosArtikl = new FormeZaUnos.frmArtikl();
            frmUnosArtikl.ShowDialog();*/
            FormeZaUnos.frmNalogZaProizvodnju frmUnosNalog = new FormeZaUnos.frmNalogZaProizvodnju();
            frmUnosNalog.ShowDialog();
        }
    }
}

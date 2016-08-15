using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolnikApp
{
    public partial class obrazac : Form
    {
        public obrazac()
        {
            InitializeComponent();
        }

        string[] tablice = new string[17] { "Artikl", "Rabat", "Zaposlen", "Poduzeće", "Vozi", "Vozilo", "Temeljnica", "Narudžbenica", "Zaposlenik", "Radi", "Korisnički račun", "Račun", "Otpremnica", "Tablična privilegija", "Gradilište", "Nalog za proizvodnju", "Radno mjesto" };
        private void HelpSlika_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "file://C:\\Users\\Smrad\\Documents\\Visual Studio 2015\\Projects\\KolnikApp\\KolnikApp\\Resources\\KolnikAppHelp.chm");
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
            Label LabelaHome = new Label();
            LabelaHome.Text = "Početna";
            LabelaHome.Show();
        }
    }
}

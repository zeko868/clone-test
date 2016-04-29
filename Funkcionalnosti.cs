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
    public partial class Funkcionalnosti : Form
    {
        public Funkcionalnosti(string username, string ime, string prezime, string oib)
        {
            InitializeComponent();
            labelNaziv.Text = ime + " " + prezime;
/*  TO BE CONTINUED
foreach (RadnoMjesto radnoMjesto in FileData.Instanca.GetFileData("radno_mjesto"))
            {
                if (radnoMjesto.
            }
            foreach (Privilegija dozvola in FileData.Instanca.GetFileData("privilegija"))
            {
                if (
            }
            labelGrupa.Text = "Vaša grupa: " + 
            */
        }
    }
}

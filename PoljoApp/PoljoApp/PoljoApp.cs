using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PoljoAppVerzija2
{
    public partial class PoljoApp : Form
    {
        private Djelatnik Korisnik;

        public PoljoApp(Djelatnik prijava)
        {
            InitializeComponent();
            uiProizvodi.BringToFront();

            Korisnik = prijava;
            if (Korisnik.Admin == 1) uiUpravljanje.Visible = true;
        }

        private void UiActionOpenSadnja_Click(object sender, EventArgs e)
        {
            uiSadnja.BringToFront();
        }

        private void UiActionOpenPovrsine_Click(object sender, EventArgs e)
        {
            uiPovrsine.BringToFront();
        }

        private void UiActionNavodnjavanje_Click(object sender, EventArgs e)
        {
            uiNavodnjavanje.BringToFront();
        }

        private void UiActionPrskanje_Click(object sender, EventArgs e)
        {
            uiPrskanje.BringToFront();
        }

        private void UiActionOpenProizvodi_Click(object sender, EventArgs e)
        {
            uiProizvodi.BringToFront();
        }

        private void UiActionOpenZastita_Click(object sender, EventArgs e)
        {
            uiZastita.BringToFront();
        }

        private void UiOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrijavaForma prijava = new PrijavaForma();
            prijava.FormClosed += (s,args) => this.Close();
            prijava.ShowDialog();
        }

        private void UiUpravljanje_Click(object sender, EventArgs e)
        {
            Admin.DjelatniciForma pregledDjelatnika = new Admin.DjelatniciForma();
            pregledDjelatnika.ShowDialog();
        }
    }
}

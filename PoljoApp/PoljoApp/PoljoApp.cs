﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoljoAppVerzija2
{
    public partial class PoljoApp : Form
    {
        private djelatnik Korisnik;

        public PoljoApp(djelatnik prijava)
        {
            InitializeComponent();
            uiProizvodi.BringToFront();

            Korisnik = prijava;
            if (Korisnik.admin == 1) uiUpravljanje.Visible = true;
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
            prijava.Activated += (s,args) => this.Close();
            prijava.ShowDialog();
        }

        private void UiUpravljanje_Click(object sender, EventArgs e)
        {
            Admin.DjelatniciForma pregledDjelatnika = new Admin.DjelatniciForma();
            pregledDjelatnika.ShowDialog();
        }
    }
}

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
using DataLayer;

namespace PoljoAppVerzija2
{
    public partial class PoljoApp : Form
    {
        private DataLayer.Djelatnik Korisnik;
        private Timer OborineTimer;
        private int Interval = 10;

        public PoljoApp(DataLayer.Djelatnik prijava)
        {
            InitializeComponent();

            Korisnik = prijava;
            if (Korisnik.Admin == 1) uiUpravljanje.Visible = true;

            OborineTimer = new Timer
            {
                Interval = this.Interval * 60 * 1000
            };
            OborineTimer.Tick += OborineTimer_Tick;
            OborineTimer.Start();
        }

        private void OborineTimer_Tick(object sender, EventArgs e)
        {
            DohvatiVrijeme();
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

        private void DohvatiVrijeme()
        {
            string tekst = NavodnjavanjeRepozitorij.DohvatiVrijeme();

            if(tekst != "")
            {
                if (MessageBox.Show("Pada kiša na:\r\n" + tekst + "Želite li pregledati i spremiti zapise?", "It's raining!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    TabControl tab = uiNavodnjavanje.Controls.Find("navodnjavanjeTabs", false).First() as TabControl;
                    tab.SelectedIndex = 1;

                    uiNavodnjavanje.BringToFront();
                }
            }
        }

        private void IzborDohvacanje_CheckedChanged(object sender, EventArgs e)
        {
            if (izborDohvacanje.Checked)
            {
                OborineTimer.Stop();
            }
            else OborineTimer.Start();
        }

        private void PoljoApp_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.uiZastita);
            this.Controls.Add(this.uiPovrsine);
            this.Controls.Add(this.uiProizvodi);
            this.Controls.Add(this.uiNavodnjavanje);
            this.Controls.Add(this.uiPrskanje);
            this.Controls.Add(this.uiSadnja);

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            uiProizvodi.BringToFront();
        }
    }
}

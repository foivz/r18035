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
    /// <summary>
    /// Glavna forma pomoću koje se koriste ostale funkcionalnosti
    /// </summary>
    public partial class PoljoApp : Form
    {
        private DataLayer.Djelatnik Korisnik;
        private Timer OborineTimer;
        private int Interval = 10;

        /// <summary>
        /// Bilježi prijavljenog korisnika i pokreće timer za dohvaćanje vremena
        /// </summary>
        /// <param name="prijava"></param>
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

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(PoljoApp_KeyDown);
        }

        /// <summary>
        /// Svakih 10 minuta se dohvaćaju podaci o vremenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OborineTimer_Tick(object sender, EventArgs e)
        {
            DohvatiVrijeme();
        }
        /// <summary>
        /// Otvara kontrolu za CRUD operacije nad sadnjama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOpenSadnja_Click(object sender, EventArgs e)
        {
            uiSadnja.BringToFront();
        }
        /// <summary>
        /// Otvara kontrolu za CRUD operacije nad površinama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Zatvara glavni prozor i otvara formu za prijavu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrijavaForma prijava = new PrijavaForma();
            prijava.FormClosed += (s,args) => this.Close();
            prijava.ShowDialog();
        }

        /// <summary>
        /// Administratoru omogućuje otvaranje forme za CRUD operacije nad djelatnicima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiUpravljanje_Click(object sender, EventArgs e)
        {
            Admin.DjelatniciForma pregledDjelatnika = new Admin.DjelatniciForma();
            pregledDjelatnika.ShowDialog();
        }

        /// <summary>
        /// Obaviještava korisnika gdje trenutno pada kiša
        /// </summary>
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

        /// <summary>
        /// Pokreće ili zaustavlja timer omoću kojeg se dohvaća vrijeme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IzborDohvacanje_CheckedChanged(object sender, EventArgs e)
        {
            if (izborDohvacanje.Checked)
            {
                OborineTimer.Stop();
            }
            else OborineTimer.Start();
        }

        /// <summary>
        /// Dodaje kontrole na formu i maksimizira prikaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Provjerava da li je pritisnuta tipka F1 pa na trenutno aktivnoj kontroli otvara pomoć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PoljoApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (Controls.GetChildIndex(uiProizvodi) == 0)
                {
                    uiProizvodi.OtvoriPomoc();
                    e.Handled = true;
                }
                if (Controls.GetChildIndex(uiZastita) == 0)
                {
                    uiZastita.OtvoriPomoc();
                    e.Handled = true;
                }
                if (Controls.GetChildIndex(uiPovrsine) == 0)
                {
                    uiPovrsine.OtvoriPomoc();
                    e.Handled = true;
                }
                if (Controls.GetChildIndex(uiPrskanje) == 0)
                {
                    uiPrskanje.OtvoriPomoc();
                    e.Handled = true;
                }
                if (Controls.GetChildIndex(uiSadnja) == 0)
                {
                    uiSadnja.OtvoriPomoc();
                    e.Handled = true;
                }
                if (Controls.GetChildIndex(uiNavodnjavanje) == 0)
                {
                    uiNavodnjavanje.OtvoriPomoc();
                    e.Handled = true;
                }
            }
        }
    }
}

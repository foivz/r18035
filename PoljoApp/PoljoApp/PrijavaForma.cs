using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Net.NetworkInformation;

namespace PoljoAppVerzija2
{
    /// <summary>
    /// Svojim metodama omogućuje prijavu korisnika u aplikaciju
    /// </summary>
    public partial class PrijavaForma : Form
    {
        public PrijavaForma()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dohvaća ulazne vrijednosti za prijavu te ju izvršava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionPrijava_Click(object sender, EventArgs e)
        {
            string email = unosEmail.Text;
            string lozinka = unosLozinka.Text;
            try
            {
                if (email != "" && lozinka != "")
                    IzvrsiPrijavu(email, lozinka);
                else MessageBox.Show("Niste unijeli obje vrijednosti!");
            }
            catch(NemaInternetaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            
        }

        /// <summary>
        /// Zatvara formu za prijavu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Prijavljuje korisnika u aplikaciju
        /// </summary>
        /// <param name="email"></param>
        /// <param name="lozinka"></param>
        private void IzvrsiPrijavu(string email, string lozinka)
        {
            DataLayer.Djelatnik korisnik;
            string lozinkaHash = Kriptiranje.NapraviHash(lozinka);
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                throw new NemaInternetaException("Nema interneta!");
            }
            else
            {
                 korisnik=DjelatniciRepozitorij.Prijava(email, lozinkaHash);
            }
            
            if (korisnik != null)
            {
                this.Hide();
                PoljoApp app = new PoljoApp(korisnik);
                app.FormClosed += (s, args) => this.Close();
                app.ShowDialog();
            }
            else {
                MessageBox.Show("Neuspješna prijava!");
            }
        }

        /// <summary>
        /// Obaviještava korisnika o pogreškama prilikom unosa email-a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnosEmail_Leave(object sender, EventArgs e)
        {
            string uzorak = @"^[a-zA-Z0-9]{1,}\.?[a-zA-Z0-9]{0,}@[a-zA-Z0-9]{1,}\.[a-zA-Z]{2,}$";
            string email = unosEmail.Text;

            MatchCollection pogotci = Validacija.ProvjeriRegex(email, uzorak);

            if (pogotci.Count < 1)
            {
                unosEmail.BackColor = Color.Tomato;
            }
            else unosEmail.BackColor = Color.White;
        }

        /// <summary>
        /// Obaviještava korisnika prilikom unosa lozinke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnosLozinka_Leave(object sender, EventArgs e)
        {
            string uzorak = @"[a-zA-Z0-9.]{1,}";
            string lozinka = unosLozinka.Text;

            MatchCollection pogotci = Validacija.ProvjeriRegex(lozinka, uzorak);

            if (pogotci.Count < 1 || lozinka.Length < 5)
            {
                unosLozinka.BackColor = Color.Tomato;
            }
            else unosLozinka.BackColor = Color.White;
        }
        
    }
}

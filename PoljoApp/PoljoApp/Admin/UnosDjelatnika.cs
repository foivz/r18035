using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Security.Cryptography;

namespace PoljoAppVerzija2.Admin
{
    /// <summary>
    /// Služi za unos i ažuriranje podataka o djelatnicima
    /// </summary>
    public partial class UnosDjelatnika : Form
    {
        DataLayer.Djelatnik DjelatnikZaIzmjenu = null;

        /// <summary>
        /// Inicijalizira komponentu prilikom unosa novog djelatnika
        /// </summary>
        public UnosDjelatnika()
        {
            InitializeComponent();
            ispisID.Text = "ID: new";
        }

        /// <summary>
        /// Inicijalizira komponentu i postavlja početne vrijednosti kontrola prema ulaznom parametru
        /// </summary>
        /// <param name="azuriraj"></param>
        public UnosDjelatnika(DataLayer.Djelatnik azuriraj)
        {
            InitializeComponent();
            DjelatnikZaIzmjenu = azuriraj;

            unosLozinka.Enabled = false;
            vidljivostLozinke.Visible = false;
            unosEmail.Text = DjelatnikZaIzmjenu.Email;
            unosIme.Text = DjelatnikZaIzmjenu.Ime;
            unosPrezime.Text = DjelatnikZaIzmjenu.Prezime;
            unosTelefon.Text = DjelatnikZaIzmjenu.BrojTelefona;
            ispisID.Text = "ID:" + DjelatnikZaIzmjenu.Id;
        }


        /// <summary>
        /// Zatvara formu za unos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Prikazuje ili sakriva lozinku na formi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VidljivostLozinke_CheckedChanged(object sender, EventArgs e)
        {
            if (vidljivostLozinke.Checked) {
                unosLozinka.UseSystemPasswordChar = false;
            } else unosLozinka.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Ako su unesene sve vrijednosti na formi, omogućuje se gumb za spremanje 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnosDjelatnika_KeyUp(object sender, KeyEventArgs e)
        {
            if (unosEmail.Text != "" && unosLozinka.Text != "" && unosIme.Text != "" && unosPrezime.Text!="" && unosTelefon.Text != "")
            {
                uiActionSpremi.Enabled = true;
            }
        }

        /// <summary>
        /// Sprema ili ažurira zapis o djelatniku u bazi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.DjelatnikZaIzmjenu == null)
            {
                DataLayer.Djelatnik novi = new DataLayer.Djelatnik()
                {
                    Ime = unosIme.Text,
                    Prezime = unosPrezime.Text,
                    Email = unosEmail.Text,
                    Lozinka = Kriptiranje.NapraviHash(unosLozinka.Text),
                    BrojTelefona = unosTelefon.Text
                };
                
                DjelatniciRepozitorij.Spremi(novi);
                Close();
            }
            else
            {
                DjelatnikZaIzmjenu.Ime = unosIme.Text;
                DjelatnikZaIzmjenu.Prezime = unosPrezime.Text;
                DjelatnikZaIzmjenu.Email = unosEmail.Text;
                DjelatnikZaIzmjenu.Lozinka = unosLozinka.Text;
                DjelatnikZaIzmjenu.BrojTelefona = unosTelefon.Text;

                DjelatniciRepozitorij.Azuriraj(DjelatnikZaIzmjenu);
                Close();
            }
            
        }
    }
}

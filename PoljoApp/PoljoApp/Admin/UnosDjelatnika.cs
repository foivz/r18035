using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoljoAppModel;
using BusinessLayer;

namespace PoljoAppVerzija2.Admin
{
    public partial class UnosDjelatnika : Form
    {
        PoljoAppModel.Djelatnik DjelatnikZaIzmjenu = null;

        public UnosDjelatnika()
        {
            InitializeComponent();
            ispisID.Text = "ID: new";
        }

        public UnosDjelatnika(PoljoAppModel.Djelatnik azuriraj)
        {
            InitializeComponent();
            DjelatnikZaIzmjenu = azuriraj;

            unosEmail.Text = DjelatnikZaIzmjenu.Email;
            unosLozinka.Text = DjelatnikZaIzmjenu.Lozinka;
            unosIme.Text = DjelatnikZaIzmjenu.Ime;
            unosPrezime.Text = DjelatnikZaIzmjenu.Prezime;
            unosTelefon.Text = DjelatnikZaIzmjenu.BrojTelefona;
            ispisID.Text = "ID:" + DjelatnikZaIzmjenu.Id;
        }

        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VidljivostLozinke_CheckedChanged(object sender, EventArgs e)
        {
            if (vidljivostLozinke.Checked) {
                unosLozinka.UseSystemPasswordChar = false;
            } else unosLozinka.UseSystemPasswordChar = true;
        }

        private void UnosDjelatnika_KeyUp(object sender, KeyEventArgs e)
        {
            if (unosEmail.Text != "" && unosLozinka.Text != "" && unosIme.Text != "" && unosPrezime.Text!="" && unosTelefon.Text != "")
            {
                uiActionSpremi.Enabled = true;
            }
        }

        private void UiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.DjelatnikZaIzmjenu == null)
            {
                PoljoAppModel.Djelatnik novi = new PoljoAppModel.Djelatnik()
                {
                    Ime = unosIme.Text,
                    Prezime = unosPrezime.Text,
                    Email = unosEmail.Text,
                    Lozinka = unosLozinka.Text,
                    BrojTelefona = unosTelefon.Text
                };

                DjelatniciUsluge.Spremi(novi);
                Close();
            }
            else
            {
                DjelatnikZaIzmjenu.Ime = unosIme.Text;
                DjelatnikZaIzmjenu.Prezime = unosPrezime.Text;
                DjelatnikZaIzmjenu.Email = unosEmail.Text;
                DjelatnikZaIzmjenu.Lozinka = unosLozinka.Text;
                DjelatnikZaIzmjenu.BrojTelefona = unosTelefon.Text;

                DjelatniciUsluge.Azuriraj(DjelatnikZaIzmjenu);
                Close();
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoljoAppVerzija2.Admin
{
    public partial class UnosDjelatnika : Form
    {
        djelatnik DjelatnikZaIzmjenu = null;

        public UnosDjelatnika()
        {
            InitializeComponent();
            ispisID.Text = "ID: new";
        }

        public UnosDjelatnika(djelatnik azuriraj)
        {
            InitializeComponent();
            DjelatnikZaIzmjenu = azuriraj;

            unosEmail.Text = DjelatnikZaIzmjenu.email;
            unosLozinka.Text = DjelatnikZaIzmjenu.lozinka;
            unosIme.Text = DjelatnikZaIzmjenu.ime;
            unosPrezime.Text = DjelatnikZaIzmjenu.prezime;
            unosTelefon.Text = DjelatnikZaIzmjenu.broj_telefona;
            ispisID.Text = "ID:" + DjelatnikZaIzmjenu.id;
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
                using (var db = new Entities())
                {
                    djelatnik novi = new djelatnik()
                    {
                        ime = unosIme.Text,
                        prezime = unosPrezime.Text,
                        email = unosEmail.Text,
                        lozinka = unosLozinka.Text,
                        broj_telefona = unosTelefon.Text
                    };
                    db.djelatnik.Add(novi);
                    db.SaveChanges();
                }
                Close();
            }
            else {
                using (var db = new Entities())
                {
                    db.djelatnik.Attach(DjelatnikZaIzmjenu);
                    DjelatnikZaIzmjenu.ime = unosIme.Text;
                    DjelatnikZaIzmjenu.prezime = unosPrezime.Text;
                    DjelatnikZaIzmjenu.email = unosEmail.Text;
                    DjelatnikZaIzmjenu.lozinka = unosLozinka.Text;
                    DjelatnikZaIzmjenu.broj_telefona = unosTelefon.Text;
                    db.SaveChanges();
                }
                Close();
            }
            
        }
    }
}

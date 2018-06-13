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

namespace PoljoAppVerzija2
{
    public partial class PrijavaForma : Form
    {
        public PrijavaForma()
        {
            InitializeComponent();
        }

        private void UiActionPrijava_Click(object sender, EventArgs e)
        {
            string email = unosEmail.Text;
            string lozinka = unosLozinka.Text;

            if (email != "" && lozinka != "")
                IzvrsiPrijavu(email, lozinka);
            else MessageBox.Show("Niste unijeli obje vrijednosti!");
        }

        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IzvrsiPrijavu(string email, string lozinka)
        {
            using (var db = new Entities()) {
                Djelatnik korisnik = db.DjelatnikSet.Where(k => k.Email == email && k.Lozinka == lozinka).FirstOrDefault();

                if (korisnik != null) {
                    this.Hide();
                    PoljoApp app = new PoljoApp(korisnik);
                    app.FormClosed += (s, args) => this.Close();
                    app.ShowDialog();
                }
                else {
                    MessageBox.Show("Neuspješna prijava!");
                }
            }
            
        }

        private void UnosEmail_Leave(object sender, EventArgs e)
        {
            string uzorak = @"^[a-zA-Z0-9]{1,}\.?[a-zA-Z0-9]{0,}@[a-zA-Z0-9]{1,}\.[a-zA-Z]{2,}$";
            string email = unosEmail.Text;

            MatchCollection pogotci = ProvjeriRegex(email, uzorak);

            if (pogotci.Count < 1)
            {
                unosEmail.BackColor = Color.Tomato;
            }
            else unosEmail.BackColor = Color.White;
        }

        private void UnosLozinka_Leave(object sender, EventArgs e)
        {
            string uzorak = @"[a-zA-Z0-9.]{1,}";
            string lozinka = unosLozinka.Text;

            MatchCollection pogotci = ProvjeriRegex(lozinka, uzorak);

            if (pogotci.Count < 1 || lozinka.Length < 5)
            {
                unosLozinka.BackColor = Color.Tomato;
            }
            else unosLozinka.BackColor = Color.White;
        }

        private MatchCollection ProvjeriRegex(string tekst, string uzorak)
        {
            MatchCollection pogotci;

            Regex regex = new Regex(uzorak);
            pogotci = regex.Matches(tekst);

            return pogotci;
        }
    }
}

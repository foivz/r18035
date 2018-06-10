using System;
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
    public partial class UnosPrskanja : Form
    {
        prskanje PrskanjeZaIzmjenu = null;

        public UnosPrskanja()
        {
            InitializeComponent();
            DohvatiPovrsine();
            DohvatiZastitu();
            DohvatiDjelatnike();
        }

        public UnosPrskanja(prskanje prskanje)
        {
            InitializeComponent();

            DohvatiPovrsine();
            DohvatiZastitu();
            DohvatiDjelatnike();

            PrskanjeZaIzmjenu = prskanje;

            izborDatum.Text = PrskanjeZaIzmjenu.datum.ToString();
            unosOpis.Text = PrskanjeZaIzmjenu.opis;
            izborDjelatnik.SelectedValue = PrskanjeZaIzmjenu.id_djelatnik;
            izborPovrsine.SelectedValue = PrskanjeZaIzmjenu.id_povrsina;
            izborZastita.SelectedValue = PrskanjeZaIzmjenu.id_zastita;
        }

        private void DohvatiPovrsine()
        {
            BindingList<polj_povrsina> listaPovrsina = null;
            using (var db = new Entities())
            {
                listaPovrsina = new BindingList<polj_povrsina>(db.polj_povrsina.ToList());
            }
            poljpovrsinaBindingSource.DataSource = listaPovrsina;
        }

        private void DohvatiZastitu()
        {
            BindingList<zastita> listaZastite = null;
            using (var db = new Entities())
            {
                listaZastite = new BindingList<zastita>(db.zastita.ToList());
            }
            zastitaBindingSource.DataSource = listaZastite;
        }

        private void DohvatiDjelatnike()
        {
            BindingList<djelatnik> listaDjelatnika = null;
            using (var db = new Entities())
            {
                listaDjelatnika = new BindingList<djelatnik>(db.djelatnik.ToList());
            }
            djelatnikBindingSource.DataSource = listaDjelatnika;
        }

        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UnosPrskanja_KeyUp(object sender, KeyEventArgs e)
        {
            if (unosOpis.Text != "")
            {
                uiActionSpremi.Enabled = true;
            }
            else uiActionSpremi.Enabled = false;
        }

        private void UiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.PrskanjeZaIzmjenu == null)
            {
                using (var db = new Entities())
                {
                    prskanje novo = new prskanje()
                    {
                        id_djelatnik = (int)izborDjelatnik.SelectedValue,
                        id_povrsina = (int)izborPovrsine.SelectedValue,
                        id_zastita = (int)izborZastita.SelectedValue,
                        datum = izborDatum.Value,
                        opis = unosOpis.Text
                    };
                    db.prskanje.Add(novo);
                    db.SaveChanges();
                }
                Close();
            }
            else
            {
                using (var db = new Entities())
                {
                    db.prskanje.Attach(PrskanjeZaIzmjenu);
                    PrskanjeZaIzmjenu.id_djelatnik = (int) izborDjelatnik.SelectedValue;
                    PrskanjeZaIzmjenu.id_zastita = (int) izborZastita.SelectedValue;
                    PrskanjeZaIzmjenu.id_povrsina = (int) izborPovrsine.SelectedValue;
                    PrskanjeZaIzmjenu.datum = izborDatum.Value;
                    PrskanjeZaIzmjenu.opis = unosOpis.Text;

                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}

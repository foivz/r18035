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
        Prskanje PrskanjeZaIzmjenu = null;

        public UnosPrskanja()
        {
            InitializeComponent();
            DohvatiPovrsine();
            DohvatiZastitu();
            DohvatiDjelatnike();
        }

        public UnosPrskanja(Prskanje prskanje)
        {
            InitializeComponent();

            DohvatiPovrsine();
            DohvatiZastitu();
            DohvatiDjelatnike();

            PrskanjeZaIzmjenu = prskanje;

            izborDatum.Text = PrskanjeZaIzmjenu.Datum.ToString();
            unosOpis.Text = PrskanjeZaIzmjenu.Opis;
            izborDjelatnik.SelectedValue = PrskanjeZaIzmjenu.IdDjelatnik;
            izborPovrsine.SelectedValue = PrskanjeZaIzmjenu.IdPovrsina;
            izborZastita.SelectedValue = PrskanjeZaIzmjenu.IdZastita;
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
            BindingList<Djelatnik> listaDjelatnika = null;
            using (var db = new Entities())
            {
                listaDjelatnika = new BindingList<Djelatnik>(db.DjelatnikSet.ToList());
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
                    Prskanje novo = new Prskanje()
                    {
                        IdDjelatnik = (int)izborDjelatnik.SelectedValue,
                        IdPovrsina = (int)izborPovrsine.SelectedValue,
                        IdZastita = (int)izborZastita.SelectedValue,
                        Datum = izborDatum.Value,
                        Opis = unosOpis.Text
                    };
                    db.PrskanjeSet.Add(novo);
                    db.SaveChanges();
                }
                Close();
            }
            else
            {
                using (var db = new Entities())
                {
                    db.PrskanjeSet.Attach(PrskanjeZaIzmjenu);
                    PrskanjeZaIzmjenu.IdDjelatnik = (int) izborDjelatnik.SelectedValue;
                    PrskanjeZaIzmjenu.IdZastita = (int) izborZastita.SelectedValue;
                    PrskanjeZaIzmjenu.IdPovrsina = (int) izborPovrsine.SelectedValue;
                    PrskanjeZaIzmjenu.Datum = izborDatum.Value;
                    PrskanjeZaIzmjenu.Opis = unosOpis.Text;

                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}

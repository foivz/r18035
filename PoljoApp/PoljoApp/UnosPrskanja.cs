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

namespace PoljoAppVerzija2
{
    public partial class UnosPrskanja : Form
    {
        DataLayer.Prskanje PrskanjeZaIzmjenu = null;

        public UnosPrskanja()
        {
            InitializeComponent();
            DohvatiPovrsine();
            DohvatiZastitu();
            DohvatiDjelatnike();
        }

        public UnosPrskanja(DataLayer.Prskanje prskanje)
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
            BindingList<PoljPovrsina> listaPovrsina = null;
            using (var db = new PoljoAppEntities())
            {
                listaPovrsina = new BindingList<PoljPovrsina>(db.polj_povrsina.ToList());
            }
            poljpovrsinaBindingSource.DataSource = listaPovrsina;
        }

        private void DohvatiZastitu()
        {
            BindingList<zastita> listaZastite = null;
            using (var db = new PoljoAppEntities())
            {
                listaZastite = new BindingList<zastita>(db.zastita.ToList());
            }
            zastitaBindingSource.DataSource = listaZastite;
        }

        private void DohvatiDjelatnike()
        {
            BindingList<Djelatnik> listaDjelatnika = null;
            using (var db = new PoljoAppEntities())
            {
                listaDjelatnika = new BindingList<Djelatnik>(db.Djelatnik.ToList());
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
                DataLayer.Prskanje novo = new DataLayer.Prskanje()
                {
                    IdDjelatnik = (int)izborDjelatnik.SelectedValue,
                    IdPovrsina = (int)izborPovrsine.SelectedValue,
                    IdZastita = (int)izborZastita.SelectedValue,
                    Datum = izborDatum.Value,
                    Opis = unosOpis.Text
                };

                PrskanjeRepozitorij.Spremi(novo);
                Close();
            }
            else
            {
                PrskanjeZaIzmjenu.IdDjelatnik = (int) izborDjelatnik.SelectedValue;
                PrskanjeZaIzmjenu.IdZastita = (int) izborZastita.SelectedValue;
                PrskanjeZaIzmjenu.IdPovrsina = (int) izborPovrsine.SelectedValue;
                PrskanjeZaIzmjenu.Datum = izborDatum.Value;
                PrskanjeZaIzmjenu.Opis = unosOpis.Text;

                PrskanjeRepozitorij.Azuriraj(PrskanjeZaIzmjenu);
                Close();
            }
        }
    }
}

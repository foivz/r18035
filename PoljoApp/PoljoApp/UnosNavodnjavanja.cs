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
    public partial class UnosNavodnjavanja : Form
    {
        Navodnjavanje NavodnjavanjeZaIzmjenu = null;

        public UnosNavodnjavanja()
        {
            InitializeComponent();

            DohvatiPovrsine();
            DohvatiStanja();
        }

        public UnosNavodnjavanja(Navodnjavanje zaIzmjenu)
        {
            InitializeComponent();
            this.NavodnjavanjeZaIzmjenu = zaIzmjenu;

            DohvatiPovrsine();
            DohvatiStanja();

            izborDatum.Text = NavodnjavanjeZaIzmjenu.Datum.ToString();
            izborPovrsine.SelectedValue = NavodnjavanjeZaIzmjenu.IdPovrsina;
            izborVrsta.SelectedValue = NavodnjavanjeZaIzmjenu.IdStanja <= 2 ? NavodnjavanjeZaIzmjenu.IdStanja : 2;
            unosKolicinaVode.Text = NavodnjavanjeZaIzmjenu.KolicinaVode.ToString();
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

        private void DohvatiStanja()
        {
            BindingList<StanjeNavodnjavanja> listaStanja= null;
            using (var db = new Entities())
            {
                listaStanja = new BindingList<StanjeNavodnjavanja>(db.StanjeNavodnjavanja.Take(2).ToList());
            }
            stanjeNavodnjavanjaBindingSource.DataSource = listaStanja;
        }

        private void UnosNavodnjavanja_KeyUp(object sender, KeyEventArgs e)
        {
            if (unosKolicinaVode.Text != "")
                uiActionSpremi.Enabled = true;
            else uiActionSpremi.Enabled = false;
        }

        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.NavodnjavanjeZaIzmjenu == null)
            {
                using (var db = new Entities())
                {
                    Navodnjavanje novo = new Navodnjavanje()
                    {
                        IdPovrsina = (int)izborPovrsine.SelectedValue,
                        Datum = izborDatum.Value,
                        KolicinaVode = int.Parse(unosKolicinaVode.Text),
                        IdStanja = (int)izborVrsta.SelectedValue
                    };
                    db.NavodnjavanjeSet.Add(novo);
                    db.SaveChanges();
                }
                Close();
            }
            else
            {
                using (var db = new Entities())
                {
                    db.NavodnjavanjeSet.Attach(NavodnjavanjeZaIzmjenu);
                    NavodnjavanjeZaIzmjenu.IdPovrsina = (int)izborPovrsine.SelectedValue;
                    NavodnjavanjeZaIzmjenu.Datum = izborDatum.Value;
                    NavodnjavanjeZaIzmjenu.KolicinaVode = decimal.Parse(unosKolicinaVode.Text);
                    NavodnjavanjeZaIzmjenu.IdStanja = (int)izborVrsta.SelectedValue;

                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}

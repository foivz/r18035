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
        navodnjavanje NavodnjavanjeZaIzmjenu = null;

        public UnosNavodnjavanja()
        {
            InitializeComponent();

            DohvatiPovrsine();
            DohvatiStanja();
        }

        public UnosNavodnjavanja(navodnjavanje zaIzmjenu)
        {
            InitializeComponent();
            this.NavodnjavanjeZaIzmjenu = zaIzmjenu;

            DohvatiPovrsine();
            DohvatiStanja();

            izborDatum.Text = NavodnjavanjeZaIzmjenu.datum.ToString();
            izborPovrsine.SelectedValue = NavodnjavanjeZaIzmjenu.id_povrsina;
            izborVrsta.SelectedValue = NavodnjavanjeZaIzmjenu.id_stanja;
            unosKolicinaVode.Text = NavodnjavanjeZaIzmjenu.kolicina_vode_litri.ToString();
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
            BindingList<stanje_navodnjavanja> listaStanja= null;
            using (var db = new Entities())
            {
                listaStanja = new BindingList<stanje_navodnjavanja>(db.stanje_navodnjavanja.Take(2).ToList());
            }
            stanjenavodnjavanjaBindingSource.DataSource = listaStanja;
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
                    navodnjavanje novo = new navodnjavanje()
                    {
                        id_povrsina = (int)izborPovrsine.SelectedValue,
                        datum = izborDatum.Value,
                        kolicina_vode_litri = int.Parse(unosKolicinaVode.Text),
                        id_stanja = (int)izborVrsta.SelectedValue
                    };
                    db.navodnjavanje.Add(novo);
                    db.SaveChanges();
                }
                Close();
            }
            else
            {
                using (var db = new Entities())
                {
                    db.navodnjavanje.Attach(NavodnjavanjeZaIzmjenu);
                    NavodnjavanjeZaIzmjenu.id_povrsina = (int)izborPovrsine.SelectedValue;
                    NavodnjavanjeZaIzmjenu.datum = izborDatum.Value;
                    NavodnjavanjeZaIzmjenu.kolicina_vode_litri = decimal.Parse(unosKolicinaVode.Text);
                    NavodnjavanjeZaIzmjenu.id_stanja = (int)izborVrsta.SelectedValue;

                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}

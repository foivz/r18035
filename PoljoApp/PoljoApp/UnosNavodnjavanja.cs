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
    public partial class UnosNavodnjavanja : Form
    {
        DataLayer.Navodnjavanje NavodnjavanjeZaIzmjenu = null;

        public UnosNavodnjavanja()
        {
            InitializeComponent();

            DohvatiPovrsine();
            DohvatiStanja();
        }

        public UnosNavodnjavanja(DataLayer.Navodnjavanje zaIzmjenu)
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
            BindingList<PoljPovrsina> listaPovrsina = null;
            using (var db = new PoljoAppEntities())
            {
                listaPovrsina = new BindingList<PoljPovrsina>(db.polj_povrsina.ToList());
            }
            poljpovrsinaBindingSource.DataSource = listaPovrsina;
        }

        private void DohvatiStanja()
        {
            BindingList<StanjeNavodnjavanja> listaStanja= null;
            using (var db = new PoljoAppEntities())
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
                DataLayer.Navodnjavanje novo = new DataLayer.Navodnjavanje()
                {
                    IdPovrsina = (int)izborPovrsine.SelectedValue,
                    Datum = izborDatum.Value,
                    KolicinaVode = int.Parse(unosKolicinaVode.Text),
                    IdStanja = (int)izborVrsta.SelectedValue
                };
                NavodnjavanjeRepozitorij.Spremi(novo);
                Close();
            }
            else
            {                
                NavodnjavanjeZaIzmjenu.IdPovrsina = (int)izborPovrsine.SelectedValue;
                NavodnjavanjeZaIzmjenu.Datum = izborDatum.Value;
                NavodnjavanjeZaIzmjenu.KolicinaVode = decimal.Parse(unosKolicinaVode.Text);
                NavodnjavanjeZaIzmjenu.IdStanja = (int)izborVrsta.SelectedValue;

                NavodnjavanjeRepozitorij.Azuriraj(NavodnjavanjeZaIzmjenu); 
                
                Close();
            }
        }
    }
}

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
    /// <summary>
    /// Omogućuje unos i ažuriranje podataka o prskanju
    /// </summary>
    public partial class UnosNavodnjavanja : Form
    {
        DataLayer.Navodnjavanje NavodnjavanjeZaIzmjenu = null;

        /// <summary>
        /// Inicijalizira komponentu i dohvaća početne podatke
        /// </summary>
        public UnosNavodnjavanja()
        {
            InitializeComponent();

            DohvatiPovrsine();
            DohvatiStanja();
        }

        /// <summary>
        /// Inicijalizira komponentu i postavlja početne vrijednosti kontrola prema ulaznom parametru
        /// </summary>
        /// <param name="zaIzmjenu">Zapis tipa Navodnjavanje</param>
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

        /// <summary>
        /// Puni combobox poljoprivrednim površinama
        /// </summary>
        private void DohvatiPovrsine()
        {
            BindingList<PoljPovrsina> listaPovrsina = null;
            using (var db = new PoljoAppEntities())
            {
                listaPovrsina = new BindingList<PoljPovrsina>(db.polj_povrsina.ToList());
            }
            poljpovrsinaBindingSource.DataSource = listaPovrsina;
        }

        /// <summary>
        /// Puni combobox stanjima navodnjavanja
        /// </summary>
        private void DohvatiStanja()
        {
            BindingList<StanjeNavodnjavanja> listaStanja= null;
            using (var db = new PoljoAppEntities())
            {
                listaStanja = new BindingList<StanjeNavodnjavanja>(db.StanjeNavodnjavanja.Take(2).ToList());
            }
            stanjeNavodnjavanjaBindingSource.DataSource = listaStanja;
        }

        /// <summary>
        /// Omogućuje gumb za spremanje ako su svi podaci na formi ispunjeni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnosNavodnjavanja_KeyUp(object sender, KeyEventArgs e)
        {
            if (unosKolicinaVode.Text != "")
                uiActionSpremi.Enabled = true;
            else uiActionSpremi.Enabled = false;
        }
        /// <summary>
        /// Zatvara formu za unos prskanja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Sprema i ažurira podatke o prskanju u bazi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.NavodnjavanjeZaIzmjenu == null && Validiraj())
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
            else if (this.NavodnjavanjeZaIzmjenu != null && Validiraj())
            {
                NavodnjavanjeZaIzmjenu.IdPovrsina = (int)izborPovrsine.SelectedValue;
                NavodnjavanjeZaIzmjenu.Datum = izborDatum.Value;
                NavodnjavanjeZaIzmjenu.KolicinaVode = decimal.Parse(unosKolicinaVode.Text);
                NavodnjavanjeZaIzmjenu.IdStanja = (int)izborVrsta.SelectedValue;

                NavodnjavanjeRepozitorij.Azuriraj(NavodnjavanjeZaIzmjenu);

                Close();
            }
            else MessageBox.Show("Uneseni podaci nisu ispravni! Pokušajte ponovno i odaberite jednu od ponuđenih vrijednosti.",
                                   "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool Validiraj()
        {
            if (double.TryParse(unosKolicinaVode.Text, out double kolicina))
                return true;
            else return false;
        }
    }
}

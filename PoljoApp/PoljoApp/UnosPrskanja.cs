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
    public partial class UnosPrskanja : Form
    {
        DataLayer.Prskanje PrskanjeZaIzmjenu = null;

        /// <summary>
        /// Inicijalizira komponentu i dohvaća početne podatke
        /// </summary>
        public UnosPrskanja()
        {
            InitializeComponent();
            DohvatiPovrsine();
            DohvatiZastitu();
            DohvatiDjelatnike();
        }
        /// <summary>
        /// Inicijalizira komponentu i postavlja početne vrijednosti ovisno o ulaznom parametru
        /// </summary>
        /// <param name="prskanje">Zapis tipa prskanje</param>
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

        /// <summary>
        /// Puni combobox podacima o površinama
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
        /// Puni combobox podacima o zaštiti
        /// </summary>
        private void DohvatiZastitu()
        {
            BindingList<zastita> listaZastite = null;
            using (var db = new PoljoAppEntities())
            {
                listaZastite = new BindingList<zastita>(db.zastita.ToList());
            }
            zastitaBindingSource.DataSource = listaZastite;
        }
        /// <summary>
        /// Puni combobox podacima o djelatnicima
        /// </summary>
        private void DohvatiDjelatnike()
        {
            BindingList<Djelatnik> listaDjelatnika = null;
            using (var db = new PoljoAppEntities())
            {
                listaDjelatnika = new BindingList<Djelatnik>(db.Djelatnik.ToList());
            }
            djelatnikBindingSource.DataSource = listaDjelatnika;
        }
        /// <summary>
        /// Zatvara formu za unos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Omogućuje gumb za spremanje ukoliko su sve vrijednosti kontrola unešene
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnosPrskanja_KeyUp(object sender, KeyEventArgs e)
        {
            if (unosOpis.Text != "")
            {
                uiActionSpremi.Enabled = true;
            }
            else uiActionSpremi.Enabled = false;
        }
        /// <summary>
        /// Sprema i ažurira zapis o prskanju u bazi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

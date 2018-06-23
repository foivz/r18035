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
    /// Forma za unos i ažuriranje podataka zaštite
    /// </summary>
    public partial class UnosZastite : Form
    {
        zastita zastitaZaIzmjenu = null;
        /// <summary>
        /// Inicijalizira formu za slučaj unosa nove zastite
        /// </summary>
        public UnosZastite()
        {
            InitializeComponent();
            PrikaziVrsteZastita();
        }
        /// <summary>
        /// Inicijalizira formu i prosljeđuje zaštitu za ažuriranje
        /// </summary>
        /// <param name="zastita"></param>
        public UnosZastite(zastita zastita)
        {
            InitializeComponent();
            PrikaziVrsteZastita();

            zastitaZaIzmjenu = zastita;
            uiUnosNaziva.Text = zastitaZaIzmjenu.naziv;
            uiUnosKoncentracije.Text = zastitaZaIzmjenu.koncentracija;
            uiActionOdabirVrste.SelectedValue = zastitaZaIzmjenu.id_vrste_zastite;
        }
        /// <summary>
        /// U slučaju unosa nove zaštite, kreira novi objekt sa unesenim podacima i šalje ga u DataLayer za spremanje u bazu,
        /// u slučaju ažuriranja zaštite mijenja podatke prosljeđene zaštite u nove unesene vrijednosti i prosljeđuje u DataLayer za ažuriranje u bazi
        /// u oba slučaja provjerava ispravnost unosa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if (this.zastitaZaIzmjenu == null)
                {
                    zastita novaZastita = new zastita()
                    {
                        naziv = uiUnosNaziva.Text,
                        koncentracija = uiUnosKoncentracije.Text,
                        id_vrste_zastite = (int)uiActionOdabirVrste.SelectedValue
                    };
                    ZastitaRepozitorij.Spremi(novaZastita);
                    this.Close();
                }
                else
                {
                    zastitaZaIzmjenu.naziv = uiUnosNaziva.Text;
                    zastitaZaIzmjenu.koncentracija = uiUnosKoncentracije.Text;
                    zastitaZaIzmjenu.id_vrste_zastite = (int)uiActionOdabirVrste.SelectedValue; Close();
                    ZastitaRepozitorij.Azuriraj(zastitaZaIzmjenu);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Uneseni podaci nisu ispravni! Pokušajte ponovno i odaberite jednu od ponuđenih vrijednosti.",
                                    "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        /// <summary>
        /// Dohvaća vrste zaštita za prikaz u comboboxu
        /// </summary>
        private void PrikaziVrsteZastita()
        {
            List<vrsta_zastite> listaVrsteZastite = ZastitaRepozitorij.DohvatiVrsteZastita();
            vrstazastiteBindingSource.DataSource = listaVrsteZastite;
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Provjerava da li se uneseni podaci podudaraju s ispravnima
        /// Duljina naziva ne smije biti manja od 2 slova, a koncentracija mora biti unesena
        /// </summary>
        /// <returns></returns>
        private bool ValidirajUnos()
        {
            string unesenaVrsta = uiActionOdabirVrste.Text;
            int unesenaKoncentracija = uiUnosKoncentracije.TextLength;
            int unesenNaziv = uiUnosNaziva.TextLength;
            bool unosVrsteValjan;
            bool unosKoncentracijeValjan;
            bool unosNazivaValjan;

            if (unesenNaziv >= 2) unosNazivaValjan = true;
            else unosNazivaValjan = false;

            if (unesenaKoncentracija >= 1) unosKoncentracijeValjan = true;
            else unosKoncentracijeValjan = false;

            switch (unesenaVrsta)
            {
                case "fungcid":
                    unosVrsteValjan = true;
                    break;
                case "gnojivo":
                    unosVrsteValjan = true;
                    break;
                case "herbicid":
                    unosVrsteValjan = true;
                    break;
                case "insektcid":
                    unosVrsteValjan = true;
                    break;
                case "pesticid":
                    unosVrsteValjan = true;
                    break;
                default: unosVrsteValjan = false;
                    break;
            }
            if (unosNazivaValjan && unosKoncentracijeValjan && unosVrsteValjan)
            {
                return true;
            }
            else return false;
        }
    }
}

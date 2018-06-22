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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionSpremi_Click(object sender, EventArgs e)
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
                zastitaZaIzmjenu.id_vrste_zastite = (int)uiActionOdabirVrste.SelectedValue;Close();
                ZastitaRepozitorij.Azuriraj(zastitaZaIzmjenu);
                this.Close();
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
    }
}

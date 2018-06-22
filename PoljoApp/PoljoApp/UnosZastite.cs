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
    public partial class UnosZastite : Form
    {
        zastita zastitaZaIzmjenu = null;
        public UnosZastite()
        {
            //Konstruktor za slučaj unosa nove zastite
            InitializeComponent();
            PrikaziVrsteZastita();
        }

        public UnosZastite(zastita zastita)
        {
            //KOnstruktor za slučaj ažuriranja zaštite
            InitializeComponent();
            PrikaziVrsteZastita();

            zastitaZaIzmjenu = zastita;
            uiUnosNaziva.Text = zastitaZaIzmjenu.naziv;
            uiUnosKoncentracije.Text = zastitaZaIzmjenu.koncentracija;
            uiActionOdabirVrste.SelectedValue = zastitaZaIzmjenu.id_vrste_zastite;
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.zastitaZaIzmjenu == null)
            {
                //Kreiramo novi objekt zaštite sa unesenim podacima i šaljemo ga u DataLayer za spremanje u bazu
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
                //Ažuriraj materijal za izmjenu s novim unesenim vrijednostima i prosljedi u DataLayer za ažuriranje objekta

                zastitaZaIzmjenu.naziv = uiUnosNaziva.Text;
                zastitaZaIzmjenu.koncentracija = uiUnosKoncentracije.Text;
                zastitaZaIzmjenu.id_vrste_zastite = (int)uiActionOdabirVrste.SelectedValue;Close();
                ZastitaRepozitorij.Azuriraj(zastitaZaIzmjenu);
                this.Close();
            }
        }

        private void PrikaziVrsteZastita()
        {
            //Prikazi vrste zastita za izbor u comboboxu
            List<vrsta_zastite> listaVrsteZastite = ZastitaRepozitorij.DohvatiVrsteZastita();
            vrstazastiteBindingSource.DataSource = listaVrsteZastite;
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

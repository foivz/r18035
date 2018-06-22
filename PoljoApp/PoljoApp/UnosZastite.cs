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
                //Dodajemo novi proizvod s unesenim podacima u bazu
                using (var db = new PoljoAppEntities())
                {
                    zastita novaZastita = new zastita()
                    {
                        naziv = uiUnosNaziva.Text,
                        koncentracija = uiUnosKoncentracije.Text,
                        id_vrste_zastite = (int)uiActionOdabirVrste.SelectedValue
                    };
                    db.zastita.Add(novaZastita);
                    db.SaveChanges();
                }
                Close();
            }
            else
            {
                //Mjenjamo podatke prenesenog objekta zastite
                using (var db = new PoljoAppEntities())
                {
                    db.zastita.Attach(zastitaZaIzmjenu);
                    zastitaZaIzmjenu.naziv = uiUnosNaziva.Text;
                    zastitaZaIzmjenu.koncentracija = uiUnosKoncentracije.Text;
                    zastitaZaIzmjenu.id_vrste_zastite = (int)uiActionOdabirVrste.SelectedValue;
                    db.SaveChanges();
                }
                Close();
            }
        }

        private void PrikaziVrsteZastita()
        {
            //Prikazi vrste zastita za izbor u comboboxu
            BindingList<vrsta_zastite> listaVrsteZastite = null;
            using (var db = new PoljoAppEntities())
            {
                listaVrsteZastite = new BindingList<vrsta_zastite>(db.vrsta_zastite.ToList());
            }
            vrstazastiteBindingSource.DataSource = listaVrsteZastite;
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

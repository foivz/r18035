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
    public partial class UnosProizvoda : Form
    {
        sadni_materijal materijalZaIzmjenu = null;
        public UnosProizvoda(sadni_materijal materijal)
        {
            //Konstruktor za slučaj izmjene proizvoda
            InitializeComponent();
            PrikaziVrsteSadnogMaterijala();
            PrikaziMjerneJedinice();

            materijalZaIzmjenu = materijal;
            uiUnosNaziva.Text = materijalZaIzmjenu.naziv;
            uiActionOdabirJednicineMjere.Text = materijalZaIzmjenu.jedinicna_mjera;
            uiActionOdabirVrste.SelectedValue = materijalZaIzmjenu.id_vrste_materijala;
        }
        public UnosProizvoda()
        {
            //Konstruktor za slučaj unosa novog proizvoda
            InitializeComponent();
            PrikaziVrsteSadnogMaterijala();
            PrikaziMjerneJedinice();
        }

        private void PrikaziVrsteSadnogMaterijala()
        {
            //Prikazi vrste sadnog materijala za izbor u comboboxu
            BindingList<vrsta_sadnog_materijala> listaVrstaSadnogMaterijala = null;
            using (var db = new Entities())
            {
                listaVrstaSadnogMaterijala = new BindingList<vrsta_sadnog_materijala>(db.vrsta_sadnog_materijala.ToList());
            }
            vrstasadnogmaterijalaBindingSource.DataSource = listaVrstaSadnogMaterijala;
        }

        private void PrikaziMjerneJedinice()
        {
            //Prikazi izbor mjernih jedinica za izbor u comboboxu
            uiActionOdabirJednicineMjere.Items.Add("Komad");
            uiActionOdabirJednicineMjere.Items.Add("Kilogram");
            uiActionOdabirJednicineMjere.Items.Add("Tona");
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.materijalZaIzmjenu == null)
            {
                //Dodajemo novi proizvod s unesenim podacima u bazu
                 using (var db = new Entities())
                {
                    sadni_materijal noviMaterijal = new sadni_materijal()
                    {
                        naziv = uiUnosNaziva.Text,
                        jedinicna_mjera = uiActionOdabirJednicineMjere.Text,
                        id_vrste_materijala = (int)uiActionOdabirVrste.SelectedValue
                };
                    db.sadni_materijal.Add(noviMaterijal);
                    db.SaveChanges();
                }
                Close();
            }
            else
            {
                //Mjenjamo podatke prenesenog objekta proizvoda
                using (var db = new Entities())
                {
                    db.sadni_materijal.Attach(materijalZaIzmjenu);
                    materijalZaIzmjenu.naziv = uiUnosNaziva.Text;
                    materijalZaIzmjenu.jedinicna_mjera = uiActionOdabirJednicineMjere.Text;
                    materijalZaIzmjenu.id_vrste_materijala = (int)uiActionOdabirVrste.SelectedValue;
                    db.SaveChanges();
                }
                Close();
            }
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class UnosProizvoda : Form
    {
        SadniMaterijal materijalZaIzmjenu = null;
        public UnosProizvoda(SadniMaterijal materijal)
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
            List<VrstaSadnogMaterijala> listaVrstaSadnogMaterijala = ProizvodiRepozitorij.DohvatiVrsteSadnogMaterijala();
            vrstasadnogmaterijalaBindingSource.DataSource = listaVrstaSadnogMaterijala;
             
        }

        private void PrikaziMjerneJedinice()
        {
            //Prikazi izbor mjernih jedinica za izbor u comboboxu
            uiActionOdabirJednicineMjere.Items.Add("Komad");
            uiActionOdabirJednicineMjere.Items.Add("Kilogram");
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.materijalZaIzmjenu == null)
            {
                //Kreirajnovi objekt sadnog materijala i prosljedi u DataLayer za spremanje novog objekta
                    SadniMaterijal noviMaterijal = new SadniMaterijal()
                    {
                        naziv = uiUnosNaziva.Text,
                        jedinicna_mjera = uiActionOdabirJednicineMjere.Text,
                        id_vrste_materijala = (int)uiActionOdabirVrste.SelectedValue
                    };
                    ProizvodiRepozitorij.Spremi(noviMaterijal);
                    Close();
            }
            else
            {
                //Ažuriraj materijal za izmjenu s novim unesenim vrijednostima i prosljedi u DataLayer za ažuriranje objekta
               
                materijalZaIzmjenu.naziv = uiUnosNaziva.Text;
                materijalZaIzmjenu.jedinicna_mjera = uiActionOdabirJednicineMjere.Text;
                materijalZaIzmjenu.id_vrste_materijala = (int)uiActionOdabirVrste.SelectedValue;
                ProizvodiRepozitorij.Azuriraj(materijalZaIzmjenu);
                Close();
            }
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

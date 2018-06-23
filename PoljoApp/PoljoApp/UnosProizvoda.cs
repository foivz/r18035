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
    /// Forma za unos i ažuriranje podataka proizvoda
    /// </summary>
    public partial class UnosProizvoda : Form
    {
        SadniMaterijal materijalZaIzmjenu = null;
        /// <summary>
        /// Inicijalizira formu UnosProizvoda uz prosljeđeni proizvod za izmjenu
        /// </summary>
        /// <param name="materijal"></param>
        public UnosProizvoda(SadniMaterijal materijal)
        {
            InitializeComponent();
            PrikaziVrsteSadnogMaterijala();
            PrikaziMjerneJedinice();

            materijalZaIzmjenu = materijal;
            uiUnosNaziva.Text = materijalZaIzmjenu.naziv;
            uiActionOdabirJednicineMjere.Text = materijalZaIzmjenu.jedinicna_mjera;
            uiActionOdabirVrste.SelectedValue = materijalZaIzmjenu.id_vrste_materijala;
        }
        /// <summary>
        /// Otvara formu UnosProizvoda za slučaj kad se unosi novi proizvod
        /// </summary>
        public UnosProizvoda()
        {
            InitializeComponent();
            PrikaziVrsteSadnogMaterijala();
            PrikaziMjerneJedinice();
        }
        /// <summary>
        /// Prikazuje vrste sadnog materijala za izbor u comboboxu
        /// </summary>
        private void PrikaziVrsteSadnogMaterijala()
        {
            List<VrstaSadnogMaterijala> listaVrstaSadnogMaterijala = ProizvodiRepozitorij.DohvatiVrsteSadnogMaterijala();
            vrstasadnogmaterijalaBindingSource.DataSource = listaVrstaSadnogMaterijala;
             
        }
        /// <summary>
        /// Prikazuje mjerne jedinice u comboboxu
        /// </summary>
        private void PrikaziMjerneJedinice()
        {
            uiActionOdabirJednicineMjere.Items.Add("Komad");
            uiActionOdabirJednicineMjere.Items.Add("Kilogram");
        }
        /// <summary>
        /// U slučaju novog proizvoda podatke sprema u novi objekt i sprema ga u bazu,
        /// u slučaju ažuriranja proizvoda mijenja mu podatke na one unesene u formu i sprema u bazu
        /// U oba slučaja ako podaci nisu ispravni upozorava korisnika i traži ponovan unos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if (this.materijalZaIzmjenu == null)
                {
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

                    materijalZaIzmjenu.naziv = uiUnosNaziva.Text;
                    materijalZaIzmjenu.jedinicna_mjera = uiActionOdabirJednicineMjere.Text;
                    materijalZaIzmjenu.id_vrste_materijala = (int)uiActionOdabirVrste.SelectedValue;
                    ProizvodiRepozitorij.Azuriraj(materijalZaIzmjenu);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Uneseni podaci nisu ispravni! Pokušajte ponovno i odaberite jednu od ponuđenih vrijednosti.",
                                    "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Provjerava da li se uneseni podaci podudaraju s ispravnim vrijednostima
        /// Duljina naziva ne smije biti manje od 2 slova
        /// </summary>
        /// <returns>True ako je unos ispravan</returns>
        private bool ValidirajUnos()
        {
            bool unosMjereValjan;
            bool unosVrsteValjan;
            bool unosNazivaValjan;
            string unesenaMjera = uiActionOdabirJednicineMjere.Text;
            string vrstaMaterijala = uiActionOdabirVrste.Text;
            int unesenNaziv = uiUnosNaziva.TextLength;

            if (unesenNaziv >= 2) unosNazivaValjan = true;
            else unosNazivaValjan = false;

            switch (unesenaMjera)
            {
                case "Komad":
                    unosMjereValjan = true;
                    break;
                case "Kilogram":
                    unosMjereValjan = true;
                    break;
                default:
                    unosMjereValjan = false;
                    break;
            }
            switch (vrstaMaterijala)
            {
                case "žitarice": unosVrsteValjan = true;
                    break;
                case "cvijece": unosVrsteValjan = true;
                    break;
                case "povrce": unosVrsteValjan = true;
                    break;
                case "voce": unosVrsteValjan = true;
                    break;
                default: unosVrsteValjan = false;
                    break;
            }

            if (unosVrsteValjan && unosMjereValjan && unosNazivaValjan)
            {
                return true;
            }
            else return false;
        }
    }
}

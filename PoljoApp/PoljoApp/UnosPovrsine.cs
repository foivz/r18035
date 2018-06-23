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
    /// Omogućuje unos nove poljoprivredne površine i ažuriranje postojećih površina
    /// </summary>
    public partial class UnosPovrsine : Form
    {
        DataLayer.PoljPovrsina povrsinaZaIzmjenu = null;
        /// <summary>
        /// Inicijalizira komponentu i dohvaća početne podatke za unos
        /// </summary>
        public UnosPovrsine()
        {
            InitializeComponent();
            PrikaziNamjenePovrsina();
        }
        /// <summary>
        /// Inicijalizira komponentu i dohvaća početne vrijednosti prema ulaznom parametru (odabrana površina)
        /// </summary>
        /// <param name="poljPovrsina"></param>
        public UnosPovrsine(DataLayer.PoljPovrsina poljPovrsina)
        {
            InitializeComponent();
          
            this.povrsinaZaIzmjenu = poljPovrsina;
            PrikaziNamjenePovrsina();

            uiUnosNaziva.Text = povrsinaZaIzmjenu.naziv;
            uiUnosPovrsine.Text = povrsinaZaIzmjenu.povrsina_m2.ToString();
            uiOdabirNamjene.SelectedValue = povrsinaZaIzmjenu.id_namjene;
            uiUnosKoordinateX.Text = povrsinaZaIzmjenu.x_koordinata.ToString();
            uiUnosKoordinateY.Text = povrsinaZaIzmjenu.y_koordinata.ToString();
        }
       /// <summary>
       /// Upisuje u combobox podatke o namjenama površina
       /// </summary>
        private void PrikaziNamjenePovrsina()
        {
            BindingList<NamjenaPovrsine> listaNamjenaPovrsina = null;
            using (var db = new PoljoAppEntities())
            {
                listaNamjenaPovrsina = new BindingList<NamjenaPovrsine>(db.namjena_povrsine.ToList());
            }
            namjenapovrsineBindingSource.DataSource = listaNamjenaPovrsina;
        }
        /// <summary>
        /// Sprema i ažurira podatke o površinama u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.povrsinaZaIzmjenu == null)
            {
                DataLayer.PoljPovrsina novaPoljPovrsina = new PoljPovrsina()

                {
                    naziv = uiUnosNaziva.Text,
                    povrsina_m2 = int.Parse(uiUnosPovrsine.Text),
                    id_namjene = (int)uiOdabirNamjene.SelectedValue,
                    x_koordinata = decimal.Parse(uiUnosKoordinateX.Text),
                    y_koordinata = decimal.Parse(uiUnosKoordinateY.Text)
                };
                PovrsineRepozitorij.Spremi(novaPoljPovrsina);
                Close();
                
            }
            else
            {
                povrsinaZaIzmjenu.naziv = uiUnosNaziva.Text;
                povrsinaZaIzmjenu.povrsina_m2 = decimal.Parse(uiUnosPovrsine.Text);
                povrsinaZaIzmjenu.id_namjene = (int)uiOdabirNamjene.SelectedValue;
                povrsinaZaIzmjenu.x_koordinata = decimal.Parse(uiUnosKoordinateX.Text);
                povrsinaZaIzmjenu.y_koordinata = decimal.Parse(uiUnosKoordinateY.Text);
                PovrsineRepozitorij.Ažuriraj(povrsinaZaIzmjenu);
            }
                Close();  
        }
        /// <summary>
        /// Zatvara formu za unos površine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Omogućuje gumb za spremanje ako su svi podatci na formi za unos ispunjeni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnosPovrsine_KeyUp(object sender, KeyEventArgs e)
        {
            if (uiUnosNaziva.Text != "" && uiUnosKoordinateY.Text!="" && uiUnosKoordinateX.Text!="" && uiUnosPovrsine.Text!="" )
                uiActionSpremi.Enabled = true;
            else uiActionSpremi.Enabled = false;
            
        }
    }
}

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
    /// Omogućuje unos nove sadnje i ažuriranje postojećih sadnji
    /// </summary>
    public partial class UnosSadnje : Form
    {
        DataLayer.Sadnja sadnjaZaIzmjenu= null;
        /// <summary>
        /// Inicijalizira komponentu i dohvaća početne podatke za unos
        /// </summary>
        public UnosSadnje()
        {
            InitializeComponent();
            PrikaziPoljoprivrednePovršine();
            PrikaziVrsteSadnihMaterijala();
        }
        /// <summary>
        /// Inicijalizira komponentu i dohvaća početne vrijednosti prema ulaznom parametru
        /// </summary>
        /// <param name="sadnja"></param>
        public UnosSadnje(Sadnja sadnja )
        {
            InitializeComponent();
            PrikaziPoljoprivrednePovršine();
            PrikaziVrsteSadnihMaterijala();
            this.sadnjaZaIzmjenu = sadnja;

            uiUnosKolicine.Text = sadnjaZaIzmjenu.kolicina.ToString();
            datum.Text = sadnjaZaIzmjenu.datum_sadnje.ToString();
            izborPovrsine.SelectedValue = sadnjaZaIzmjenu.id_povrsina;
            izborProizvodaZaSadnju.SelectedValue = sadnjaZaIzmjenu.id_materijal;
            
        }
        
        /// <summary>
        /// Upisuje u combobox podatke o površinama
        /// </summary>
        private void PrikaziPoljoprivrednePovršine()
        {
            BindingList<PoljPovrsina> listaPoljPovrsina = null;
            using (var db = new PoljoAppEntities())
            {
                listaPoljPovrsina = new BindingList<PoljPovrsina>(db.polj_povrsina.ToList());
            }
            poljpovrsinaBindingSource.DataSource = listaPoljPovrsina;
        }
        /// <summary>
        /// Upisuje u combobox vrste sadnog materijala
        /// </summary>
        private void PrikaziVrsteSadnihMaterijala()
        {
            BindingList<SadniMaterijal> listaSadnogMaterijala = null;
            using (var db = new PoljoAppEntities())
            {
                listaSadnogMaterijala = new BindingList<SadniMaterijal>(db.sadni_materijal.ToList());
            }
            sadnimaterijalBindingSource.DataSource = listaSadnogMaterijala;
            izborProizvodaZaSadnju.SelectedIndex = 1;
            izborProizvodaZaSadnju.SelectedIndex = 0;
            
        }
        /// <summary>
        /// Zatvara formu za unos sadnje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.sadnjaZaIzmjenu == null)
            {
                DataLayer.Sadnja novaSadnja = new Sadnja()
                {
                        kolicina = uiUnosKolicine.Text.ToString(),
                        id_materijal = (int)izborProizvodaZaSadnju.SelectedValue,
                        id_povrsina = (int)izborPovrsine.SelectedValue,
                        datum_sadnje = datum.Value
                };
                SadnjaRepozitorij.Spremi(novaSadnja);
                Close();
            }
            else
            {
                sadnjaZaIzmjenu.id_materijal = (int)izborProizvodaZaSadnju.SelectedValue;
                sadnjaZaIzmjenu.id_povrsina = (int)izborPovrsine.SelectedValue;
                sadnjaZaIzmjenu.kolicina = uiUnosKolicine.Text.ToString();
                sadnjaZaIzmjenu.datum_sadnje = datum.Value;
                SadnjaRepozitorij.Ažuriraj(sadnjaZaIzmjenu);

                Close();
            }
        }
        /// <summary>
        /// Ažurira mjernu jedinicu prema odabranom sadnom materijalu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izborProizvodaZaSadnju_SelectedIndexChanged(object sender, EventArgs e)
        {
            SadniMaterijal oznaceno = izborProizvodaZaSadnju.SelectedItem as SadniMaterijal;

            if(oznaceno!=null)uiLabelaMjernaJedinica.Text = oznaceno.jedinicna_mjera;
        }
        /// <summary>
        /// Omogućuje gumb za spremanje ako su svi podatci na formi za unos ispunjeni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnosSadnje_KeyUp(object sender, KeyEventArgs e)
        {
            if (uiUnosKolicine.Text != "")
                uiActionSpremi.Enabled = true;
            else uiActionSpremi.Enabled = false;
        }
    }
}

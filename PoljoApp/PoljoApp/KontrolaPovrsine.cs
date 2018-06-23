using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace PoljoAppVerzija2
{
    /// <summary>
    /// Omogućuje prikaz i upravljanje podatcima o površinama
    /// </summary>
    public partial class KontrolaPovrsine : UserControl
    {
        public KontrolaPovrsine()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Otvara formu za unos nove površine i osvježava tablicu PoljPovršina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiDodajPovrsinu_Click(object sender, EventArgs e)
        {
            UnosPovrsine unosPovrsine = new UnosPovrsine();
            unosPovrsine.ShowDialog();
            PrikaziPovrsine();
        }
        /// <summary>
        /// Prikazuje početne podatke na kontroli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KontrolaPovrsine_Load(object sender, EventArgs e)
        {
            DohvatiNamjenePovrsina();
            PrikaziPovrsine();
        }
        /// <summary>
        /// Prikazuje i dohvaća podatke o površinama na temelju odabrane namjene površine
        /// </summary>
        private void PrikaziPovrsine()
        {
            string namjena = izborNamjenePovrsina.Text;
            poljPovrsinaViewBindingSource.DataSource = PovrsinaRepozitorij.DohvatiPovršinu(namjena);
        }
        /// <summary>
        /// Dodaje podatke o namjeni površina iz baze u combobox i također dodaje mogućnost "Prikaži sve"
        /// </summary>
        private void DohvatiNamjenePovrsina()
        {
            
            List<NamjenaPovrsine> listaNamjena = PovrsinaRepozitorij.DohvatiNamjenePovršina();
            listaNamjena.Insert(0, new NamjenaPovrsine() { namjena = "Prikaži sve" });
            foreach(var namjenaPovrsine in listaNamjena)
            {
                izborNamjenePovrsina.Items.Add(namjenaPovrsine.namjena);
            }
            izborNamjenePovrsina.SelectedIndex = 0;
        }
        private void izborNamjenePovrsina_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziPovrsine();
        }
        /// <summary>
        /// Otvara formu za ažuriranje površine i osvježava prikaz u tablici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            DataLayer.PoljPovrsina zaIzmjenu = DohvatiOznacenuPovrsinu();
            if (zaIzmjenu != null)
            {
                UnosPovrsine forma = new UnosPovrsine(zaIzmjenu);
                forma.ShowDialog();
                PrikaziPovrsine();
            }
        }
        /// <summary>
        /// Dohvaća označenu površinu na DataGridView-u
        /// </summary>
        /// <returns></returns>
        private DataLayer.PoljPovrsina DohvatiOznacenuPovrsinu()
        {
            DataLayer.PoljPovrsinaView odabranaPovrsina = poljPovrsinaViewBindingSource.Current as DataLayer.PoljPovrsinaView;
            return PovrsinaRepozitorij.DohvatiPovrsinuPoIDu(odabranaPovrsina.id);
        }
        /// <summary>
        /// Briše odabrani proizvod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionIzbrisi_Click_1(object sender, EventArgs e)
        {
            DataLayer.PoljPovrsina zaBrisanje = DohvatiOznacenuPovrsinu(); 
            if (zaBrisanje != null)
            {
                if (MessageBox.Show("Želte li izbrisati površinu?", "Pitanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new PoljoAppEntities())
                    {
                        PovrsinaRepozitorij.Izbrisi(zaBrisanje);
                        PrikaziPovrsine();
                    }
                    
                }
            }
        }
        public void OtvoriPomoc()
        {
            tabControl1.SelectedTab = pomocTab;
        }
    }
}

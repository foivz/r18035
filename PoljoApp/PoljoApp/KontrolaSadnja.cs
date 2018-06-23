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
    /// Omogućuje prikaz i upravljanje podatcima o sadnjama
    /// </summary>
    public partial class KontrolaSadnja : UserControl
    {
        public KontrolaSadnja()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Otvara formu za unos nove sadnje i osvježava tablicu Sadnja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiDodajSadnju_Click(object sender, EventArgs e)
        {
            UnosSadnje unosSadnje = new UnosSadnje();
            unosSadnje.ShowDialog();
            PrikaziSadnju();
        }
        /// <summary>
        /// Dodaje podatke o nazivima površina iz baze u combobox i također dodaje mogućost "Prikaži sve"
        /// </summary>
        private void PrikaziPoljoprivrednePovršine()
        {
            List <PoljPovrsina> listaPoljPovrsina = SadnjaRepozitorij.DohvatiPoljPovršine();
            listaPoljPovrsina.Insert(0, new PoljPovrsina() { naziv = "Prikaži sve" });
            foreach(var povrsina in listaPoljPovrsina)
            {
                izborPoljPovrsina.Items.Add(povrsina.naziv);
            }
            izborPoljPovrsina.SelectedIndex = 0;
        }
        /// <summary>
        /// Dodaje podatke o nazivima sadnog materijala iz baze u combobox i također dodaje mogućnost "Prikaži sve"
        /// </summary>
        private void PrikaziVrsteSadnihMaterijala()
        {
            List <SadniMaterijal> listaSadnogMaterijala = SadnjaRepozitorij.DohvatiSadniMaterijal();
            listaSadnogMaterijala.Insert(0, new SadniMaterijal() { naziv = "Prikaži sve" });
            foreach(var sadniMaterijal in listaSadnogMaterijala)
            {
                izborSadnogMaterijala.Items.Add(sadniMaterijal.naziv);
            }
            izborSadnogMaterijala.SelectedIndex = 0;
        }
        /// <summary>
        /// Prikazuje i dohvaća podatke o sadnjama na temelju odabrane površine i sadnog materijala
        /// </summary>
        private void PrikaziSadnju()
        {
            string povrsina=izborPoljPovrsina.Text;
            string sadniMaterijal=izborSadnogMaterijala.Text;
            sadnjaViewBindingSource.DataSource = SadnjaRepozitorij.DohvatiSadnju(povrsina, sadniMaterijal);
        }
        /// <summary>
        /// Otvara formu za ažuriranje sadnje i osvježuje prikaz u tablici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionAzurirajSadnju_Click(object sender, EventArgs e)
        {
            DataLayer.Sadnja zaIzmjenu = DohvatiOznacenuSadnju();
            if (zaIzmjenu != null)
            {
                UnosSadnje azuriraj = new UnosSadnje(zaIzmjenu);
                azuriraj.ShowDialog();
                PrikaziSadnju();
            }
            
        }
        /// <summary>
        /// Briše odabranu sadnju iz baze podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionIzbrisiSadnju_Click(object sender, EventArgs e)
        {
            DataLayer.Sadnja zaBrisanje = DohvatiOznacenuSadnju();
            if (zaBrisanje != null)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati sadnju?", "Upozorenje!", MessageBoxButtons.YesNo) 
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db= new PoljoAppEntities())
                    {
                        SadnjaRepozitorij.Obrisi(zaBrisanje);
                        PrikaziSadnju();
                    }
                }
            }   
        }
        /// <summary>
        /// Dohvaća označenu sadnju na DataGridView-u
        /// </summary>
        /// <returns></returns>
        private Sadnja DohvatiOznacenuSadnju()
        {
            DataLayer.SadnjaView oznacenaSadnja = sadnjaViewBindingSource.Current as DataLayer.SadnjaView;
            return SadnjaRepozitorij.DohvatiSadnjuPoIdu(oznacenaSadnja.Id);
        }
        /// <summary>
        /// Prikazuje početne podatke na kontroli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KontrolaSadnja_Load(object sender, EventArgs e)
        {
            PrikaziPoljoprivrednePovršine();
            PrikaziVrsteSadnihMaterijala();
            PrikaziSadnju();
        }

        private void izborPoljPovrsina_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziSadnju();
        }

        private void izborSadnogMaterijala_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziSadnju();
        }
        /// <summary>
        /// Otvara korisničku pomoć
        /// </summary>
        public void OtvoriPomoc()
        {
            tabControl1.SelectedTab = pomocTab;
        }
    }
}

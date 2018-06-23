using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using DataLayer;

namespace PoljoAppVerzija2
{
    /// <summary>
    /// Omogućuje prikaz i upravljanje podacima o prskanju
    /// </summary>
    public partial class KontrolaPrskanje : UserControl
    {
        public KontrolaPrskanje()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Otvara formu za unos prskanja i osvježava tablicu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionNovo_Click(object sender, EventArgs e)
        {
            UnosPrskanja novo = new UnosPrskanja();
            novo.ShowDialog();
            PrikaziPrskanja();
        }

        /// <summary>
        /// Prikazuje početne podatke na kontroli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KontrolaPrskanje_Load(object sender, EventArgs e)
        {
            DohvatiGodine();
            PrikaziPrskanja();
        }

        /// <summary>
        /// Dohvaća i prikazuje podatke o prskanju ovisno o označenoj godini
        /// </summary>
        private void PrikaziPrskanja()
        {
            int godina = int.Parse(izborGodine.Text);
            prskanjeViewBindingSource.DataSource = PrskanjeRepozitorij.DohvatiPrskanje(godina);
        }

        /// <summary>
        /// Otvara formu za ažuriranje prskanja i osvježava prikaz u tablici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            DataLayer.Prskanje zaIzmjenu = DohvatiOznacenoPrskanje();

            UnosPrskanja azuriraj = new UnosPrskanja(zaIzmjenu);
            azuriraj.ShowDialog();

            PrikaziPrskanja();
        }

        /// <summary>
        /// Dohvaća označeno prskanje na DataGridView-u
        /// </summary>
        /// <returns></returns>
        private DataLayer.Prskanje DohvatiOznacenoPrskanje()
        {
            DataLayer.PrskanjeView oznaceno = prskanjeViewBindingSource.Current as DataLayer.PrskanjeView;
            return PrskanjeRepozitorij.DohvatiPoIdu(oznaceno.Id);
        }

        /// <summary>
        /// Dodaje listu godina u combobox za sortiranje
        /// </summary>
        private void DohvatiGodine()
        {
            List<int> listaGodina = PrskanjeRepozitorij.DohvatiGodine();

            foreach (var datum in listaGodina)
            {
                izborGodine.Items.Add(datum);
            }
            izborGodine.SelectedIndex = 0;
        }

        /// <summary>
        /// Otvara formu za prikaz izvještaja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionIspis_Click(object sender, EventArgs e)
        {
            PrskanjeReportForma izvjestaj = new PrskanjeReportForma(int.Parse(izborGodine.Text));
            izvjestaj.ShowDialog();
        }

        /// <summary>
        /// Briše označeno prskanje iz baze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionIzbrisi_Click(object sender, EventArgs e)
        {
            DataLayer.Prskanje zaBrisanje = DohvatiOznacenoPrskanje();

            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati prskanje?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                PrskanjeRepozitorij.Izbrisi(zaBrisanje);
            }
            PrikaziPrskanja();
        }

        public void OtvoriPomoc()
        {
            tabControl1.SelectedTab = pomocTab;
        }
    }
}

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
    /// Omogućuje prikaz i upravljanje podacima o navodnjavanju
    /// </summary>
    public partial class KontrolaNavodnjavanje : UserControl
    {
        public KontrolaNavodnjavanje()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Otvara formu za unos navodnjavanja i osvježava prikaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionNovo_Click(object sender, EventArgs e)
        {
            UnosNavodnjavanja novo = new UnosNavodnjavanja();
            novo.ShowDialog();
            PrikaziNavodnjavanje();
        }

        /// <summary>
        /// Dohvaća podatke za prikaz navodnjavanja ovisno o selektiranoj godini
        /// </summary>
        private void PrikaziNavodnjavanje()
        {
            int godina = int.Parse(izborGodine.Text);
            navodnjavanjeViewBindingSource.DataSource = NavodnjavanjeRepozitorij.DohvatiNavodnjavanje(godina);
        }

        /// <summary>
        /// Prikazuje dohvaćene oborine
        /// </summary>
        private void PrikaziOborine()
        {
            oborineBindingSource.DataSource = NavodnjavanjeRepozitorij.DohvatiOborine();
        }

        /// <summary>
        /// Briše označeno navodnjavanje iz baze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionIzbrisi_Click(object sender, EventArgs e)
        {
            DataLayer.Navodnjavanje zaBrisanje = DohvatiOznacenoNavodnjavanje(navodnjavanjeViewBindingSource);

            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati navodnjavanje?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                NavodnjavanjeRepozitorij.Izbrisi(zaBrisanje);
            }
            PrikaziNavodnjavanje();
        }

        /// <summary>
        /// Dohvaća označeno navodnjavanje na DataGridView-u
        /// </summary>
        /// <param name="bs"></param>
        /// <returns>Zapis tipa Navodnjavanje</returns>
        private DataLayer.Navodnjavanje DohvatiOznacenoNavodnjavanje(BindingSource bs)
        {
            DataLayer.NavodnjavanjeView oznaceno = bs.Current as DataLayer.NavodnjavanjeView;
            return NavodnjavanjeRepozitorij.DohvatiPoIdu(oznaceno.Id);
        }

        /// <summary>
        /// Otvara formu za ažuriranje navodnjavanje i osvježava prikaz tablice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionAzuiraj_Click(object sender, EventArgs e)
        {
            DataLayer.Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(navodnjavanjeViewBindingSource);
            UnosNavodnjavanja azuriraj = new UnosNavodnjavanja(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziNavodnjavanje();
        }

        /// <summary>
        /// Dodaje popis godina u combobox za sortiranje
        /// </summary>
        private void DohvatiGodine()
        {
            List<int> listaGodina = NavodnjavanjeRepozitorij.DohvatiGodine();

            foreach (var datum in listaGodina)
            {
                izborGodine.Items.Add(datum);
            }
            izborGodine.SelectedIndex = 0;
        }

        /// <summary>
        /// Otvara formu za prikaz statistike
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionStatistika_Click(object sender, EventArgs e)
        {
            NavodnjavanjeStatistikaForma statistikaForma = new NavodnjavanjeStatistikaForma(int.Parse(izborGodine.Text));
            statistikaForma.ShowDialog();
        }

        /// <summary>
        /// Osvježava tablicu s navodnjavanjima ovisno o označenoj godini
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IzborGodine_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziNavodnjavanje();
        }

        /// <summary>
        /// Prikazuje početne podatke na kontroli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KontrolaNavodnjavanje_Load(object sender, EventArgs e)
        {
            DohvatiGodine();
            PrikaziNavodnjavanje();
            PrikaziOborine();
        }

        /// <summary>
        /// Otvara formu za unos oborine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionUnesi_Click(object sender, EventArgs e)
        {
            DataLayer.Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(oborineBindingSource);
            UnosNavodnjavanja azuriraj = new UnosNavodnjavanja(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziNavodnjavanje();
        }

        /// <summary>
        /// Odbija zapisivanje oborine u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionOdbij_Click(object sender, EventArgs e)
        {
            DataLayer.Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(oborineBindingSource);
            NavodnjavanjeRepozitorij.OdbijOborinu(zaIzmjenu);
            PrikaziOborine();
        }

        /// <summary>
        /// Osvjeava prikaz tablica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavodnjavanjeTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziNavodnjavanje();
            PrikaziOborine();
        }
    }
}

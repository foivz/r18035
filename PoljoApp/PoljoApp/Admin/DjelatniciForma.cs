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

namespace PoljoAppVerzija2.Admin
{
    /// <summary>
    /// Služi za prikaz podataka o djelatnicima te upravljanje nad njima
    /// </summary>
    public partial class DjelatniciForma : Form
    {
        public DjelatniciForma()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Otvara formu za unos novog zaposlenika i osvježava prikaz tablice 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionUnos_Click(object sender, EventArgs e)
        {
            UnosDjelatnika unos = new UnosDjelatnika();
            unos.ShowDialog();
            PrikaziDjelatnike();
        }

        /// <summary>
        /// Dohvaća djelatnike i postavlja izvor podataka Binding Source-u
        /// </summary>
        private void PrikaziDjelatnike()
        {
            djelatnikBindingSource.DataSource = DjelatniciRepozitorij.DohvatiSve();
        }

        /// <summary>
        /// Otvara formu za ažuriranje djelatnika i osvježava prikaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            if(djelatnikBindingSource.Current != null)
            {
                UnosDjelatnika unos = new UnosDjelatnika(djelatnikBindingSource.Current as DataLayer.Djelatnik);
                unos.ShowDialog();
                PrikaziDjelatnike();
            }
        }

        /// <summary>
        /// Prikazuje djelatnike nakon učitavanja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DjelatniciForma_Load(object sender, EventArgs e)
        {
            PrikaziDjelatnike();
        }

        /// <summary>
        /// Briše označeni zapis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiActionIzbrisi_Click(object sender, EventArgs e)
        {
            DataLayer.Djelatnik zaBrisanje = djelatnikBindingSource.Current as DataLayer.Djelatnik;
            
            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati djelatnika?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DjelatniciRepozitorij.Izbrisi(zaBrisanje);
            }
        }
    }
}

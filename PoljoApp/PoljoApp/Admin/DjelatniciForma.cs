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
    public partial class DjelatniciForma : Form
    {
        public DjelatniciForma()
        {
            InitializeComponent();
        }

        private void UiActionUnos_Click(object sender, EventArgs e)
        {
            UnosDjelatnika unos = new UnosDjelatnika();
            unos.ShowDialog();
            PrikaziDjelatnike();
        }

        private void PrikaziDjelatnike()
        {
            djelatnikBindingSource.DataSource = DjelatniciRepozitorij.DohvatiSve();
        }

        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            if(djelatnikBindingSource.Current != null)
            {
                UnosDjelatnika unos = new UnosDjelatnika(djelatnikBindingSource.Current as DataLayer.Djelatnik);
                unos.ShowDialog();
                PrikaziDjelatnike();
            }
        }

        private void DjelatniciForma_Load(object sender, EventArgs e)
        {
            PrikaziDjelatnike();
        }

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

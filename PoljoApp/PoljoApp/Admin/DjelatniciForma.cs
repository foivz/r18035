using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoljoAppModel;
using BusinessLayer;

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
            djelatnikBindingSource.DataSource = DjelatniciUsluge.DohvatiSve();
        }

        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            if(djelatnikBindingSource.Current != null)
            {
                UnosDjelatnika unos = new UnosDjelatnika(djelatnikBindingSource.Current as PoljoAppModel.Djelatnik);
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
            PoljoAppModel.Djelatnik zaBrisanje = djelatnikBindingSource.Current as PoljoAppModel.Djelatnik;
            
            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati djelatnika?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DjelatniciUsluge.Izbrisi(zaBrisanje);
            }
        }
    }
}

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
    public partial class KontrolaPrskanje : UserControl
    {
        public KontrolaPrskanje()
        {
            InitializeComponent();
        }

        private void UiActionNovo_Click(object sender, EventArgs e)
        {
            UnosPrskanja novo = new UnosPrskanja();
            novo.ShowDialog();
            PrikaziPrskanja();
        }

        private void KontrolaPrskanje_Load(object sender, EventArgs e)
        {
            DohvatiGodine();
            PrikaziPrskanja();
        }

        private void PrikaziPrskanja()
        {
            int godina = int.Parse(izborGodine.Text);
            prskanjeViewBindingSource.DataSource = PrskanjeRepozitorij.DohvatiPrskanje(godina);
        }

        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            DataLayer.Prskanje zaIzmjenu = DohvatiOznacenoPrskanje();

            UnosPrskanja azuriraj = new UnosPrskanja(zaIzmjenu);
            azuriraj.ShowDialog();

            PrikaziPrskanja();
        }

        private DataLayer.Prskanje DohvatiOznacenoPrskanje()
        {
            DataLayer.PrskanjeView oznaceno = prskanjeViewBindingSource.Current as DataLayer.PrskanjeView;
            return PrskanjeRepozitorij.DohvatiPoIdu(oznaceno.Id);
        }

        private void DohvatiGodine()
        {
            List<int> listaGodina = PrskanjeRepozitorij.DohvatiGodine();

            foreach (var datum in listaGodina)
            {
                izborGodine.Items.Add(datum);
            }
            izborGodine.SelectedIndex = 0;
        }

        private void UiActionIspis_Click(object sender, EventArgs e)
        {
            PrskanjeReportForma izvjestaj = new PrskanjeReportForma(int.Parse(izborGodine.Text));
            izvjestaj.ShowDialog();
        }

        private void UiActionIzbrisi_Click(object sender, EventArgs e)
        {
            DataLayer.Prskanje zaBrisanje = DohvatiOznacenoPrskanje();

            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati prskanje?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                PrskanjeRepozitorij.Izbrisi(zaBrisanje);
            }
            PrikaziPrskanja();
        }
    }
}

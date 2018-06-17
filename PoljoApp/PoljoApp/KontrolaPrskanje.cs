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
using PoljoAppModel;
using BusinessLayer;

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
            prskanjeViewBindingSource.DataSource = PrskanjeUsluge.DohvatiSve(godina);
        }

        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            PoljoAppModel.Prskanje zaIzmjenu = DohvatiOznacenoPrskanje();

            UnosPrskanja azuriraj = new UnosPrskanja(zaIzmjenu);
            azuriraj.ShowDialog();

            PrikaziPrskanja();
        }

        private PoljoAppModel.Prskanje DohvatiOznacenoPrskanje()
        {
            PoljoAppModel.PrskanjeView oznaceno = prskanjeViewBindingSource.Current as PoljoAppModel.PrskanjeView;
            return PrskanjeUsluge.DohvatiPoIdu(oznaceno.Id);
        }

        private void DohvatiGodine()
        {
            List<int> listaGodina = PrskanjeUsluge.DohvatiGodine();

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
            PoljoAppModel.Prskanje zaBrisanje = DohvatiOznacenoPrskanje();

            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati prskanje?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                PrskanjeUsluge.Izbrisi(zaBrisanje);
            }
            PrikaziPrskanja();
        }
    }
}

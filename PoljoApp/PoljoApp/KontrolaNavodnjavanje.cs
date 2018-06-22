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
    public partial class KontrolaNavodnjavanje : UserControl
    {
        public KontrolaNavodnjavanje()
        {
            InitializeComponent();
        }

        private void UiActionNovo_Click(object sender, EventArgs e)
        {
            UnosNavodnjavanja novo = new UnosNavodnjavanja();
            novo.ShowDialog();
            PrikaziNavodnjavanje();
        }

        private void PrikaziNavodnjavanje()
        {
            int godina = int.Parse(izborGodine.Text);
            navodnjavanjeViewBindingSource.DataSource = NavodnjavanjeRepozitorij.DohvatiNavodnjavanje(godina);
        }

        private void PrikaziOborine()
        {
            oborineBindingSource.DataSource = NavodnjavanjeRepozitorij.DohvatiOborine();
        }

        private void UiActionIzbrisi_Click(object sender, EventArgs e)
        {
            DataLayer.Navodnjavanje zaBrisanje = DohvatiOznacenoNavodnjavanje(navodnjavanjeViewBindingSource);

            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati navodnjavanje?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                NavodnjavanjeRepozitorij.Izbrisi(zaBrisanje);
            }
            PrikaziNavodnjavanje();
        }

        private DataLayer.Navodnjavanje DohvatiOznacenoNavodnjavanje(BindingSource bs)
        {
            DataLayer.NavodnjavanjeView oznaceno = bs.Current as DataLayer.NavodnjavanjeView;
            return NavodnjavanjeRepozitorij.DohvatiPoIdu(oznaceno.Id);
        }

        private void UiActionAzuiraj_Click(object sender, EventArgs e)
        {
            DataLayer.Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(navodnjavanjeViewBindingSource);
            UnosNavodnjavanja azuriraj = new UnosNavodnjavanja(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziNavodnjavanje();
        }

        private void DohvatiGodine()
        {
            List<int> listaGodina = NavodnjavanjeRepozitorij.DohvatiGodine();

            foreach (var datum in listaGodina)
            {
                izborGodine.Items.Add(datum);
            }
            izborGodine.SelectedIndex = 0;
        }

        private void UiActionStatistika_Click(object sender, EventArgs e)
        {
            NavodnjavanjeStatistikaForma statistikaForma = new NavodnjavanjeStatistikaForma(int.Parse(izborGodine.Text));
            statistikaForma.ShowDialog();
        }

        private void IzborGodine_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziNavodnjavanje();
        }

        private void KontrolaNavodnjavanje_Load(object sender, EventArgs e)
        {
            DohvatiGodine();
            PrikaziNavodnjavanje();
            PrikaziOborine();
        }

        private void UiActionUnesi_Click(object sender, EventArgs e)
        {
            DataLayer.Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(oborineBindingSource);
            UnosNavodnjavanja azuriraj = new UnosNavodnjavanja(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziNavodnjavanje();
        }

        private void UiActionOdbij_Click(object sender, EventArgs e)
        {
            DataLayer.Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(oborineBindingSource);
            NavodnjavanjeRepozitorij.OdbijOborinu(zaIzmjenu);
            PrikaziOborine();
        }

        private void NavodnjavanjeTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziNavodnjavanje();
            PrikaziOborine();
        }
    }
}

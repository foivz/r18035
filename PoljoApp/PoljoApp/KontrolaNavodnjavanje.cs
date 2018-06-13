using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            BindingList<NavodnjavanjeView> listaNavodnjavanja = null;
            using (var db = new Entities())
            {
                listaNavodnjavanja = new BindingList<NavodnjavanjeView>(db.NavodnjavanjeViewSet.Where(n=>n.IdStanja<3 && n.Datum.Year == godina).ToList());
            }
            navodnjavanjeViewBindingSource.DataSource = listaNavodnjavanja;
        }

        private void PrikaziOborine()
        {
            BindingList<NavodnjavanjeView> listaOborina = null;
            using (var db = new Entities())
            {
                listaOborina = new BindingList<NavodnjavanjeView>(db.NavodnjavanjeViewSet.Where(n => n.IdStanja == 3).ToList());
            }
            oborineBindingSource.DataSource = listaOborina;
        }

        private void UiActionIzbrisi_Click(object sender, EventArgs e)
        {
            Navodnjavanje zaBrisanje = DohvatiOznacenoNavodnjavanje(navodnjavanjeViewBindingSource);

            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati navodnjavanje?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new Entities())
                {
                    db.NavodnjavanjeSet.Attach(zaBrisanje);
                    db.NavodnjavanjeSet.Remove(zaBrisanje);
                    db.SaveChanges();
                }

            }
            PrikaziNavodnjavanje();
        }

        private Navodnjavanje DohvatiOznacenoNavodnjavanje(BindingSource bs)
        {
            NavodnjavanjeView oznaceno = bs.Current as NavodnjavanjeView;
            Navodnjavanje zaIzmjenu;
            using (var db = new Entities())
            {
                zaIzmjenu = db.NavodnjavanjeSet.Where(n => n.Datum == oznaceno.Datum && n.IdPovrsina == oznaceno.IdPovrsina).FirstOrDefault();
            }
            return zaIzmjenu;
        }

        private void UiActionAzuiraj_Click(object sender, EventArgs e)
        {
            Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(navodnjavanjeViewBindingSource);
            UnosNavodnjavanja azuriraj = new UnosNavodnjavanja(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziNavodnjavanje();
        }

        private void DohvatiGodine()
        {
            List<int> listaGodina = null;
            using (var db = new Entities())
            {
                listaGodina = new List<int>(db.NavodnjavanjeSet.Select(p => p.Datum.Year).Distinct());
            }

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
            Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(oborineBindingSource);
            UnosNavodnjavanja azuriraj = new UnosNavodnjavanja(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziNavodnjavanje();
        }

        private void UiActionOdbij_Click(object sender, EventArgs e)
        {
            Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje(oborineBindingSource);
            using (var db = new Entities()) {
                db.NavodnjavanjeSet.Attach(zaIzmjenu);
                zaIzmjenu.IdStanja = 4;
                db.SaveChanges();
            }
            PrikaziOborine();
        }

        private void NavodnjavanjeTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziNavodnjavanje();
            PrikaziOborine();
        }
    }
}

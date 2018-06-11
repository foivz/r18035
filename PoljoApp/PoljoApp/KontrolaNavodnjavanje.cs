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

            DohvatiGodine();
            PrikaziNavodnjavanje();
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

            BindingList<navodnjavanjeView> listaNavodnjavanja = null;
            using (var db = new Entities())
            {
                listaNavodnjavanja = new BindingList<navodnjavanjeView>(db.navodnjavanjeView.Where(n=>n.id_stanja<3 && n.datum.Year == godina).ToList());
            }
            navodnjavanjeViewBindingSource.DataSource = listaNavodnjavanja;
        }

        private void UiActionIzbrisi_Click(object sender, EventArgs e)
        {
            navodnjavanje zaBrisanje = DohvatiOznacenoNavodnjavanje();

            if (MessageBox.Show("Jeste li ste sigurni da želite obrisati navodnjavanje?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new Entities())
                {
                    db.navodnjavanje.Attach(zaBrisanje);
                    db.navodnjavanje.Remove(zaBrisanje);
                    db.SaveChanges();
                }

            }
            PrikaziNavodnjavanje();
        }

        private navodnjavanje DohvatiOznacenoNavodnjavanje()
        {
            navodnjavanjeView oznaceno = navodnjavanjeViewBindingSource.Current as navodnjavanjeView;
            navodnjavanje zaIzmjenu;
            using (var db = new Entities())
            {
                zaIzmjenu = db.navodnjavanje.Where(n => n.datum == oznaceno.datum && n.id_povrsina == oznaceno.id_povrsina).FirstOrDefault();
            }
            return zaIzmjenu;
        }

        private void UiActionAzuiraj_Click(object sender, EventArgs e)
        {
            navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje();
            UnosNavodnjavanja azuriraj = new UnosNavodnjavanja(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziNavodnjavanje();
        }

        private void DohvatiGodine()
        {
            List<int> listaGodina = null;
            using (var db = new Entities())
            {
                listaGodina = new List<int>(db.navodnjavanje.Select(p => p.datum.Year).Distinct());
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
    }
}

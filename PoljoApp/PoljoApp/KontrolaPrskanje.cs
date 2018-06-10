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

namespace PoljoAppVerzija2
{
    public partial class KontrolaPrskanje : UserControl
    {
        public KontrolaPrskanje()
        {
            InitializeComponent();
            DohvatiGodine();
        }

        private void UiActionNovo_Click(object sender, EventArgs e)
        {
            UnosPrskanja novo = new UnosPrskanja();
            novo.ShowDialog();
            PrikaziPrskanja();
        }

        private void KontrolaPrskanje_Load(object sender, EventArgs e)
        {
            PrikaziPrskanja();
        }

        private void PrikaziPrskanja()
        {
            int godina = int.Parse(izborGodine.Text);

            BindingList<prskanjeView> listaPrskanja = null;
            using (var db = new Entities()) {
                listaPrskanja = new BindingList<prskanjeView>(db.prskanjeView.Where(p=>p.datum.Year==godina).ToList());
            }
            prskanjeViewBindingSource.DataSource = listaPrskanja;
        }

        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            prskanjeView oznaceno = prskanjeViewBindingSource.Current as prskanjeView;
            prskanje zaIzmjenu;
            using (var db = new Entities()) {
                zaIzmjenu = db.prskanje.Where(p=>p.datum==oznaceno.datum && p.id_povrsina == oznaceno.id_povrsina && p.id_zastita==oznaceno.id_zastita).FirstOrDefault();
            }

            UnosPrskanja azuriraj = new UnosPrskanja(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziPrskanja();

        }

        private void DohvatiGodine()
        {
            List<int> listaGodina = null;
            using (var db = new Entities()) {
                listaGodina = new List<int>(db.prskanje.Select(p=>p.datum.Year).Distinct());
            }

            foreach (var datum in listaGodina)
            {
                izborGodine.Items.Add(datum);
            }
            izborGodine.SelectedIndex = 0;
        }
    }
}

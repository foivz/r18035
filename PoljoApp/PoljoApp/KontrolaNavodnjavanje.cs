﻿using System;
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

            BindingList<NavodnjavanjeView> listaNavodnjavanja = null;
            using (var db = new Entities())
            {
                listaNavodnjavanja = new BindingList<NavodnjavanjeView>(db.NavodnjavanjeViewSet.Where(n=>n.IdStanja<3 && n.Datum.Year == godina).ToList());
            }
            navodnjavanjeViewBindingSource.DataSource = listaNavodnjavanja;
        }

        private void UiActionIzbrisi_Click(object sender, EventArgs e)
        {
            Navodnjavanje zaBrisanje = DohvatiOznacenoNavodnjavanje();

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

        private Navodnjavanje DohvatiOznacenoNavodnjavanje()
        {
            NavodnjavanjeView oznaceno = navodnjavanjeViewBindingSource.Current as NavodnjavanjeView;
            Navodnjavanje zaIzmjenu;
            using (var db = new Entities())
            {
                zaIzmjenu = db.NavodnjavanjeSet.Where(n => n.Datum == oznaceno.Datum && n.IdPovrsina == oznaceno.IdPovrsina).FirstOrDefault();
            }
            return zaIzmjenu;
        }

        private void UiActionAzuiraj_Click(object sender, EventArgs e)
        {
            Navodnjavanje zaIzmjenu = DohvatiOznacenoNavodnjavanje();
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
    }
}

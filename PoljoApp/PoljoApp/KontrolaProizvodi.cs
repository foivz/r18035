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
    public partial class KontrolaProizvodi : UserControl
    {
        public KontrolaProizvodi()
        {
            InitializeComponent();
        }

        private void UiDodajProizvod_Click(object sender, EventArgs e)
        {
            UnosProizvoda unosProizvoda = new UnosProizvoda();
            unosProizvoda.ShowDialog();
            PrikaziSadniMaterijal();
        }

        private void KontrolaProizvodi_Load(object sender, EventArgs e)
        {
            PrikaziVrsteSadnogMaterijala();
            PrikaziSadniMaterijal();
        }

        private void PrikaziVrsteSadnogMaterijala()
        {
            //Prikazi vrste sadnog materijala u comboboxu koji sluzi za sortiranje glavnog prikaza
            BindingList<vrsta_sadnog_materijala> listaVrstaSadnogMaterijala = null;
            using (var db = new Entities())
            {
                listaVrstaSadnogMaterijala = new BindingList<vrsta_sadnog_materijala>(db.vrsta_sadnog_materijala.ToList());
            }
            listaVrstaSadnogMaterijala.Insert(0, new vrsta_sadnog_materijala() { naziv = "Prikaži sve" });
            vrstasadnogmaterijalaBindingSource.DataSource = listaVrstaSadnogMaterijala;
        }

        private void PrikaziSadniMaterijal()
        {
            //Prikazi sadni materijal čija vrsta odgovara onoj odabranoj u comboboxu
            BindingList<sadni_materijal> listaProizvoda = null;
            using (var db = new Entities())
            {
                var obj = cmbIzborVrsteSadnogMaterijala.SelectedItem as vrsta_sadnog_materijala;

                if (obj != null && obj.naziv == "Prikaži sve")
                    listaProizvoda = new BindingList<sadni_materijal>(db.sadni_materijal.ToList());

                else if (obj != null)
                {
                    db.vrsta_sadnog_materijala.Attach(obj);
                    listaProizvoda = new BindingList<sadni_materijal>(obj.sadni_materijal.ToList());
                }
            }
            sadnimaterijalBindingSource.DataSource = listaProizvoda;
        }

        private void cmbIzborVrsteSadnogMaterijala_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziSadniMaterijal();
        }

        private void uiAzurirajProizvod_Click(object sender, EventArgs e)
        {
            //Ažuriranje odabranog proizvoda
            sadni_materijal odabraniProizvod = sadnimaterijalBindingSource.Current as sadni_materijal;
            if (odabraniProizvod != null)
            {
                UnosProizvoda forma = new UnosProizvoda(odabraniProizvod);
                forma.ShowDialog();
                PrikaziSadniMaterijal();
            }
        }

        private void uiIzbrisiProizvod_Click(object sender, EventArgs e)
        {
            //Brisanje odabranog proizvoda
            sadni_materijal odabraniProizvod = sadnimaterijalBindingSource.Current as sadni_materijal;
            if (odabraniProizvod != null)
            {
                if (MessageBox.Show("Želte li izbrisati proizvod?", "Pitanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.sadni_materijal.Attach(odabraniProizvod);
                        db.sadni_materijal.Remove(odabraniProizvod);
                        db.SaveChanges();
                    }
                    PrikaziSadniMaterijal();
                }
            }
        }
    }
}

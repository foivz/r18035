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
            List<VrstaSadnogMaterijala> listaVrstaSadnogMaterijala = ProizvodiRepozitorij.DohvatiVrsteSadnogMaterijala();
            listaVrstaSadnogMaterijala.Insert(0, new VrstaSadnogMaterijala() { naziv = "Prikaži sve" });

            foreach (var vrsta in listaVrstaSadnogMaterijala)
            {
                cmbIzborVrsteSadnogMaterijala.Items.Add(vrsta.naziv);
            }
            cmbIzborVrsteSadnogMaterijala.SelectedIndex = 0;

        }
        private void PrikaziSadniMaterijal()
        {
            string odabranaVrstaSadnogMaterijala = cmbIzborVrsteSadnogMaterijala.Text;
            sadniMaterijalViewBindingSource.DataSource = ProizvodiRepozitorij.DohvatiSadniMaterijal(odabranaVrstaSadnogMaterijala);
        }

        private void cmbIzborVrsteSadnogMaterijala_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziSadniMaterijal();
        }

        private void uiAzurirajProizvod_Click(object sender, EventArgs e)
        {
            //Ažuriranje odabranog proizvoda
            SadniMaterijal odabraniProizvod = DohvatiOznaceniMaterijal();
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
            SadniMaterijal odabraniProizvod = DohvatiOznaceniMaterijal();
            if (odabraniProizvod != null)
            {
                if (MessageBox.Show("Želte li izbrisati proizvod?", "Pitanje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ProizvodiRepozitorij.Izbrisi(odabraniProizvod);
                    PrikaziSadniMaterijal();
                }
            }
        }

        private SadniMaterijal DohvatiOznaceniMaterijal()
        {
            SadniMaterijalView oznaceni = sadniMaterijalViewBindingSource.Current as SadniMaterijalView;
            return ProizvodiRepozitorij.DohvatiMaterijalPoIDu(oznaceni.id);
        }
    }
}

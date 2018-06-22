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
    /// <summary>
    /// Omogućuje prikaz i rad s podacima proizvoda
    /// </summary>
    public partial class KontrolaProizvodi : UserControl
    {
        public KontrolaProizvodi()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Otvara formu UnosProizvoda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiDodajProizvod_Click(object sender, EventArgs e)
        {
            UnosProizvoda unosProizvoda = new UnosProizvoda();
            unosProizvoda.ShowDialog();
            PrikaziSadniMaterijal();
        }
        /// <summary>
        /// Prikazuje podatke o proizvodima i vrstama proizvoda na formi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KontrolaProizvodi_Load(object sender, EventArgs e)
        {
            PrikaziVrsteSadnogMaterijala();
            PrikaziSadniMaterijal();
        }

        /// <summary>
        /// Dodaje podatke o vrstama proizvoda iz baze u combobox, uz još opciju "Prikaži sve"
        /// </summary>
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
        /// <summary>
        /// Osvježava prikaz podataka proizvoda ovisno o odabranoj vrsti proizvoda
        /// </summary>
        private void PrikaziSadniMaterijal()
        {
            string odabranaVrstaSadnogMaterijala = cmbIzborVrsteSadnogMaterijala.Text;
            sadniMaterijalViewBindingSource.DataSource = ProizvodiRepozitorij.DohvatiSadniMaterijal(odabranaVrstaSadnogMaterijala);
        }
        
        private void cmbIzborVrsteSadnogMaterijala_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziSadniMaterijal();
        }
        /// <summary>
        /// Otvara formu UnosProizvoda kojoj prosljeđuje proizvod odabran za ažuriranje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiAzurirajProizvod_Click(object sender, EventArgs e)
        {
            SadniMaterijal odabraniProizvod = DohvatiOznaceniMaterijal();
            if (odabraniProizvod != null)
            {
                UnosProizvoda forma = new UnosProizvoda(odabraniProizvod);
                forma.ShowDialog();
                PrikaziSadniMaterijal();
            }
        }
        /// <summary>
        /// Briše odabrani proizvod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiIzbrisiProizvod_Click(object sender, EventArgs e)
        {
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
        /// <summary>
        /// Dohvaća označeni proizvod pomoću ID-a
        /// </summary>
        /// <returns></returns>
        private SadniMaterijal DohvatiOznaceniMaterijal()
        {
            SadniMaterijalView oznaceni = sadniMaterijalViewBindingSource.Current as SadniMaterijalView;
            return ProizvodiRepozitorij.DohvatiMaterijalPoIDu(oznaceni.id);
        }
    }
}

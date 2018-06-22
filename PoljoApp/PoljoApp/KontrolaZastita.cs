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
    /// Omogućuje prikaz i rad s podacima zaštite
    /// </summary>
    public partial class KontrolaZastita : UserControl
    {
        public KontrolaZastita()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Otvara formu UnosZastite za dodavanje nove zaštite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionDodajZastitu_Click(object sender, EventArgs e)
        {
            UnosZastite unosZastite = new UnosZastite();
            unosZastite.ShowDialog();
            PrikaziZastite();
        }

        private void uiIzborVrsteZastite_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziZastite();
        }
        /// <summary>
        /// Dodaje podatke o vrstama zaštita iz baze u combobox, uz još opciju "Prikaži sve"
        /// </summary>
        private void PrikaziVrsteZastita()
        {
            List<vrsta_zastite> listaVrstaZastite = ZastitaRepozitorij.DohvatiVrsteZastita();
            listaVrstaZastite.Insert(0, new vrsta_zastite() { naziv = "Prikaži sve" });

            foreach (var vrsta in listaVrstaZastite)
            {
                uiIzborVrsteZastite.Items.Add(vrsta.naziv);
            }
            uiIzborVrsteZastite.SelectedIndex = 0;
        }

        private void KontrolaZastita_Load(object sender, EventArgs e)
        {
            PrikaziVrsteZastita();
            PrikaziZastite();
        }
        /// <summary>
        /// Osvježava prikaz podataka zaštita ovisno o odabranoj vrsti zaštite
        /// </summary>
        private void PrikaziZastite()
        {
            string odabranaVrsta = uiIzborVrsteZastite.Text;
            zastitaViewBindingSource.DataSource = ZastitaRepozitorij.DohvatiZastite(odabranaVrsta);
        }
        /// <summary>
        /// Otvara formu UnosZaštite kojoj prosljeđuje odabranu zaštitu za ažuriranje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            zastita odabranaZastita = DohvatiOznacenuZastitu();
            if (odabranaZastita != null)
            {
                UnosZastite unosZastite = new UnosZastite(odabranaZastita);
                unosZastite.ShowDialog();
                PrikaziZastite();
            }
            
        }
        /// <summary>
        /// Briše zaštitu odabranu na DataGridViewu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionIzbrisi_Click(object sender, EventArgs e)
        {
            zastita odabranaZastita = DohvatiOznacenuZastitu();
            if (odabranaZastita != null)
            {
                if (MessageBox.Show("Želte li izbrisati zaštitu?", "Pitanje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ZastitaRepozitorij.Izbrisi(odabranaZastita);
                    PrikaziZastite();
                }
            }
        }
        /// <summary>
        /// Dohvaća zaštitu označenu na DataGridViewu pomoću ID-a
        /// </summary>
        /// <returns></returns>
        private zastita DohvatiOznacenuZastitu()
        {
            ZastitaView oznacena = zastitaViewBindingSource.Current as ZastitaView;
            return ZastitaRepozitorij.DohvatiZastituPoIDu(oznacena.id);
        }
    }
}

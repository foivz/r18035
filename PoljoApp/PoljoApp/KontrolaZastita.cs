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
    public partial class KontrolaZastita : UserControl
    {
        public KontrolaZastita()
        {
            InitializeComponent();
        }

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

        private void PrikaziVrsteZastita()
        {
            //Prikazi vrste zastita u comboboxu koji sluzi za sortiranje glavnog prikaza zaštita
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

        private void PrikaziZastite()
        {
            string odabranaVrsta = uiIzborVrsteZastite.Text;
            zastitaViewBindingSource.DataSource = ZastitaRepozitorij.DohvatiZastite(odabranaVrsta);
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            //Ažuriraj odabranu zastitu
            zastita odabranaZastita = DohvatiOznacenuZastitu();
            if (odabranaZastita != null)
            {
                UnosZastite unosZastite = new UnosZastite(odabranaZastita);
                unosZastite.ShowDialog();
                PrikaziZastite();
            }
            
        }

        private void uiActionIzbrisi_Click(object sender, EventArgs e)
        {
            //Izbrisi zastitu odabranu na prikazu
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

        private zastita DohvatiOznacenuZastitu()
        {
            ZastitaView oznacena = zastitaViewBindingSource.Current as ZastitaView;
            return ZastitaRepozitorij.DohvatiZastituPoIDu(oznacena.id);
        }
    }
}

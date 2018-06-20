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
        }

        private void uiIzborVrsteZastite_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziZastite();
        }

        private void PrikaziVrsteZastita()
        {
            //Prikazi vrste zastita u comboboxu koji sluzi za sortiranje glavnog prikaza zaštita
            BindingList<vrsta_zastite> listaVrstaZastite = null;
            using (var db = new Entities())
            {
                listaVrstaZastite = new BindingList<vrsta_zastite>(db.vrsta_zastite.ToList());
            }
            listaVrstaZastite.Insert(0, new vrsta_zastite() { naziv = "Prikaži sve" });
            vrstazastiteBindingSource.DataSource = listaVrstaZastite;
        }

        private void KontrolaZastita_Load(object sender, EventArgs e)
        {
            PrikaziVrsteZastita();
            PrikaziZastite();
        }

        private void PrikaziZastite()
        {
            //Prikazi zastite cija vrsta odgovara onoj odabranoj u comboboxu
            BindingList<zastita> listaZastita = null;
            using (var db = new Entities())
            {
                var obj = uiIzborVrsteZastite.SelectedItem as vrsta_zastite;

                if (obj != null && obj.naziv == "Prikaži sve")
                    listaZastita = new BindingList<zastita>(db.zastita.ToList());

                else if (obj != null)
                {
                    db.vrsta_zastite.Attach(obj);
                    listaZastita = new BindingList<zastita>(obj.zastita.ToList());
                }
            }
            zastitaBindingSource.DataSource = listaZastita;
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            //Ažuriraj odabranu zastitu
            zastita odabranaZastita = zastitaBindingSource.Current as zastita;
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
            zastita odabranaZastita = zastitaBindingSource.Current as zastita;
            if (odabranaZastita != null)
            {
                if (MessageBox.Show("Želte li izbrisati zaštitu?", "Pitanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.zastita.Attach(odabranaZastita);
                        db.zastita.Remove(odabranaZastita);
                        db.SaveChanges();
                    }
                    PrikaziZastite();
                }
            }
        }
    }
}

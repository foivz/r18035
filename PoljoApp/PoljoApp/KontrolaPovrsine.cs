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
    public partial class KontrolaPovrsine : UserControl
    {
        public KontrolaPovrsine()
        {
            InitializeComponent();
            PrikaziPovrsine();
        }



        private void uiDodajPovrsinu_Click(object sender, EventArgs e)
        {
            //Dodavanje nove površine 
            UnosPovrsine unosPovrsine = new UnosPovrsine();
            unosPovrsine.ShowDialog();
            PrikaziPovrsine();
        }

        private void KontrolaPovrsine_Load(object sender, EventArgs e)
        {
            PrikaziNamjenePovrsina();
            PrikaziPovrsine();
        }

        private void PrikaziNamjenePovrsina()
        {
            //Prikaz namjene površina
            BindingList<NamjenaPovrsine> listaNamjenaPovrsina = null;
            using (var db = new PoljoAppEntities())
            {
                listaNamjenaPovrsina = new BindingList<NamjenaPovrsine>(db.namjena_povrsine.ToList());
            }
            listaNamjenaPovrsina.Insert(0,new NamjenaPovrsine() { namjena = "Prikaži sve" });
            namjenapovrsineBindingSource.DataSource = listaNamjenaPovrsina;
        }

        private void izborNamjenePovrsina_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziPovrsine();
        }

        public void PrikaziPovrsine()
        {
            //Prikaz površina
            BindingList<PoljPovrsina> listaPovrsina = null;
            using (var db = new PoljoAppEntities())
            {
                var obj = izborNamjenePovrsina.SelectedItem as NamjenaPovrsine;

                if (obj != null && obj.namjena == "Prikaži sve")
                    listaPovrsina = new BindingList<PoljPovrsina>(db.polj_povrsina.ToList());

                else if (obj != null)
                {
                    db.namjena_povrsine.Attach(obj);
                    listaPovrsina = new BindingList<PoljPovrsina>(obj.polj_povrsina.ToList());
                }
            }
            poljpovrsinaBindingSource.DataSource = listaPovrsina;
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            //Ažuriranje postojećih površina
            PoljPovrsina odabranaPovršina = poljpovrsinaBindingSource.Current as PoljPovrsina;
            if (odabranaPovršina != null)
            {
                UnosPovrsine formaUnosPovrsine = new UnosPovrsine(odabranaPovršina);
                formaUnosPovrsine.ShowDialog();
                PrikaziPovrsine();
            }
        }

        private void uiActionIzbrisi_Click_1(object sender, EventArgs e)
        {
            //Brisanje površine
            PoljPovrsina odabranaPovrsina = poljpovrsinaBindingSource.Current as PoljPovrsina;
            if (odabranaPovrsina != null)
            {
                if (MessageBox.Show("Želte li izbrisati površinu?", "Pitanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new PoljoAppEntities())
                    {
                        db.polj_povrsina.Attach(odabranaPovrsina);
                        db.polj_povrsina.Remove(odabranaPovrsina);
                        db.SaveChanges();
                    }
                    PrikaziPovrsine();
                }
            }
        }
    }
}

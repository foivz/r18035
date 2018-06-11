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
            BindingList<namjena_povrsine> listaNamjenaPovrsina = null;
            using (var db = new Entities())
            {
                listaNamjenaPovrsina = new BindingList<namjena_povrsine>(db.namjena_povrsine.ToList());
            }
            listaNamjenaPovrsina.Add(new namjena_povrsine() { namjena = "Prikazi sve" });
            namjenapovrsineBindingSource.DataSource = listaNamjenaPovrsina;
        }

        private void izborNamjenePovrsina_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziPovrsine();
        }

        public void PrikaziPovrsine()
        {
            //Prikaz površina
            BindingList<polj_povrsina> listaPovrsina = null;
            using (var db = new Entities())
            {
                var obj = izborNamjenePovrsina.SelectedItem as namjena_povrsine;

                if (obj != null && obj.namjena == "Prikazi sve")
                    listaPovrsina = new BindingList<polj_povrsina>(db.polj_povrsina.ToList());

                else if (obj != null)
                {
                    db.namjena_povrsine.Attach(obj);
                    listaPovrsina = new BindingList<polj_povrsina>(obj.polj_povrsina.ToList());
                }
            }
            poljpovrsinaBindingSource.DataSource = listaPovrsina;
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            //Ažuriranje postojećih površina
            polj_povrsina odabranaPovršina = poljpovrsinaBindingSource.Current as polj_povrsina;
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
            polj_povrsina odabranaPovrsina = poljpovrsinaBindingSource.Current as polj_povrsina;
            if (odabranaPovrsina != null)
            {
                if (MessageBox.Show("Želte li izbrisati površinu?", "Pitanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
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

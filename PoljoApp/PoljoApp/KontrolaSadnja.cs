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
    public partial class KontrolaSadnja : UserControl
    {
        public KontrolaSadnja()
        {
            InitializeComponent();
        }

        private void UiDodajSadnju_Click(object sender, EventArgs e)
        {
            UnosSadnje unosSadnje = new UnosSadnje();
            unosSadnje.ShowDialog();
            PrikaziSadnju();
        }

        private void PrikaziPoljoprivrednePovršine()
        {
            //Prikaz poljoprivrednih povrsina u combo boxu
            BindingList<PoljPovrsina> listaPoljPovrsina = null;
            using (var db= new PoljoAppEntities())
            {
               listaPoljPovrsina = new BindingList<PoljPovrsina> (db.polj_povrsina.ToList());
            }
            listaPoljPovrsina.Insert(0,new PoljPovrsina() { naziv = "Prikaži sve" });
            poljpovrsinaBindingSource.DataSource = listaPoljPovrsina;
        }

        private void PrikaziVrsteSadnihMaterijala()
        {
            //Prikaz vrsta sadnog materijala u combo boxu
            BindingList<SadniMaterijal> listaSadnogMaterijala = null;
            using (var db = new PoljoAppEntities())
            {
                listaSadnogMaterijala = new BindingList<SadniMaterijal>(db.sadni_materijal.ToList());
            }
            listaSadnogMaterijala.Insert(0,new SadniMaterijal() { naziv = "Prikaži sve" });
            sadnimaterijalBindingSource.DataSource = listaSadnogMaterijala;
        }

        private void PrikaziSadnju()
        {
            //Prikaz sadnja
            BindingList<SadnjaView> listaSadnja = null;
            using (var db= new PoljoAppEntities())
            {
                var obj = izborPoljPovrsina.SelectedItem as PoljPovrsina;
                var obj2 = izborSadnogMaterijala.SelectedItem as SadniMaterijal;
                if(obj!=null && obj.naziv=="Prikaži sve"  && obj2!=null && obj2.naziv=="Prikaži sve")
                {
                    listaSadnja = new BindingList<SadnjaView>(db.SadnjaView.ToList());
                }

                else if (obj != null && obj2!= null && obj2.naziv=="Prikaži sve")
                {
                    listaSadnja = new BindingList<SadnjaView>(db.SadnjaView.Where(s=>s.id_povrsina==obj.id).ToList());
                }

                else if (obj2 != null && obj != null && obj.naziv == "Prikaži sve")
                {
                    listaSadnja = new BindingList<SadnjaView>(db.SadnjaView.Where(s => s.id_materijal == obj2.id).ToList());
                }

                else if(obj != null && obj2 != null)
                {
                    listaSadnja = new BindingList<SadnjaView>(db.SadnjaView.Where(s => (s.id_materijal == obj2.id && s.id_povrsina == obj.id)).ToList());
                }

            }
            sadnjaViewBindingSource.DataSource = listaSadnja;
        }
        private void uiActionAzurirajSadnju_Click(object sender, EventArgs e)
        {
            Sadnja zaIzmjenu = DohvatiOznacenuSadnju();
            UnosSadnje azuriraj = new UnosSadnje(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziSadnju();
        }

        private void uiActionIzbrisiSadnju_Click(object sender, EventArgs e)
        {
            Sadnja zaBrisanje = DohvatiOznacenuSadnju();

            if (MessageBox.Show("Jeste li sigurni da želite obrisati sadnju?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new PoljoAppEntities())
                {
                    db.sadnja.Attach(zaBrisanje);
                    db.sadnja.Remove(zaBrisanje);
                    db.SaveChanges();
                }

            }
            PrikaziSadnju();
        }
        private Sadnja DohvatiOznacenuSadnju()
        {
            SadnjaView oznacenaSadnja = sadnjaViewBindingSource.Current as SadnjaView;
            Sadnja sadnjaZaIzmjenu;
            using (var db=new PoljoAppEntities())
            {
                sadnjaZaIzmjenu = db.sadnja.Where(s => s.Id == oznacenaSadnja.Id).FirstOrDefault();
            }
            return sadnjaZaIzmjenu;
        }

        private void KontrolaSadnja_Load(object sender, EventArgs e)
        {
            PrikaziPoljoprivrednePovršine();
            PrikaziVrsteSadnihMaterijala();
            PrikaziSadnju();
        }

        private void izborPoljPovrsina_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziSadnju();
        }

        private void izborSadnogMaterijala_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziSadnju();
        }

        public void OtvoriPomoc()
        {
            tabControl1.SelectedTab = pomocTab;
        }
    }
}

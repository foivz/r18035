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
            BindingList<polj_povrsina> listaPoljPovrsina = null;
            using (var db= new Entities())
            {
               listaPoljPovrsina = new BindingList<polj_povrsina> (db.polj_povrsina.ToList());
            }
            listaPoljPovrsina.Insert(0,new polj_povrsina() { naziv = "Prikaži sve" });
            poljpovrsinaBindingSource.DataSource = listaPoljPovrsina;
        }

        private void PrikaziVrsteSadnihMaterijala()
        {
            //Prikaz vrsta sadnog materijala u combo boxu
            BindingList<sadni_materijal> listaSadnogMaterijala = null;
            using (var db = new Entities())
            {
                listaSadnogMaterijala = new BindingList<sadni_materijal>(db.sadni_materijal.ToList());
            }
            listaSadnogMaterijala.Insert(0,new sadni_materijal() { naziv = "Prikaži sve" });
            sadnimaterijalBindingSource.DataSource = listaSadnogMaterijala;
        }

        private void PrikaziSadnju()
        {
            //Prikaz sadnja
            BindingList<SadnjaView> listaSadnja = null;
            using (var db= new Entities())
            {
                var obj = izborPoljPovrsina.SelectedItem as polj_povrsina;
                var obj2 = izborSadnogMaterijala.SelectedItem as sadni_materijal;
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
            sadnja zaIzmjenu = DohvatiOznacenuSadnju();
            UnosSadnje azuriraj = new UnosSadnje(zaIzmjenu);
            azuriraj.ShowDialog();
            PrikaziSadnju();
        }

        private void uiActionIzbrisiSadnju_Click(object sender, EventArgs e)
        {
            sadnja zaBrisanje = DohvatiOznacenuSadnju();

            if (MessageBox.Show("Jeste li sigurni da želite obrisati sadnju?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new Entities())
                {
                    db.sadnja.Attach(zaBrisanje);
                    db.sadnja.Remove(zaBrisanje);
                    db.SaveChanges();
                }

            }
            PrikaziSadnju();
        }
        private sadnja DohvatiOznacenuSadnju()
        {
            SadnjaView oznacenaSadnja = sadnjaViewBindingSource.Current as SadnjaView;
            sadnja sadnjaZaIzmjenu;
            using (var db=new Entities())
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
    }
}

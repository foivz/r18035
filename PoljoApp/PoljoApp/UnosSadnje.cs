using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace PoljoAppVerzija2
{
    public partial class UnosSadnje : Form
    {
        private Sadnja sadnjaZaIzmjenu= null;
        public UnosSadnje(Sadnja sadnja )
        {
            InitializeComponent();
            PrikaziPoljoprivrednePovršine();
            PrikaziVrsteSadnihMaterijala();
            sadnjaZaIzmjenu = sadnja;

            uiUnosKolicine.Text = sadnjaZaIzmjenu.kolicina.ToString();
            datum.Text = sadnjaZaIzmjenu.datum_sadnje.ToString();
            izborPovrsine.SelectedValue = sadnjaZaIzmjenu.id_povrsina;
            izborProizvodaZaSadnju.SelectedValue = sadnjaZaIzmjenu.id_materijal;
            
        }
        public UnosSadnje()
        {
            InitializeComponent();
            PrikaziPoljoprivrednePovršine();
            PrikaziVrsteSadnihMaterijala();
            
        }

        private void PrikaziPoljoprivrednePovršine()
        {
            //Prikaz poljoprivrednih povrsina u combo boxu
            BindingList<PoljPovrsina> listaPoljPovrsina = null;
            using (var db = new PoljoAppEntities())
            {
                listaPoljPovrsina = new BindingList<PoljPovrsina>(db.polj_povrsina.ToList());
            }
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
            sadnimaterijalBindingSource.DataSource = listaSadnogMaterijala;
            izborProizvodaZaSadnju.SelectedIndex = 1;
            izborProizvodaZaSadnju.SelectedIndex = 0;
        }


        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.sadnjaZaIzmjenu == null)
            {
                using (var db = new PoljoAppEntities())
                {
                    Sadnja novaSadnja = new Sadnja()
                    {
                        kolicina = uiUnosKolicine.Text.ToString(),
                        id_materijal = (int)izborProizvodaZaSadnju.SelectedValue,
                        id_povrsina = (int)izborPovrsine.SelectedValue,
                        datum_sadnje = datum.Value

                    };
                    db.sadnja.Add(novaSadnja);
                    db.SaveChanges();

                }
                Close();
            }
            else
            {
                using (var db= new PoljoAppEntities())
                {
                    db.sadnja.Attach(sadnjaZaIzmjenu);
                    sadnjaZaIzmjenu.id_materijal = (int)izborProizvodaZaSadnju.SelectedValue;
                    sadnjaZaIzmjenu.id_povrsina = (int)izborPovrsine.SelectedValue;
                    sadnjaZaIzmjenu.kolicina = uiUnosKolicine.Text.ToString();
                    sadnjaZaIzmjenu.datum_sadnje = datum.Value;
                    db.SaveChanges();
                }
                Close();
            }
        }

        private void izborPovrsine_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
        }

        private void izborProizvodaZaSadnju_SelectedIndexChanged(object sender, EventArgs e)
        {
            SadniMaterijal oznaceno = izborProizvodaZaSadnju.SelectedItem as SadniMaterijal;

            if(oznaceno!=null)uiLabelaMjernaJedinica.Text = oznaceno.jedinicna_mjera;
        }
    }
}

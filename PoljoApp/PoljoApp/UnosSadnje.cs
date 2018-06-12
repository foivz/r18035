using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoljoAppVerzija2
{
    public partial class UnosSadnje : Form
    {
        private sadnja sadnjaZaIzmjenu= null;
        public UnosSadnje(sadnja sadnja )
        {
            InitializeComponent();
            PrikaziPoljoprivrednePovršine();
            PrikaziVrsteSadnihMaterijala();
            sadnjaZaIzmjenu = sadnja;

            uiUnosKolicine.Text = sadnjaZaIzmjenu.kolicina.ToString();
            datum.Text = sadnjaZaIzmjenu.datum_sadnje.ToString();
            izborPovrsine.SelectedValue = sadnjaZaIzmjenu.id_povrsina;
            izborProizvodaZaSadnju.SelectedValue = sadnjaZaIzmjenu.id_materijal;
            datum.Enabled = false;
            izborProizvodaZaSadnju.Enabled = false;
            izborPovrsine.Enabled = false;
            
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
            BindingList<polj_povrsina> listaPoljPovrsina = null;
            using (var db = new Entities())
            {
                listaPoljPovrsina = new BindingList<polj_povrsina>(db.polj_povrsina.ToList());
            }
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
                using (var db = new Entities())
                {
                    sadnja novaSadnja = new sadnja()
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
                using (var db= new Entities())
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
            sadni_materijal oznaceno = izborProizvodaZaSadnju.SelectedItem as sadni_materijal;

            if(oznaceno!=null)uiLabelaMjernaJedinica.Text = oznaceno.jedinicna_mjera;
        }
    }
}

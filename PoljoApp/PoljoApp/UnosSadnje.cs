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
            izborPovrsine.SelectedValue = sadnjaZaIzmjenu.id_povrsina.ToString();
            izborProizvodaZaSadnju.SelectedValue = sadnjaZaIzmjenu.id_materijal.ToString();
            
        }
        public UnosSadnje()
        {
            InitializeComponent();
            PrikaziPoljoprivrednePovršine();
            this.PrikaziVrsteSadnihMaterijala();
            
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
                    sadnja novaSadnja = new sadnja();

                }
            }
        }
    }
}

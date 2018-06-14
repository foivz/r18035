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
    public partial class UnosPovrsine : Form
    {
        private polj_povrsina povrsinaZaIzmjenu = null;
        public UnosPovrsine(polj_povrsina poljPovrsina)
        {
            InitializeComponent();
            PrikaziNamjenePovrsina();
            povrsinaZaIzmjenu = poljPovrsina;
            uiUnosNaziva.Text = povrsinaZaIzmjenu.naziv;
            uiUnosPovrsine.Text = povrsinaZaIzmjenu.povrsina_m2.ToString();
            uiOdabirNamjene.SelectedValue = povrsinaZaIzmjenu.id_namjene;
            uiUnosKoordinateX.Text = povrsinaZaIzmjenu.x_koordinata.ToString();
            uiUnosKoordinateY.Text = povrsinaZaIzmjenu.y_koordinata.ToString();
        }
        public UnosPovrsine()
        {
            InitializeComponent();
            PrikaziNamjenePovrsina();
        }
        private void PrikaziNamjenePovrsina()
        {
            BindingList<namjena_povrsine> listaNamjenaPovrsina = null;
            using (var db = new Entities())
            {
                listaNamjenaPovrsina = new BindingList<namjena_povrsine>(db.namjena_povrsine.ToList());
            }
            namjenapovrsineBindingSource.DataSource = listaNamjenaPovrsina;
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            if (this.povrsinaZaIzmjenu == null)
            {
                using (var db = new Entities())
                {

                    polj_povrsina novaPoljPovrsina = new polj_povrsina()
                    {
                        naziv = uiUnosNaziva.Text,
                        povrsina_m2 = int.Parse(uiUnosPovrsine.Text),
                        id_namjene = (int)uiOdabirNamjene.SelectedValue,
                        x_koordinata = decimal.Parse(uiUnosKoordinateX.Text),
                        y_koordinata = decimal.Parse(uiUnosKoordinateY.Text)

                    };
                    db.polj_povrsina.Add(novaPoljPovrsina);
                    db.SaveChanges();
                }
                Close();
            }
            else
            {
                using (var db = new Entities())
                {

                    db.polj_povrsina.Attach(povrsinaZaIzmjenu);
                    povrsinaZaIzmjenu.naziv = uiUnosNaziva.Text;
                    povrsinaZaIzmjenu.povrsina_m2 = decimal.Parse(uiUnosPovrsine.Text);
                    povrsinaZaIzmjenu.id_namjene = (int)uiOdabirNamjene.SelectedValue;
                    povrsinaZaIzmjenu.x_koordinata = decimal.Parse(uiUnosKoordinateX.Text);
                    povrsinaZaIzmjenu.y_koordinata = decimal.Parse(uiUnosKoordinateY.Text);

                    db.SaveChanges();
                }
                Close();
            }
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

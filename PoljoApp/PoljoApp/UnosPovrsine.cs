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
            using (var db= new Entities())
            {
                
                polj_povrsina novaPoljPovrsina = new polj_povrsina()
                {
                    naziv = uiUnosNaziva.Text,
                    povrsina_m2 = int.Parse(uiUnosPovrsine.Text),
                    id_namjene = (int)uiOdabirNamjene.SelectedValue,
                    x_koordinata=decimal.Parse(uiUnosKoordinateX.Text),
                    y_koordinata=decimal.Parse(uiUnosKoordinateY.Text)
                    
            };
                db.polj_povrsina.Add(novaPoljPovrsina);
                db.SaveChanges();
            }
            Close();
            
        }
    }
}

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
        }



        private void uiDodajPovrsinu_Click(object sender, EventArgs e)
        {
            UnosPovrsine unosPovrsine = new UnosPovrsine();
            unosPovrsine.ShowDialog();
        }

        private void KontrolaPovrsine_Load(object sender, EventArgs e)
        {
            PrikaziNamjenePovrsina();
        }

        private void PrikaziNamjenePovrsina()
        {
            BindingList<namjena_povrsine> listaNamjenaPovrsina = null;
            using(var db= new Entities())
            {
                listaNamjenaPovrsina = new BindingList<namjena_povrsine>(db.namjena_povrsine.ToList());
            }
            listaNamjenaPovrsina.Add(new namjena_povrsine() { namjena="Prikazi sve"});
            namjenapovrsineBindingSource.DataSource = listaNamjenaPovrsina;
        }

        private void izborNamjenePovrsina_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziPovrsine();
        }

        public void PrikaziPovrsine()
        {
            BindingList<polj_povrsina> listaPovrsina = null;
            using (var db = new Entities())
            {
                var obj = izborNamjenePovrsina.SelectedItem as namjena_povrsine;
                if(obj.namjena=="Prikazi sve")
                    listaPovrsina = new BindingList<polj_povrsina>(db.polj_povrsina.ToList());
                else
                {
                    db.namjena_povrsine.Attach(obj);
                    listaPovrsina = new BindingList<polj_povrsina>(obj.polj_povrsina.ToList());
                }
            }
            poljpovrsinaBindingSource.DataSource = listaPovrsina;
        }
    }
}

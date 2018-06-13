using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoljoAppVerzija2.Admin
{
    public partial class DjelatniciForma : Form
    {
        public DjelatniciForma()
        {
            InitializeComponent();
            PrikaziDjelatnike();
        }

        private void UiActionUnos_Click(object sender, EventArgs e)
        {
            UnosDjelatnika unos = new UnosDjelatnika();
            unos.ShowDialog();
            PrikaziDjelatnike();
        }

        private void PrikaziDjelatnike()
        {
            BindingList<Djelatnik> listaDjelatnika = null;
            using (var db = new Entities()) {
                listaDjelatnika = new BindingList<Djelatnik>(db.DjelatnikSet.ToList());
            }
            djelatnikBindingSource.DataSource = listaDjelatnika;
        }

        private void UiActionAzuriraj_Click(object sender, EventArgs e)
        {
            if(djelatnikBindingSource.Current != null)
            {
                UnosDjelatnika unos = new UnosDjelatnika(djelatnikBindingSource.Current as Djelatnik);
                unos.ShowDialog();
                PrikaziDjelatnike();
            }
        }
    }
}

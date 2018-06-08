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
    public partial class KontrolaProizvodi : UserControl
    {
        public KontrolaProizvodi()
        {
            InitializeComponent();
        }

        private void UiDodajProizvod_Click(object sender, EventArgs e)
        {
            UnosProizvoda unosProizvoda = new UnosProizvoda();
            unosProizvoda.ShowDialog();
        }

        private void KontrolaProizvodi_Load(object sender, EventArgs e)
        {

        }
    }
}

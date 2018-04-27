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
    public partial class uiUserControlProizvodi : UserControl
    {
        public uiUserControlProizvodi()
        {
            InitializeComponent();
        }

        private void UiDodajProizvod_Click(object sender, EventArgs e)
        {
            UnosProizvoda unosProizvoda = new UnosProizvoda();
            unosProizvoda.ShowDialog();
        }
    }
}

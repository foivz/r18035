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
        }
    }
}

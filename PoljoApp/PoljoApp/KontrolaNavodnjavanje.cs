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
    public partial class KontrolaNavodnjavanje : UserControl
    {
        public KontrolaNavodnjavanje()
        {
            InitializeComponent();
        }

        private void UiActionNovo_Click(object sender, EventArgs e)
        {
            UnosNavodnjavanja novo = new UnosNavodnjavanja();
            novo.ShowDialog();
        }
    }
}

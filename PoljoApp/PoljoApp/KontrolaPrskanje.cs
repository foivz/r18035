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
    public partial class KontrolaPrskanje : UserControl
    {
        public KontrolaPrskanje()
        {
            InitializeComponent();
        }

        private void UiActionNovo_Click(object sender, EventArgs e)
        {
            UnosPrskanja novo = new UnosPrskanja();
            novo.ShowDialog();
        }

        private void KontrolaPrskanje_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class PoljoApp : Form
    {
        
        public PoljoApp()
        {
            InitializeComponent();
            proizvodi1.BringToFront();
        }

        private void UiActionOpenSadnja_Click(object sender, EventArgs e)
        {
            uiUserControlSadnja.BringToFront();
        }

        private void UiActionOpenPovrsine_Click(object sender, EventArgs e)
        {
            uiUserControlPovrsine.BringToFront();
        }

        private void UiActionNavodnjavanje_Click(object sender, EventArgs e)
        {
            uiNavodnjavanje.BringToFront();
        }

        private void UiActionPrskanje_Click(object sender, EventArgs e)
        {
            uiPrskanje.BringToFront();
        }

        private void uiActionOpenProizvodi_Click(object sender, EventArgs e)
        {
            zastita1.BringToFront();
        }

        private void uiActionOpenZastita_Click(object sender, EventArgs e)
        {
            proizvodi1.BringToFront();
        }
    }
}

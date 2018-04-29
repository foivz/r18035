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
            uiProizvodi.BringToFront();
        }

        private void UiActionOpenSadnja_Click(object sender, EventArgs e)
        {
            uiSadnja.BringToFront();
        }

        private void UiActionOpenPovrsine_Click(object sender, EventArgs e)
        {
            uiPovrsine.BringToFront();
        }

        private void UiActionNavodnjavanje_Click(object sender, EventArgs e)
        {
            uiNavodnjavanje.BringToFront();
        }

        private void UiActionPrskanje_Click(object sender, EventArgs e)
        {
            uiPrskanje.BringToFront();
        }

        private void UiActionOpenProizvodi_Click(object sender, EventArgs e)
        {
            uiProizvodi.BringToFront();
        }

        private void UiActionOpenZastita_Click(object sender, EventArgs e)
        {
            uiZastita.BringToFront();
        }

        
    }
}

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
            uiUserControlPovrsine.BringToFront();
        }

        private void uiActionOpenSadnja_Click(object sender, EventArgs e)
        {
            uiUserControlSadnja.BringToFront();
        }

        private void uiActionOpenPovrsine_Click(object sender, EventArgs e)
        {
            uiUserControlPovrsine.BringToFront();
        }
    }
}

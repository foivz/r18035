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
    public partial class UnosDjelatnika : Form
    {
        public UnosDjelatnika()
        {
            InitializeComponent();
        }

        private void UiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

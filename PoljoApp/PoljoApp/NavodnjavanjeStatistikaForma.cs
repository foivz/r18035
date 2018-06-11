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
    public partial class NavodnjavanjeStatistikaForma : Form
    {
        int GodinaZaPregled;

        public NavodnjavanjeStatistikaForma(int godina)
        {
            InitializeComponent();

            GodinaZaPregled = godina;
        }
    }
}

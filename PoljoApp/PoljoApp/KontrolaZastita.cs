﻿using System;
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
    public partial class KontrolaZastita : UserControl
    {
        public KontrolaZastita()
        {
            InitializeComponent();
        }

        private void ActionDodajZastitu_Click(object sender, EventArgs e)
        {
            UnosZastite unosZastite = new UnosZastite();
            unosZastite.ShowDialog();
        }
    }
}
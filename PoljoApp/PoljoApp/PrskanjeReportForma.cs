using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace PoljoAppVerzija2
{
    public partial class PrskanjeReportForma : Form
    {
        int Godina;

        public PrskanjeReportForma(int godina)
        {
            InitializeComponent();
            this.Godina = godina;
        }

        private void PrskanjeReportForma_Load(object sender, EventArgs e)
        {
            PrikaziReport();
            this.prskanjeReport.RefreshReport();
        }

        private void PrikaziReport()
        {
            BindingList<PrskanjeView> listaPrskanja = null;
            using (var db = new PoljoAppEntities())
            {
                listaPrskanja = new BindingList<PrskanjeView>(db.PrskanjeView.Where(p => p.Datum.Year == Godina).ToList());
            }
            prskanjeViewBindingSource.DataSource = listaPrskanja;
        }
    }
}

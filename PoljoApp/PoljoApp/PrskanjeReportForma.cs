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
    /// <summary>
    /// Prikazuje izvještaj o prskanju za neku godinu
    /// </summary>
    public partial class PrskanjeReportForma : Form
    {
        int Godina;

        /// <summary>
        /// Inicijalizira komponentu i postavlja godinu za prikaz izvještaja
        /// </summary>
        /// <param name="godina"></param>
        public PrskanjeReportForma(int godina)
        {
            InitializeComponent();
            this.Godina = godina;
        }
        /// <summary>
        /// Prikazuje izvještaja o prskanju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrskanjeReportForma_Load(object sender, EventArgs e)
        {
            PrikaziReport();
            this.prskanjeReport.RefreshReport();
        }
        /// <summary>
        /// Dohvaća podatke o prskanju iz baze
        /// </summary>
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

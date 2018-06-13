using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PoljoAppVerzija2
{
    public partial class NavodnjavanjeStatistikaForma : Form
    {
        int GodinaZaPregled;

        public NavodnjavanjeStatistikaForma(int godina)
        {
            InitializeComponent();

            GodinaZaPregled = godina;
            godinaInfo.Text = "Podaci za " + GodinaZaPregled + ". godinu:";
            PopuniGraf();
        }

        private void PopuniGraf()
        {
            using (var db = new Entities())
            {
                var upitNavodnjavanje = from n in db.NavodnjavanjeViewSet
                                        where n.IdStanja == 1 && n.Datum.Year == GodinaZaPregled
                                        group n by n.Datum.Month into g
                                        select new
                                        {
                                            Mjesec = g.Key,
                                            Suma = g.Sum(n => n.KolicinaVode)
                                        };

                var upitOborine = from n in db.NavodnjavanjeViewSet
                                  where n.IdStanja == 2 && n.Datum.Year == GodinaZaPregled
                                  group n by n.Datum.Month into g
                                  select new
                                  {
                                      Mjesec = g.Key,
                                      Suma = g.Sum(n => n.KolicinaVode)
                                  };

                Dictionary<int, decimal?> navodnjavanjeDictionary = upitNavodnjavanje.ToDictionary(keySelector: u => u.Mjesec, elementSelector: u => u.Suma);
                Dictionary<int, decimal?> oborineDictionary = upitOborine.ToDictionary(keySelector: u => u.Mjesec, elementSelector: u => u.Suma);

                Dictionary<int, decimal?> navodnjavanjeSource = new Dictionary<int, decimal?>();
                Dictionary<int, decimal?> oborineSource = new Dictionary<int, decimal?>();

                for (int i = 1; i <= 12; i++)
                {
                    if (navodnjavanjeDictionary.ContainsKey(i))
                        navodnjavanjeSource[i] = navodnjavanjeDictionary[i].Value;
                    else navodnjavanjeSource[i] = 0;

                    if (oborineDictionary.ContainsKey(i))
                        oborineSource[i] = oborineDictionary[i].Value;
                    else oborineSource[i] = 0;
                }

                navodnjavanjeStatistika.Series["Navodnjavanje"].Points.DataBindXY(navodnjavanjeSource.Keys, navodnjavanjeSource.Values);
                navodnjavanjeStatistika.Series["Oborine"].Points.DataBindXY(oborineSource.Keys, oborineSource.Values);
                
            }

            navodnjavanjeStatistika.DataBind();

            Series ukupno = new Series();
            ukupno.ChartType = SeriesChartType.Line;
            ukupno.Name = "Ukupno";

            for (int i = 1; i <= 12; i++)
            {
                ukupno.Points.AddXY(i, navodnjavanjeStatistika.Series["Navodnjavanje"].Points[i-1].YValues.First() + navodnjavanjeStatistika.Series["Oborine"].Points[i-1].YValues.First());
            }
            navodnjavanjeStatistika.Series.Add(ukupno);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PoljoAppVerzija2
{
    public partial class PoljoApp : Form
    {
        private Djelatnik Korisnik;
        private Timer OborineTimer;
        private int Interval = 10;

        public PoljoApp(Djelatnik prijava)
        {
            InitializeComponent();

            Korisnik = prijava;
            if (Korisnik.Admin == 1) uiUpravljanje.Visible = true;

            OborineTimer = new Timer();
            OborineTimer.Interval = this.Interval * 60 * 1000;
            OborineTimer.Tick += OborineTimer_Tick;
            OborineTimer.Start();

            DohvatiVrijeme();
        }

        private void OborineTimer_Tick(object sender, EventArgs e)
        {
            DohvatiVrijeme();
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

        private void UiOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrijavaForma prijava = new PrijavaForma();
            prijava.FormClosed += (s,args) => this.Close();
            prijava.ShowDialog();
        }

        private void UiUpravljanje_Click(object sender, EventArgs e)
        {
            Admin.DjelatniciForma pregledDjelatnika = new Admin.DjelatniciForma();
            pregledDjelatnika.ShowDialog();
        }

        private async void DohvatiVrijeme()
        {
            string apiKey = "a5854ea27e328a268708472920747b11";
            decimal lan, lon;
            string tekst = "";

            using(var db = new Entities())
            {
                foreach (var pov in db.polj_povrsina)
                {
                    lan = pov.x_koordinata;
                    lon = pov.y_koordinata;

                    string url = "http://api.openweathermap.org/data/2.5/weather?lat=" + lan + "&lon=" + lon + "&appid=" + apiKey + "&mode=xml";

                    var xml = await new WebClient().DownloadStringTaskAsync(new Uri(url));

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(xml);

                    string vrijemeIdString = doc.DocumentElement.SelectSingleNode("weather").Attributes["number"].Value;
                    int vrijemeId = int.Parse(vrijemeIdString);
                    Console.WriteLine(vrijemeIdString);
                    if (vrijemeId>=500 && vrijemeId<600)
                    {
                        tekst += pov.naziv + "\r\n";
                        SpremiOborine(pov);
                    }                    
                }

                if(tekst != "")
                {
                    if (MessageBox.Show("Pada kiša na:\r\n" + tekst + "Želite li pregledati i spremiti zapise?", "It's raining!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        TabControl tab = uiNavodnjavanje.Controls.Find("navodnjavanjeTabs", false).First() as TabControl;
                        tab.SelectedIndex = 1;

                        uiNavodnjavanje.BringToFront();
                    }
                }
            }
        }

        private void SpremiOborine(polj_povrsina pov)
        {
            DateTime datum = DateTime.Now.Date;

            using(var db = new Entities()) {
                Navodnjavanje navodnjavanje = db.NavodnjavanjeSet.Where(n => n.Datum == datum && n.IdPovrsina == pov.id && n.IdStanja >= 2 && n.IdStanja <=3).FirstOrDefault();
                if (navodnjavanje == null)
                {
                    Navodnjavanje novo = new Navodnjavanje()
                    {
                        IdPovrsina = pov.id,
                        Datum = datum,
                        IdStanja = 3
                    };
                    db.NavodnjavanjeSet.Add(novo);
                    db.SaveChanges();
                }
            }
        }

        private void IzborDohvacanje_CheckedChanged(object sender, EventArgs e)
        {
            if (izborDohvacanje.Checked)
            {
                OborineTimer.Stop();
            }
            else OborineTimer.Start();
        }

        private void PoljoApp_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.uiZastita);
            this.Controls.Add(this.uiPovrsine);
            this.Controls.Add(this.uiProizvodi);
            this.Controls.Add(this.uiNavodnjavanje);
            this.Controls.Add(this.uiPrskanje);
            this.Controls.Add(this.uiSadnja);

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            uiProizvodi.BringToFront();
        }
    }
}

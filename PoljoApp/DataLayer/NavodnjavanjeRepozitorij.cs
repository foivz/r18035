using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PoljoAppModel;

namespace DataLayer
{
    public class NavodnjavanjeRepozitorij : INavodnjavanjeRepozitorij
    {
        public void Azuriraj(Navodnjavanje zaIzmjenu)
        {
            using (var db = new Entities())
            {
                Navodnjavanje mijenjaj = db.Navodnjavanje.Find(zaIzmjenu.Id);
                mijenjaj.IdPovrsina = zaIzmjenu.IdPovrsina;
                mijenjaj.Datum = zaIzmjenu.Datum;
                mijenjaj.KolicinaVode = zaIzmjenu.KolicinaVode;
                mijenjaj.IdStanja = zaIzmjenu.IdStanja;
                db.SaveChanges();
            }
        }

        public List<int> DohvatiGodine()
        {
            using (var db = new Entities())
            {
                return db.Navodnjavanje.Select(p => p.Datum.Year).Distinct().ToList();
            }
        }

        public List<NavodnjavanjeView> DohvatiNavodnjavanje(int godina)
        {
            using (var db = new Entities())
            {
                return db.NavodnjavanjeView.Where(n => n.IdStanja < 3 && n.Datum.Year == godina).ToList();
            }
        }

        public List<NavodnjavanjeView> DohvatiOborine()
        {
            using (var db = new Entities())
            {
                return db.NavodnjavanjeView.Where(n => n.IdStanja == 3).ToList();
            }
        }

        public Navodnjavanje DohvatiPoIdu(int id)
        {
            using (var db = new Entities())
            {
                return db.Navodnjavanje.Find(id);
            }
        }

        public string DohvatiVrijeme()
        {
            string apiKey = "a5854ea27e328a268708472920747b11";
            decimal lan, lon;
            string tekst = "";

            using (var db = new Entities())
            {
                foreach (var pov in db.polj_povrsina)
                {
                    lan = pov.x_koordinata;
                    lon = pov.y_koordinata;

                    string url = "http://api.openweathermap.org/data/2.5/weather?lat=" + lan + "&lon=" + lon + "&appid=" + apiKey + "&mode=xml";

                    var xml = new WebClient().DownloadString(new Uri(url));

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(xml);

                    string vrijemeIdString = doc.DocumentElement.SelectSingleNode("weather").Attributes["number"].Value;
                    int vrijemeId = int.Parse(vrijemeIdString);
                    Console.WriteLine(vrijemeIdString);
                    if (vrijemeId >= 500 && vrijemeId < 600)
                    {
                        tekst += pov.naziv + "\r\n";
                        SpremiOborine(pov);
                    }
                }
            }

            return tekst;
        }

        public void Izbrisi(Navodnjavanje zaBrisanje)
        {
            using (var db = new Entities())
            {
                db.Navodnjavanje.Attach(zaBrisanje);
                db.Navodnjavanje.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }

        public void OdbijOborinu(Navodnjavanje zaIzmjenu)
        {
            using (var db = new Entities())
            {
                db.Navodnjavanje.Attach(zaIzmjenu);
                zaIzmjenu.IdStanja = 4;
                db.SaveChanges();
            }
        }

        public Navodnjavanje Spremi(Navodnjavanje novo)
        {
            using (var db = new Entities())
            {
                db.Navodnjavanje.Add(novo);
                db.SaveChanges();
                return novo;
            }
        }

        public void SpremiOborine(polj_povrsina povrsina)
        {
            DateTime datum = DateTime.Now.Date;

            using (var db = new Entities())
            {
                Navodnjavanje navodnjavanje = db.Navodnjavanje.Where(n => n.Datum == datum && n.IdPovrsina == povrsina.id && n.IdStanja >= 2 && n.IdStanja <= 3).FirstOrDefault();
                if (navodnjavanje == null)
                {
                    Navodnjavanje novo = new Navodnjavanje()
                    {
                        IdPovrsina = povrsina.id,
                        Datum = datum,
                        IdStanja = 3
                    };
                    db.Navodnjavanje.Add(novo);
                    db.SaveChanges();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataLayer
{
    /// <summary>
    /// Klasa sadrži potrebne metode za CRUD operacije nad tablicom Navodnjavanje u bazi
    /// </summary>
    public static class NavodnjavanjeRepozitorij
    {
        /// <summary>
        /// Ažurira proslijeđeni zapis o navodnjavanju u bazi
        /// </summary>
        /// <param name="zaIzmjenu"></param>
        public static void Azuriraj(Navodnjavanje zaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                Navodnjavanje mijenjaj = db.Navodnjavanje.Find(zaIzmjenu.Id);
                mijenjaj.IdPovrsina = zaIzmjenu.IdPovrsina;
                mijenjaj.Datum = zaIzmjenu.Datum;
                mijenjaj.KolicinaVode = zaIzmjenu.KolicinaVode;
                mijenjaj.IdStanja = zaIzmjenu.IdStanja;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Dohvaća jedinstvene godine za koje postoje zapisi u bazi
        /// </summary>
        /// <returns>Lista godina navodnjavanja</returns>
        public static List<int> DohvatiGodine()
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Navodnjavanje.Select(p => p.Datum.Year).Distinct().ToList();
            }
        }

        /// <summary>
        /// Dohvaća prihvaćene zapise o navodnjavanju ovisno o godini
        /// </summary>
        /// <param name="godina"></param>
        /// <returns>Lista navodnjavanja</returns>
        public static List<NavodnjavanjeView> DohvatiNavodnjavanje(int godina)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.NavodnjavanjeView.Where(n => n.IdStanja < 3 && n.Datum.Year == godina).ToList();
            }
        }

        /// <summary>
        /// Dohvaća zapise o dohvaćenim, neprihvaćenim oborinama
        /// </summary>
        /// <returns>Lista navodnjavanja</returns>
        public static List<NavodnjavanjeView> DohvatiOborine()
        {
            using (var db = new PoljoAppEntities())
            {
                return db.NavodnjavanjeView.Where(n => n.IdStanja == 3).ToList();
            }
        }

        /// <summary>
        /// Dohvaća zapis o navodnjavanju na temelju id-a
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Zapis tipa Navodnjavanje</returns>
        public static Navodnjavanje DohvatiPoIdu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Navodnjavanje.Find(id);
            }
        }

        /// <summary>
        /// Dohvaća vrijeme sa vanjskog servisa(OpenWeatherMap)
        /// </summary>
        /// <returns>Popis poljoprivrednih površina na kojima pada kiša</returns>
        public static string DohvatiVrijeme()
        {
            string apiKey = "a5854ea27e328a268708472920747b11";
            decimal lan, lon;
            string tekst = "";

            using (var db = new PoljoAppEntities())
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

        /// <summary>
        /// Briše proslijeđeni zapis o navodnjavanju iz baze
        /// </summary>
        /// <param name="zaBrisanje"></param>
        public static void Izbrisi(Navodnjavanje zaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Navodnjavanje.Attach(zaBrisanje);
                db.Navodnjavanje.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Proslijeđena oborina se ne prihvaća 
        /// </summary>
        /// <param name="zaIzmjenu"></param>
        public static void OdbijOborinu(Navodnjavanje zaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Navodnjavanje.Attach(zaIzmjenu);
                zaIzmjenu.IdStanja = 4;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Sprema proslijeđeni zapis o navodnjavanju u bazu
        /// </summary>
        /// <param name="novo"></param>
        /// <returns>Spremljeni zapis</returns>
        public static Navodnjavanje Spremi(Navodnjavanje novo)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Navodnjavanje.Add(novo);
                db.SaveChanges();
                return novo;
            }
        }

        /// <summary>
        /// Sprema dohvaćene oborine u bazu, ako zapis već ne postoji
        /// </summary>
        /// <param name="povrsina"></param>
        public static void SpremiOborine(PoljPovrsina povrsina)
        {
            DateTime datum = DateTime.Now.Date;

            using (var db = new PoljoAppEntities())
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

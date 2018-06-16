using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoljoAppModel;

namespace DataLayer
{
    public class NavodnjavanjeRepozitorij : INavodnjavanjeRepozitorij
    {
        public void Azuriraj(Navodnjavanje zaIzmjenu)
        {
            using (var db = new Entities())
            {
                db.Navodnjavanje.Attach(zaIzmjenu);
                db.SaveChanges();
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
    }
}

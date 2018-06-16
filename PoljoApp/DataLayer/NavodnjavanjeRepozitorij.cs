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

        public List<NavodnjavanjeView> DohvatiNavodnjavanje()
        {
            using (var db = new Entities())
            {
                return db.NavodnjavanjeView.ToList();
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

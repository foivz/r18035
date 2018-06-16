using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoljoAppModel;

namespace DataLayer
{
    public class PrskanjeRepozitorij : IPrskanjeRepozitorij
    {
        public void Azuriraj(Prskanje zaIzmjenu)
        {
            using (var db = new Entities())
            {
                db.Prskanje.Attach(zaIzmjenu);
                db.SaveChanges();
            }
        }

        public Prskanje DohvatiPoIdu(int id)
        {
            using (var db = new Entities())
            {
                return db.Prskanje.Find(id);
            }
        }

        public List<PrskanjeView> DohvatiPrskanje()
        {
            using (var db = new Entities())
            {
                return db.PrskanjeView.ToList();
            }
        }

        public void Izbrisi(Prskanje zaBrisanje)
        {
            using (var db = new Entities())
            {
                db.Prskanje.Attach(zaBrisanje);
                db.Prskanje.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }

        public Prskanje Spremi(Prskanje novo)
        {
            using (var db = new Entities())
            {
                db.Prskanje.Add(novo);
                db.SaveChanges();
                return novo;
            }
        }
    }
}

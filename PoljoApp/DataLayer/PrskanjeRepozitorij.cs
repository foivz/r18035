using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class PrskanjeRepozitorij
    {
        public static void Azuriraj(Prskanje zaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                Prskanje mijenjaj = db.Prskanje.Find(zaIzmjenu.Id);
                mijenjaj.IdDjelatnik = zaIzmjenu.IdDjelatnik;
                mijenjaj.IdZastita = zaIzmjenu.IdZastita;
                mijenjaj.IdPovrsina = zaIzmjenu.IdPovrsina;
                mijenjaj.Datum = zaIzmjenu.Datum;
                mijenjaj.Opis = zaIzmjenu.Opis;
                db.SaveChanges();
            }
        }

        public static List<int> DohvatiGodine()
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Prskanje.Select(p => p.Datum.Year).Distinct().ToList();
            }
        }

        public static Prskanje DohvatiPoIdu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Prskanje.Find(id);
            }
        }

        public static List<PrskanjeView> DohvatiPrskanje(int godina)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.PrskanjeView.Where(p=>p.Datum.Year==godina).ToList();
            }
        }

        public static void Izbrisi(Prskanje zaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Prskanje.Attach(zaBrisanje);
                db.Prskanje.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }

        public static Prskanje Spremi(Prskanje novo)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Prskanje.Add(novo);
                db.SaveChanges();
                return novo;
            }
        }
    }
}

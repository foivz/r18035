using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class DjelatniciRepozitorij
    {
        public static void Azuriraj(Djelatnik zaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                Djelatnik mijenjaj = db.Djelatnik.Find(zaIzmjenu.Id);
                mijenjaj.Ime = zaIzmjenu.Ime;
                mijenjaj.Prezime = zaIzmjenu.Prezime;
                mijenjaj.Lozinka = zaIzmjenu.Lozinka;
                mijenjaj.Email = zaIzmjenu.Email;
                mijenjaj.BrojTelefona = zaIzmjenu.BrojTelefona;
                db.SaveChanges();
            }
        }

        public static Djelatnik DohvatiPoIdu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Djelatnik.Find(id);
            }
        }

        public static List<Djelatnik> DohvatiSve()
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Djelatnik.ToList();
            }
        }

        public static void Izbrisi(Djelatnik zaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Djelatnik.Attach(zaBrisanje);
                db.Djelatnik.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }

        public static Djelatnik Prijava(string email, string lozinka)
        {
            using (var db = new PoljoAppEntities())
            {
                Djelatnik korisnik = db.Djelatnik.Where(k => k.Email == email && k.Lozinka == lozinka).FirstOrDefault();

                if (korisnik != null)
                {
                    return korisnik;
                }
                else
                {
                    return null; 
                }
            }
        }

        public static Djelatnik Spremi(Djelatnik novo)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Djelatnik.Add(novo);
                db.SaveChanges();
                return novo;
            }
        }
    }
}

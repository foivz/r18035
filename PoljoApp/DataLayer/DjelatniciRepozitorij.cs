using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoljoAppModel;

namespace DataLayer
{
    public class DjelatniciRepozitorij : IDjelatniciRepozitorij
    {
        public void Azuriraj(Djelatnik zaIzmjenu)
        {
            using (var db = new Entities())
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

        public Djelatnik DohvatiPoIdu(int id)
        {
            using (var db = new Entities())
            {
                return db.Djelatnik.Find(id);
            }
        }

        public List<Djelatnik> DohvatiSve()
        {
            using (var db = new Entities())
            {
                return db.Djelatnik.ToList();
            }
        }

        public void Izbrisi(Djelatnik zaBrisanje)
        {
            using (var db = new Entities())
            {
                db.Djelatnik.Attach(zaBrisanje);
                db.Djelatnik.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }

        public Djelatnik Prijava(string email, string lozinka)
        {
            using (var db = new Entities())
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

        public Djelatnik Spremi(Djelatnik novo)
        {
            using (var db = new Entities())
            {
                db.Djelatnik.Add(novo);
                db.SaveChanges();
                return novo;
            }
        }
    }
}

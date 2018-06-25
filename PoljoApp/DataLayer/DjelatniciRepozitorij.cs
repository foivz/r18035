using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Klasa sadrži potrebne metode za CRUD operacije nad tablicom Djelatnici u bazi
    /// </summary>
    public static class DjelatniciRepozitorij
    {
        /// <summary>
        /// Ažurira proslijeđeni zapis u bazi
        /// </summary>
        /// <param name="zaIzmjenu"></param>
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

        /// <summary>
        /// Dohvaća zapis o djelatniku na temelju id-a
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Zapis tipa Djelatnik</returns>
        public static Djelatnik DohvatiPoIdu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Djelatnik.Find(id);
            }
        }

        /// <summary>
        /// Dohvaća sve dijelatnike iz baze
        /// </summary>
        /// <returns>Lista djelatnika</returns>
        public static List<Djelatnik> DohvatiSve()
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Djelatnik.ToList();
            }
        }

        /// <summary>
        /// Briše proslijeđenog djelatnika iz baze
        /// </summary>
        /// <param name="zaBrisanje"></param>
        public static bool Izbrisi(Djelatnik zaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Djelatnik.Attach(zaBrisanje);
                if (zaBrisanje.Prskanje.Count > 0) return false;
                else {
                    db.Djelatnik.Remove(zaBrisanje);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        /// <summary>
        /// Provjerava postojanje korisnika u bazi na temelju ulaznih parametara
        /// </summary>
        /// <param name="email"></param>
        /// <param name="lozinka"></param>
        /// <returns>Zapis o korisniku u slučaju uspješne prijave, u suprotnom vraća null</returns>
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

        /// <summary>
        /// Sprema proslijeđeni zapis o djelatniku u bazu
        /// </summary>
        /// <param name="novo"></param>
        /// <returns>Spremljeni zapis</returns>
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

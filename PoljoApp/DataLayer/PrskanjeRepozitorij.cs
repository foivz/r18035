using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Klasa sadrži potrebne metode za CRUD operacije nad tablicom Prskanje u bazi
    /// </summary>
    public static class PrskanjeRepozitorij
    {
        /// <summary>
        /// Ažurira proslijeđeni zapis u bazi
        /// </summary>
        /// <param name="zaIzmjenu"></param>
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

        /// <summary>
        /// Dohvaća jedinstvene godine za koje postoje zapisi o prskanju
        /// </summary>
        /// <returns>Lista godina</returns>
        public static List<int> DohvatiGodine()
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Prskanje.Select(p => p.Datum.Year).Distinct().ToList();
            }
        }

        /// <summary>
        /// Na temelju id-a traži zapis o prskanju
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Zapis o prskanju</returns>
        public static Prskanje DohvatiPoIdu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.Prskanje.Find(id);
            }
        }

        /// <summary>
        /// Dohvaća sve zapise o prskanju iz baze ovisno o proslijeđenoj godini
        /// </summary>
        /// <param name="godina"></param>
        /// <returns>Lista prskanja</returns>
        public static List<PrskanjeView> DohvatiPrskanje(int godina)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.PrskanjeView.Where(p=>p.Datum.Year==godina).ToList();
            }
        }

        /// <summary>
        /// Briše proslijeđeno prskanje iz baze
        /// </summary>
        /// <param name="zaBrisanje"></param>
        public static void Izbrisi(Prskanje zaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.Prskanje.Attach(zaBrisanje);
                db.Prskanje.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Sprema proslijeđeno prskanje u bazu
        /// </summary>
        /// <param name="novo"></param>
        /// <returns>Spremljeno prskanje</returns>
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

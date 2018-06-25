using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Klasa sadrži potrebne metode za rad s podacima zaštite
    /// </summary>
    public static class ZastitaRepozitorij
    {
        /// <summary>
        /// Dohvaća podatke vrsta zaštita iz baze
        /// </summary>
        /// <returns>Lista vrsta zaštita</returns>
        public static List<vrsta_zastite> DohvatiVrsteZastita()
        {
            using (var db = new PoljoAppEntities())
            {
                List<vrsta_zastite> listaVrstaZastite = db.vrsta_zastite.ToList();
                return listaVrstaZastite;
            }
        }
        /// <summary>
        /// DOhvaća podatke zaštita iz baze ovisno o vrsti zaštite
        /// </summary>
        /// <param name="vrstaZastite"></param>
        /// <returns></returns>
        public static List<ZastitaView> DohvatiZastite(string vrstaZastite)
        {
            using (var db = new PoljoAppEntities())
            {
                if (vrstaZastite == "Prikaži sve")
                {
                    return db.ZastitaView.ToList();
                }
                else
                {
                    return db.ZastitaView.Where(n => n.Vrsta == vrstaZastite).ToList();
                }
            }
        }
        /// <summary>
        /// Dodaje prosljeđenu novu zaštitu u bazu
        /// </summary>
        /// <param name="novaZastita"></param>
        public static void Spremi(zastita novaZastita)
        {
            using (var db = new PoljoAppEntities())
            {
                db.zastita.Add(novaZastita);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Mijenja podatke prosljeđene zaštite u bazi podataka
        /// </summary>
        /// <param name="zastitaZaIzmjenu"></param>
        public static void Azuriraj(zastita zastitaZaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                zastita izmjenjeni = db.zastita.Find(zastitaZaIzmjenu.id);
                izmjenjeni.naziv = zastitaZaIzmjenu.naziv;
                izmjenjeni.koncentracija = zastitaZaIzmjenu.koncentracija;
                izmjenjeni.id_vrste_zastite = zastitaZaIzmjenu.id_vrste_zastite;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Briše prosljeđenu zaštitu iz baze podataka
        /// </summary>
        /// <param name="zastitaZaBrisanje"></param>
        public static void Izbrisi(zastita zastitaZaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.zastita.Attach(zastitaZaBrisanje);
                db.zastita.Remove(zastitaZaBrisanje);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Dohvaća zaštitu iz baze podataka prema ID-u
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static zastita DohvatiZastituPoIDu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.zastita.Find(id);
            }
        }
        /// <summary>
        /// Provjerava da li se zaštita za brisanje nalazi na jednom od prskanja
        /// </summary>
        /// <param name="zastitaZaBrisanje"></param>
        /// <returns>ako se zaštita koristi u prskanju false, ako ne true </returns>
        public static bool ValidirajBrisanje(zastita zastitaZaBrisanje)
        {
            bool smijeBrisati = false;
            using (var db = new PoljoAppEntities())
            {
                List<Prskanje> listaPrskanja = db.Prskanje.ToList();
                if (listaPrskanja.Count != 0)
                {
                    foreach (Prskanje prskanje in listaPrskanja)
                    {
                        if (prskanje.zastita.id == zastitaZaBrisanje.id)
                        {
                            smijeBrisati = false;
                        }
                        else smijeBrisati = true;
                    }
                }
                else smijeBrisati = true;
            }
            return smijeBrisati;
        }
    }
}

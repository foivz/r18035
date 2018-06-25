using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Klasa sadrži potrebne metode za rad s podacima proizvoda
    /// </summary>
    public static class ProizvodiRepozitorij
    {
        /// <summary>
        /// Dohvaća vrste sadnog materijala
        /// </summary>
        /// <returns>Lista vrsta sadnog materijala</returns>
        public static List<VrstaSadnogMaterijala> DohvatiVrsteSadnogMaterijala()
        {
            using (var db = new PoljoAppEntities())
            {
                List<VrstaSadnogMaterijala> listaVrstaSadnogMaterijala = db.vrsta_sadnog_materijala.ToList();
                return listaVrstaSadnogMaterijala;
            }
        }

        /// <summary>
        /// Dohvaća sve proizvode iz baze na temelju vrste sadnog materijala (proizvoda)
        /// </summary>
        /// <param name="vrsta"></param>
        /// <returns>Lista proizvoda</returns>
        public static List<SadniMaterijalView> DohvatiSadniMaterijal(string vrsta)
        {
            using (var db = new PoljoAppEntities())
            {
                if (vrsta == "Prikaži sve")
                {
                    return db.SadniMaterijalView.ToList();
                }
                else
                {
                    return db.SadniMaterijalView.Where(n => n.Vrsta == vrsta).ToList();
                }
            }
        }

        /// <summary>
        /// Unosi novi proizvod u bazu podataka
        /// </summary>
        /// <param name="noviSadniMaterijal"></param>
        public static void Spremi(SadniMaterijal noviSadniMaterijal)
        {
            using (var db = new PoljoAppEntities())
            {
                db.sadni_materijal.Add(noviSadniMaterijal);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Ažurira podatke prosljeđenog proizvoda u bazi podataka
        /// </summary>
        /// <param name="sadniMaterijalZaIzmjenu"></param>
        public static void Azuriraj(SadniMaterijal sadniMaterijalZaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                SadniMaterijal izmjenjeni = db.sadni_materijal.Find(sadniMaterijalZaIzmjenu.id);
                izmjenjeni.naziv = sadniMaterijalZaIzmjenu.naziv;
                izmjenjeni.jedinicna_mjera = sadniMaterijalZaIzmjenu.jedinicna_mjera;
                izmjenjeni.id_vrste_materijala = sadniMaterijalZaIzmjenu.id_vrste_materijala;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Briše prosljeđeni proizvod u bazi podataka
        /// </summary>
        /// <param name="sadniMaterijalZaBrisanje"></param>
        public static void Izbrisi(SadniMaterijal sadniMaterijalZaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.sadni_materijal.Attach(sadniMaterijalZaBrisanje);
                db.sadni_materijal.Remove(sadniMaterijalZaBrisanje);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Dohvaća proizvod iz baze podataka prema ID-u
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Proizvod</returns>
        public static SadniMaterijal DohvatiMaterijalPoIDu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.sadni_materijal.Find(id);
            }
        }

        /// <summary>
        /// Provjerava da li se proizvod za brisanje nalazi na jednoj od sadnja
        /// </summary>
        /// <param name="materijalZaBrisati"></param>
        /// <returns>ako se proizvod nalazi na sadnji false, ako ne true</returns>
        public static bool ValidirajBrisanje(SadniMaterijal materijalZaBrisati)
        {
            bool smijeBrisati = false;
            using (var db = new PoljoAppEntities())
            {
                List<Sadnja> listaSadnji = db.sadnja.ToList();
                if (listaSadnji.Count != 0)
                {
                    foreach (var sadnja in listaSadnji)
                    {
                        if (sadnja.sadni_materijal.id == materijalZaBrisati.id)
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

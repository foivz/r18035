using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class ProizvodiRepozitorij
    {
        public static List<VrstaSadnogMaterijala> DohvatiVrsteSadnogMaterijala()
        {
            using (var db = new PoljoAppEntities())
            {
                List<VrstaSadnogMaterijala> listaVrstaSadnogMaterijala = db.vrsta_sadnog_materijala.ToList();
                return listaVrstaSadnogMaterijala;
            }
        }

        public static List<SadniMaterijal> DohvatiSadniMaterijal(string vrsta)
        {
            using (var db = new PoljoAppEntities())
            {
                if (vrsta == "Prikaži sve")
                {
                    return db.sadni_materijal.ToList();
                }
                else
                {
                    return db.sadni_materijal.Where(n => n.vrsta_sadnog_materijala.naziv == vrsta).ToList();
                }
            }
        }

        public static void Spremi(SadniMaterijal noviSadniMaterijal)
        {
            using (var db = new PoljoAppEntities())
            {
                db.sadni_materijal.Add(noviSadniMaterijal);
                db.SaveChanges();
            }
        }

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

        public static void Izbrisi(SadniMaterijal sadniMaterijalZaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.sadni_materijal.Attach(sadniMaterijalZaBrisanje);
                db.sadni_materijal.Remove(sadniMaterijalZaBrisanje);
                db.SaveChanges();
            }
        }
    }
}

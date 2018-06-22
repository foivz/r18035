using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class ZastitaRepozitorij
    {
        public static List<vrsta_zastite> DohvatiVrsteZastita()
        {
            using (var db = new PoljoAppEntities())
            {
                List<vrsta_zastite> listaVrstaZastite = db.vrsta_zastite.ToList();
                return listaVrstaZastite;
            }
        }

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

        public static void Spremi(zastita novaZastita)
        {
            using (var db = new PoljoAppEntities())
            {
                db.zastita.Add(novaZastita);
                db.SaveChanges();
            }
        }

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

        public static void Izbrisi(zastita zastitaZaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.zastita.Attach(zastitaZaBrisanje);
                db.zastita.Remove(zastitaZaBrisanje);
                db.SaveChanges();
            }
        }

        public static zastita DohvatiZastituPoIDu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.zastita.Find(id);
            }
        }
    }
}

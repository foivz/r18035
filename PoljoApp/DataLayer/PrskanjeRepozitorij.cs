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
                Prskanje mijenjaj = db.Prskanje.Find(zaIzmjenu.Id);
                mijenjaj.IdDjelatnik = zaIzmjenu.IdDjelatnik;
                mijenjaj.IdZastita = zaIzmjenu.IdZastita;
                mijenjaj.IdPovrsina = zaIzmjenu.IdPovrsina;
                mijenjaj.Datum = zaIzmjenu.Datum;
                mijenjaj.Opis = zaIzmjenu.Opis;
                db.SaveChanges();
            }
        }

        public List<int> DohvatiGodine()
        {
            using (var db = new Entities())
            {
                return db.Prskanje.Select(p => p.Datum.Year).Distinct().ToList();
            }
        }

        public Prskanje DohvatiPoIdu(int id)
        {
            using (var db = new Entities())
            {
                return db.Prskanje.Find(id);
            }
        }

        public List<PrskanjeView> DohvatiPrskanje(int godina)
        {
            using (var db = new Entities())
            {
                return db.PrskanjeView.Where(p=>p.Datum.Year==godina).ToList();
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

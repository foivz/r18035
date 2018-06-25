using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Klasa sadrži potrebne metode za CRUD operacije nad tablicom PoljPovrsina u bazi
    /// </summary>
    public static class PovrsinaRepozitorij
    {
        
        /// <summary>
        /// Dohvaća namjene poljoprivrednih površina u combobox
        /// </summary>
        /// <returns></returns>
        public static List<NamjenaPovrsine> DohvatiNamjenePovršina()
        {
            using (var db= new PoljoAppEntities())
            {
                List<NamjenaPovrsine> listaNamjenaPovrsina = db.namjena_povrsine.ToList();
                return listaNamjenaPovrsina;
            }
        }

        /// <summary>
        /// Dohvaća zapise o poljoprivrednim površinama na temelju namjene poljoprivredne površine
        /// </summary>
        /// <param name="nazivPovrsine"></param>
        /// <returns></returns>
        public static List<PoljPovrsinaView> DohvatiPovršinu(string namjenaPovrsine)
        {
            using (var db= new PoljoAppEntities())
            {
                if(namjenaPovrsine=="Prikaži sve")
                {
                    return db.PoljPovrsinaView.ToList();
                }
                else
                {
                    return db.PoljPovrsinaView.Where(p => p.namjena == namjenaPovrsine).ToList();
                }
            }
        }
        /// <summary>
        /// Unosi novu površinu u bazu podataka
        /// </summary>
        /// <param name="novaPovrsina"></param>
        public static void Spremi(PoljPovrsina novaPovrsina)
        {
            using (var db= new PoljoAppEntities())
            {
                db.polj_povrsina.Add(novaPovrsina);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Ažurira proslijeđeni zapis o sadnji u bazi
        /// </summary>
        /// <param name="zaIzmjenu"></param>
        public static void Ažuriraj(PoljPovrsina zaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                PoljPovrsina mijenjaj = db.polj_povrsina.Find(zaIzmjenu.id);
                mijenjaj.id_namjene = zaIzmjenu.id_namjene;
                mijenjaj.naziv = zaIzmjenu.naziv;
                mijenjaj.x_koordinata = zaIzmjenu.x_koordinata;
                mijenjaj.y_koordinata = zaIzmjenu.y_koordinata;
                mijenjaj.povrsina_m2 = zaIzmjenu.povrsina_m2;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Briše proslijeđenu površinu iz baze podataka
        /// </summary>
        /// <param name="zaIzbrisati"></param>
        public static void Izbrisi(PoljPovrsina zaIzbrisati)
        {
            using (var db= new PoljoAppEntities())
            {
                db.polj_povrsina.Attach(zaIzbrisati);
                db.polj_povrsina.Remove(zaIzbrisati);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Na temelju id-a traži zapis o površini
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static PoljPovrsina DohvatiPovrsinuPoIDu(int id)
        {
            using (var db= new PoljoAppEntities())
            {
                return db.polj_povrsina.Find(id);
            }
        }
        /// <summary>
        /// Provjerava da li se površina koristi u nekim drugim tablicama
        /// </summary>
        /// <param name="površinaZaBrisati"></param>
        /// <returns></returns>
        public static bool ValidirajBrisanje(PoljPovrsina površinaZaBrisati)
        {
            bool smijeBrisatiSadnja = false;
            bool smijeBrisatiNavodnjavanje = false;
            bool smijeBrisatiPrskanje = false;

            using (var db = new PoljoAppEntities())
            {
                List<Sadnja> listaSadnji = db.sadnja.ToList();
                List <Navodnjavanje> listaNavodnjavanja= db.Navodnjavanje.ToList();
                List<Prskanje> listaPrskanje = db.Prskanje.ToList();

                if (listaSadnji.Count != 0)
                {
                    foreach (var sadnja in listaSadnji)
                    {
                        if (sadnja.polj_povrsina.id == površinaZaBrisati.id)
                        {
                            smijeBrisatiSadnja = false;
                        }
                        else smijeBrisatiSadnja = true;
                    }
                }
                else smijeBrisatiSadnja = true;

                if (listaNavodnjavanja.Count != 0)
                {
                    foreach (var navodnjavanje in listaNavodnjavanja)
                    {
                        if (navodnjavanje.polj_povrsina.id == površinaZaBrisati.id)
                        {
                            smijeBrisatiNavodnjavanje = false;
                        }
                        else smijeBrisatiNavodnjavanje = true;
                    }
                }
                else smijeBrisatiNavodnjavanje = true;

                if (listaPrskanje.Count != 0)
                {
                    foreach (var prskanje in listaPrskanje)
                    {
                        if (prskanje.polj_povrsina.id == površinaZaBrisati.id)
                        {
                            smijeBrisatiPrskanje = false;
                        }
                        else smijeBrisatiPrskanje = true;
                    }
                }
                else smijeBrisatiPrskanje = true;
            }
            if(smijeBrisatiSadnja && smijeBrisatiPrskanje && smijeBrisatiNavodnjavanje)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

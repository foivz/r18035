using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Klasa sadrži potrebne metode za CRUD operacije nad tablicom Sadnja u bazi
    /// </summary>
    public static class SadnjaRepozitorij
    {
        /// <summary>
        /// Dohvaća poljoprivredne površine
        /// </summary>
        /// <returns></returns>
        public static List<PoljPovrsina> DohvatiPoljPovršine()
        {
            using (var db = new PoljoAppEntities())
            {
                List<PoljPovrsina> listaPovrsina = db.polj_povrsina.ToList();
                return listaPovrsina;
            }
        }

        /// <summary>
        /// Dohvaća namjene poljoprivrednih površina
        /// </summary>
        /// <returns></returns>
        public static List<NamjenaPovrsine> DohvatiNamjenePovršina()
        {
            using (var db = new PoljoAppEntities())
            {
                List<NamjenaPovrsine> listaNamjenaPovrsina = db.namjena_povrsine.ToList();
                return listaNamjenaPovrsina;
            }
        }
        /// <summary>
        /// Dohvaća zapise o sadnjama na temelju odabranog sadnog materijala i naziva površine
        /// </summary>
        /// <param name="naziv"></param>
        /// <param name="sadniMaterijal"></param>
        /// <returns></returns>
        public static List<SadnjaView> DohvatiSadnju(string naziv, string sadniMaterijal)
        {
            using (var db= new PoljoAppEntities())
            {
                if (sadniMaterijal == "Prikaži sve" && naziv == "Prikaži sve")
                {
                    return db.SadnjaView.ToList();
                }

                else if (naziv == "Prikaži sve" && sadniMaterijal != null)
                {
                    return db.SadnjaView.Where(s => s.naziv_materijal == sadniMaterijal).ToList();
                }

                else if (naziv != null && sadniMaterijal == "Prikaži sve")
                {
                    return db.SadnjaView.Where(s => s.naziv == naziv).ToList();
                }

                else 
                {
                    return db.SadnjaView.Where(s => (s.naziv == naziv && s.naziv_materijal == sadniMaterijal)).ToList();
                }
            }
        }
        /// <summary>
        /// Unosi novu sadnju u bazu podataka
        /// </summary>
        /// <param name="novaSadnja"></param>
        public static void Spremi(Sadnja novaSadnja)
        {
            using (var db = new PoljoAppEntities())
            {
                db.sadnja.Add(novaSadnja);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Ažurira proslijeđeni zapis o sadnji u bazi
        /// </summary>
        /// <param name="zaIzmjenu"></param>
        public static void Ažuriraj (Sadnja zaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                Sadnja mijenjaj = db.sadnja.Find(zaIzmjenu.Id);
                mijenjaj.id_materijal = zaIzmjenu.id_materijal;
                mijenjaj.id_povrsina = zaIzmjenu.id_povrsina;
                mijenjaj.kolicina = zaIzmjenu.kolicina;
                mijenjaj.datum_sadnje = zaIzmjenu.datum_sadnje;
                db.SaveChanges();
                
            }
        }
        /// <summary>
        /// Briše proslijeđenu sadnju iz baze podataka
        /// </summary>
        /// <param name="zaBrisanje"></param>
        public static void Obrisi(Sadnja zaBrisanje)
        {
            using (var db = new PoljoAppEntities())
            {
                db.sadnja.Attach(zaBrisanje);
                db.sadnja.Remove(zaBrisanje);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Na temelju Id-a traži zapise o sadnji
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Sadnja DohvatiSadnjuPoIdu(int id)
        {
            using (var db = new PoljoAppEntities())
            {
                return db.sadnja.Find(id);
            }
        }
    }

}

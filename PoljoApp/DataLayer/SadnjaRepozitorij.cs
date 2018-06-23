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
    }

}

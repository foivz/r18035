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
    public static class PovrsineRepozitorij
    {
        /// <summary>
        /// Ažurira proslijeđeni zapis o sadnji u bazi
        /// </summary>
        /// <param name="zaIzmjenu"></param>
        public static void Ažuriraj (PoljPovrsina zaIzmjenu)
        {
            using (var db = new PoljoAppEntities())
            {
                PoljPovrsina mijenjaj = db.polj_povrsina.Find(zaIzmjenu.id);
           
                db.SaveChanges();
            }
        }


    }
}

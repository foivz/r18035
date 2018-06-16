using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using PoljoAppModel;

namespace BusinessLayer
{
    public static class NavodnjavanjeUsluge
    {
        static INavodnjavanjeRepozitorij Repozitorij;

        static NavodnjavanjeUsluge()
        {
            Repozitorij = new NavodnjavanjeRepozitorij();
        }

        public static List<NavodnjavanjeView> DohvatiSve(int godina)
        {
            return Repozitorij.DohvatiNavodnjavanje(godina);
        }

        public static List<NavodnjavanjeView> DohvatiOborine()
        {
            return Repozitorij.DohvatiOborine();
        }

        public static Navodnjavanje DohvatiPoIdu(int id)
        {
            return Repozitorij.DohvatiPoIdu(id);
        }

        public static Navodnjavanje Spremi(Navodnjavanje novo)
        {
            return Repozitorij.Spremi(novo);
        }

        public static void Azuriraj(Navodnjavanje zaIzmjenu)
        {
            Repozitorij.Azuriraj(zaIzmjenu);
        }

        public static void Izbrisi(Navodnjavanje zaBrisanje)
        {
            Repozitorij.Izbrisi(zaBrisanje);
        }

        public static void OdbijOborinu(Navodnjavanje zaIzmjenu)
        {
            Repozitorij.OdbijOborinu(zaIzmjenu);
        }
    }
}

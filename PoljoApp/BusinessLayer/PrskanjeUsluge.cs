using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoljoAppModel;
using DataLayer;

namespace BusinessLayer
{
    public static class PrskanjeUsluge
    {
        static IPrskanjeRepozitorij Repozitorij;

        static PrskanjeUsluge()
        {
            Repozitorij = new PrskanjeRepozitorij();
        }

        public static List<PrskanjeView> DohvatiSve(int godina)
        {
            return Repozitorij.DohvatiPrskanje(godina);
        }

        public static Prskanje DohvatiPoIdu(int id)
        {
            return Repozitorij.DohvatiPoIdu(id);
        }

        public static Prskanje Spremi(Prskanje novo)
        {
            return Repozitorij.Spremi(novo);
        }

        public static void Azuriraj (Prskanje zaIzmjenu)
        {
            Repozitorij.Azuriraj(zaIzmjenu);
        }

        public static void Izbrisi(Prskanje zaBrisanje)
        {
            Repozitorij.Izbrisi(zaBrisanje);
        }

        public static List<int> DohvatiGodine()
        {
            return Repozitorij.DohvatiGodine();
        }
    }
}

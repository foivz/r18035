﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoljoAppModel;
using DataLayer;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public static class DjelatniciUsluge
    {
        static IDjelatniciRepozitorij Repozitorij;

        static DjelatniciUsluge()
        {
            Repozitorij = new DjelatniciRepozitorij();
        }

        public static List<Djelatnik> DohvatiSve()
        {
            return Repozitorij.DohvatiSve();
        }

        public static Djelatnik DohvatiPoIdu(int id)
        {
            return Repozitorij.DohvatiPoIdu(id);
        }

        public static Djelatnik Spremi(Djelatnik novo)
        {
            return Repozitorij.Spremi(novo);
        }

        public static void Azuriraj(Djelatnik zaIzmjenu)
        {
            Repozitorij.Azuriraj(zaIzmjenu);
        }

        public static void Izbrisi(Djelatnik zaBrisanje)
        {
            Repozitorij.Izbrisi(zaBrisanje);
        }

        public static Djelatnik Prijava(string email, string lozinka)
        {
            return Repozitorij.Prijava(email, lozinka);
        }

        public static MatchCollection ProvjeriRegex(string tekst, string uzorak)
        {
            MatchCollection pogotci;

            Regex regex = new Regex(uzorak);
            pogotci = regex.Matches(tekst);

            return pogotci;
        }
    }
}

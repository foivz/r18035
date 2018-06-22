using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PoljoAppVerzija2
{
    /// <summary>
    /// Sadrži metodu za validaciju korisničkog unosa
    /// </summary>
    public static class Validacija
    {
        /// <summary>
        /// Provjerava odgovara li tekst regex uzorku
        /// </summary>
        /// <param name="tekst"></param>
        /// <param name="uzorak"></param>
        /// <returns>Kolekcija pogodaka</returns>
        public static MatchCollection ProvjeriRegex(string tekst, string uzorak)
        {
            MatchCollection pogotci;

            Regex regex = new Regex(uzorak);
            pogotci = regex.Matches(tekst);

            return pogotci;
        }
    }
}

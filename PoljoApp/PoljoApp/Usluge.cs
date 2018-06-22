using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PoljoAppVerzija2
{
    public static class Usluge
    {
        public static MatchCollection ProvjeriRegex(string tekst, string uzorak)
        {
            MatchCollection pogotci;

            Regex regex = new Regex(uzorak);
            pogotci = regex.Matches(tekst);

            return pogotci;
        }
    }
}

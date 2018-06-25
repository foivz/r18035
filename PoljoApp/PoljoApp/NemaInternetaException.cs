using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoljoAppVerzija2
{
    /// <summary>
    /// Iznimka u slučaju ako nema interneta
    /// </summary>
    class NemaInternetaException : Exception
    {
        public string Poruka;
        public NemaInternetaException(string poruka)
        {
            this.Poruka = poruka;
        }
    }
}

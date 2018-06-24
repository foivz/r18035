using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoljoAppVerzija2
{
    /// <summary>
    /// Iznika u slučaju ako nema interneta
    /// </summary>
    class ExceptionNemaInterneta : Exception
    {
        public string Poruka;
        public ExceptionNemaInterneta(string poruka)
        {
            this.Poruka = poruka;
        }
    }
}

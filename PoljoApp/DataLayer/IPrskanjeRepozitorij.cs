using PoljoAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPrskanjeRepozitorij
    {
        List<PrskanjeView> DohvatiPrskanje();

        Prskanje DohvatiPoIdu(int id);

        Prskanje Spremi(Prskanje novo);

        void Azuriraj(Prskanje zaIzmjenu);

        void Izbrisi(Prskanje zaBrisanje);
    }
}

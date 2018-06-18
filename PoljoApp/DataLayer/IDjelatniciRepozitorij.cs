using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoljoAppModel;

namespace DataLayer
{
    public interface IDjelatniciRepozitorij
    {
        List<Djelatnik> DohvatiSve();

        Djelatnik DohvatiPoIdu(int id);

        Djelatnik Spremi(Djelatnik novo);

        void Azuriraj(Djelatnik zaIzmjenu);

        void Izbrisi(Djelatnik zaBrisanje);

        Djelatnik Prijava(string email, string lozinka);
    }
}

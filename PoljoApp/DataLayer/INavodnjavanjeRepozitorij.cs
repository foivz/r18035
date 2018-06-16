using PoljoAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface INavodnjavanjeRepozitorij
    {
        List<NavodnjavanjeView> DohvatiNavodnjavanje(int godina);

        List<NavodnjavanjeView> DohvatiOborine();

        Navodnjavanje DohvatiPoIdu(int id);

        Navodnjavanje Spremi(Navodnjavanje novo);

        void Azuriraj(Navodnjavanje zaIzmjenu);

        void OdbijOborinu(Navodnjavanje zaIzmjenu);

        void Izbrisi(Navodnjavanje zaBrisanje);
    }
}

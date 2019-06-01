using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    public interface IFederatedIdentityInterface
    {
        bool LogovanjeZahteva(string username, string lozinka, string sistem);

        void SacuvajPodatke(string username, string lozinka);

        User PronadjiKorisnika(string username);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    public interface IAuthenticationInterfaceDB
    {
        void cuvajPodatkeDB(string username,string lozinka,string rola);
        bool VerifikovanjeKorisnickihPodatakaDB(string username,string lozinka,string rola);
        User PronadjiKorisnika(string username);
    }
}

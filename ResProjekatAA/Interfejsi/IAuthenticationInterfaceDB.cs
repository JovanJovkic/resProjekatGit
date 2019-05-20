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
        void VerifikovanjeKorisnickihPodatakaDB(string username,string lozinka,string rola);
    }
}

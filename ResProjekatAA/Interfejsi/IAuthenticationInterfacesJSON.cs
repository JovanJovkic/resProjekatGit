using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    public interface IAuthenticationInterfacesJSON
    {
        void cuvajPodatkeJSON(string username, string lozinka);
        void VerifikovanjeKorisnickihPodatakaJSON(string username, string lozinka);
    }
}

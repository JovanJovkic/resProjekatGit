using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    public interface ICQRSInterfaceJSON
    {
        User citaj(string username);
        void pisi(string username, string lozinka);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    public interface IFederatedIdentityInterface
    {
        void LogovanjeZahteva(string username, string lozinka, string sistem);
    }
}

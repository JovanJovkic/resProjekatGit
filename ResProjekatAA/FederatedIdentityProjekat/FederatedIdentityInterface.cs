using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;

namespace FederatedIdentityProjekat
{
    public class FederatedIdentityInterface : IFederatedIdentityInterface
    {
        private IAuthenticationInterfaceDB interfaceDB;
        IAuthenticationInterfacesJSON interfaceJSON;

        public FederatedIdentityInterface()
        {

        }

        public void LogovanjeZahteva()
        {
            throw new NotImplementedException();
        }
    }
}

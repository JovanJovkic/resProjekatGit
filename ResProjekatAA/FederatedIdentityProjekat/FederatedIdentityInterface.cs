using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;
using AuthenticationDB;
using AuthenticationJSON;

namespace FederatedIdentityProjekat
{
    public class FederatedIdentityInterface : IFederatedIdentityInterface
    {
        private IAuthenticationInterfaceDB interfaceDB = new AuthenticationInterfaceDB();
        IAuthenticationInterfacesJSON interfaceJSON;

        public FederatedIdentityInterface()
        {
            
        }

        public void LogovanjeZahteva()
        {
            interfaceDB.cuvajPodatkeDB();
           // throw new NotImplementedException();
        }
    }
}

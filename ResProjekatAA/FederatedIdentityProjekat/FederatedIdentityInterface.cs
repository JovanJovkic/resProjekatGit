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

        public void LogovanjeZahteva(string username, string lozinka, string sistem)
        {
            if(username == null || lozinka == null || sistem == null)
            {
                throw new ArgumentNullException("Vrednost ne moze biti null");
            }
            interfaceDB.cuvajPodatkeDB();
           // throw new NotImplementedException();
        }
    }
}

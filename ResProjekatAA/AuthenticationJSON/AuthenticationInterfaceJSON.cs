using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;

namespace AuthenticationJSON
{
    public class AuthenticationInterfaceJSON : IAuthenticationInterfacesJSON
    {
        private ICQRSInterfaceJSON iCQRS_Json;

        public AuthenticationInterfaceJSON()
        {

        }

        public void cuvajPodatkeJSON()
        {
            throw new NotImplementedException();
        }

        public void VerifikovanjeKorisnickihPodatakaJSON()
        {
            throw new NotImplementedException();
        }
    }
}

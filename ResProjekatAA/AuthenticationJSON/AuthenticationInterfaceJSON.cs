using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSProjekatJSON;
using Interfejsi;

namespace AuthenticationJSON
{
    public class AuthenticationInterfaceJSON : IAuthenticationInterfacesJSON
    {
        private ICQRSInterfaceJSON iCQRS_Json = new CQRSInterfaceJSON();

        public AuthenticationInterfaceJSON()
        {

        }

        public void cuvajPodatkeJSON(string username,string lozinka)
        {
            iCQRS_Json.pisi(username,lozinka);
        }

        public void VerifikovanjeKorisnickihPodatakaJSON(string username, string lozinka)
        {
            User u = iCQRS_Json.citaj(username);

            if (u == null)
                return;

            if (u.Lozinka == lozinka)
            {
                //user je ukucao dobru lozinku i treba mu proslediti kljuc
            }
            else
            {
                //user nije ukucao dobru lozinku za username i treba mu poslati obavestenje o tome
            }
        }
    }
}


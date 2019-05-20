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
            //test da li su username i lozinka null
            if (username == null || lozinka == null)
            {
                throw new ArgumentNullException("Argumenti ne mogu biti null");
            }
            iCQRS_Json.pisi(username,lozinka);
        }

        public bool VerifikovanjeKorisnickihPodatakaJSON(string username, string lozinka)
        {
            //test da li su username i lozinka null
            if(username==null||lozinka==null)
            {
                throw new ArgumentNullException("Argumenti ne mogu biti null");
            }

            User u = iCQRS_Json.citaj(username);

            if (u == null)
                return false;

            if (u.Lozinka == lozinka)
            {
                //user je ukucao dobru lozinku i treba mu proslediti kljuc
                return true;
            }
            else
            {
                //user nije ukucao dobru lozinku za username i treba mu poslati obavestenje o tome
                return false;
            }
        }
    }
}


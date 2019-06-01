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
        private ICQRSInterfaceJSON iCQRS_Json;

        public AuthenticationInterfaceJSON()
        {

        }

        public AuthenticationInterfaceJSON(ICQRSInterfaceJSON icqrsJson)
        {
            iCQRS_Json = icqrsJson;
        }

        public void cuvajPodatkeJSON(string username,string lozinka)
        {
            
            if (username == null || lozinka == null)
            {
                throw new ArgumentNullException("Argumenti ne mogu biti null");
            }

            iCQRS_Json.pisi(username,lozinka);
        }

        public bool VerifikovanjeKorisnickihPodatakaJSON(string username, string lozinka)
        {
            
            if(username==null||lozinka==null)
            {
                throw new ArgumentNullException("Argumenti ne mogu biti null");
            }

            User u = iCQRS_Json.citaj(username);

            if (u == null)
            {
                 return false;
            }
               
            if (u.Lozinka == lozinka)
            {
                //user je ukucao dobru lozinku i treba mu proslediti kljuc
                return true;
            }

            return false;
        }

        public User PronadjiKorisnika(string username)
        {
            return iCQRS_Json.citaj(username);
        }
    }
}


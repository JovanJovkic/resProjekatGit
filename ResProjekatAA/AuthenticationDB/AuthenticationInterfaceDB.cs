using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;
using CQRSProjekatDB;

namespace AuthenticationDB
{
    public class AuthenticationInterfaceDB : IAuthenticationInterfaceDB
    {
        private ICQRSInterfaceDB iCQRS_db = new CQRSInterfaceDB();

        public AuthenticationInterfaceDB()
        {
            
        }

        public void cuvajPodatkeDB(string username,string lozinka,string rola)
        {
            iCQRS_db.pisi(username, lozinka, rola);
        }

        public void VerifikovanjeKorisnickihPodatakaDB(string username,string lozinka,string rola)
        {
            Interfejsi.User user = iCQRS_db.citaj(username);
        }
    }
}

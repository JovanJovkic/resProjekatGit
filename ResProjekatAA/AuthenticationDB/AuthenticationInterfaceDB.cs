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
        private ICQRSInterfaceDB iCQRS_db;

        public AuthenticationInterfaceDB()
        {
            
        }

        public AuthenticationInterfaceDB(ICQRSInterfaceDB icqrsDb)
        {
            iCQRS_db = icqrsDb;
        }

        public void cuvajPodatkeDB(string username,string lozinka,string rola)
        {
            if (username == null || lozinka == null)
            {
                throw new ArgumentNullException("Argumenti ne mogu biti null");
            }

            iCQRS_db.pisi(username, lozinka, rola);
        }

        public bool VerifikovanjeKorisnickihPodatakaDB(string username,string lozinka,string rola)
        {
            if (username == null || lozinka == null)
            {
                throw new ArgumentNullException("Argumenti ne mogu biti null");
            }


            Interfejsi.User u = iCQRS_db.citaj(username);

            if (u == null)
            {
                return false;
            }

            if (u.Lozinka.Trim() == lozinka)
            {
                //user je ukucao dobru lozinku i treba mu proslediti kljuc
                return true;
            }

            return false;
        }

        public Interfejsi.User PronadjiKorisnika(string username)
        {
            return iCQRS_db.citaj(username);
        }
    }
}

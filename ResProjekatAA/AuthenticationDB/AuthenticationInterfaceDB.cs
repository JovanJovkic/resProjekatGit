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

        public void cuvajPodatkeDB()
        {
            iCQRS_db.citaj();
            //throw new NotImplementedException();
        }

        public void VerifikovanjeKorisnickihPodatakaDB()
        {
            throw new NotImplementedException();
        }
    }
}

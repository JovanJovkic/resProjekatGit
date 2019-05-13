using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;

namespace AuthenticationDB
{
    public class AuthenticationInterfaceDB : IAuthenticationInterfaceDB
    {
        private ICQRSInterfaceDB iCQRS_db;

        public AuthenticationInterfaceDB()
        {

        }

    }
}

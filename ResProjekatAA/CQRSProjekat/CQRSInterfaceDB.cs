using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;

namespace CQRSProjekatDB
{
    public class CQRSInterfaceDB : ICQRSInterfaceDB
    {
        private CitanjeDB citanje = new CitanjeDB();
        private PisanjeDB pisanje;

        public CQRSInterfaceDB()
        {
           
        }

        public void citaj()
        {
            var context = new Users_databaseEntities();
            var user = new User
            {
                username = "peraa",
                lozinka = "peric",
                rola = "admin"
            };
            context.Users.Add(user);
            //context.SaveChanges();
        }

        public void pisi()
        {
            throw new NotImplementedException();
        }
    }
}

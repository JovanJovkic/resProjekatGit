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
        private PisanjeDB pisanje=new PisanjeDB();

        public CQRSInterfaceDB()
        {
           
        }

        public Interfejsi.User citaj(string username)
        {
            User u=citanje.Citaj(username);

            if(u==null)
            {
                return null;
            }

            Interfejsi.User user = new Interfejsi.User();
            user.Username = u.username;
            user.Lozinka = u.lozinka;
            user.Rola = u.rola;

            return user;
        }

        public void pisi(string username, string lozinka, string rola)
        {
            pisanje.Pisi(username, lozinka, rola);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;

namespace CQRSProjekatJSON
{
    public class CQRSInterfaceJSON : ICQRSInterfaceJSON
    {
        private PisanjeJSON pisanje = new PisanjeJSON();
        private CitanjeJSON citanje = new CitanjeJSON();

        public CQRSInterfaceJSON()
        {

        }
        
        public User citaj(string username)
        {
            User user = citanje.citaj(username);
            return user;
        }

        public void pisi(string username,string lozinka)
        {
            pisanje.Pisi(username,lozinka);
        }
        
    }
}

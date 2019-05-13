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
        private PisanjeJSON pisanje;
        private CitanjeJSON citanje;

        public CQRSInterfaceJSON()
        {

        }

        public void citaj()
        {
            throw new NotImplementedException();
        }

        public void pisi()
        {
            throw new NotImplementedException();
        }
    }
}

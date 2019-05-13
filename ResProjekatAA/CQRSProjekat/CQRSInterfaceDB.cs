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
        private CitanjeDB citanje;
        private PisanjeDB pisanje;

        public CQRSInterfaceDB()
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

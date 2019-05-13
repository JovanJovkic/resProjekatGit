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
    }
}

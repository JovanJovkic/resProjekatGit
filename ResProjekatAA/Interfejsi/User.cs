using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    public class User
    {
        private string username;
        private string lozinka;
        private string rola;

        public string Username { get => username; set => username = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Rola { get => rola; set => rola = value; }
    }
}

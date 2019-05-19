using Interfejsi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSProjekatJSON
{
    public class PisanjeJSON
    {
        public void Pisi(string username, string lozinka)
        {
            List<User> lista = new List<User>();
            lista.Add(new User()
            {
                Username = username,
                Lozinka = lozinka,
                Rola = "admin"
            });

            string json = JsonConvert.SerializeObject(lista.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"C:\Users\Korisnik\Desktop\json.txt", json);
        }
    }
}

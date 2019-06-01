using Interfejsi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

            using (StreamReader r = new StreamReader(@"..\json.txt"))
            {
                string json = r.ReadToEnd();
                lista = JsonConvert.DeserializeObject<List<User>>(json);
            }
            
            lista.Add(new User()
            {
                Username = username,
                Lozinka = lozinka,
                Rola = "admin"
            });

            string jsonTekst = JsonConvert.SerializeObject(lista.ToArray());

            string path = @"..\json.txt";

            File.WriteAllText(path, jsonTekst);
        }
    }
}

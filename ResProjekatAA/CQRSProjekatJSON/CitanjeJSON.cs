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
    public class CitanjeJSON
    {
        
        public User citaj(string username)
        {
            List<User> items;

            using (StreamReader r = new StreamReader(@"C:\Users\Korisnik\Desktop\json.txt"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<User>>(json);
            }

            foreach (User item in items)
            {
                if (item.Username == username)
                    return item;
            }

            var result = items.Find(item => item.Username == username);
          

            return result;
        }
        
    }
}

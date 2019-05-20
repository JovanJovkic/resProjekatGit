using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSProjekatDB
{
    public class PisanjeDB
    {
        public void Pisi(string username, string lozinka, string rola)
        {
            var context = new Users_databaseEntities();
            var user = new User
            {
                username = username,
                lozinka = lozinka,
                rola = rola
            };

            User u = context.Users.Find(username);

            if (u == null)
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}

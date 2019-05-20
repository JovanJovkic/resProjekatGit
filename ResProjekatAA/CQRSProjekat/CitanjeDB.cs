using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSProjekatDB
{
    public class CitanjeDB
    {
        public User Citaj(string username)
        {
            var context = new Users_databaseEntities();
            var temp = context.Users.Where(s => s.username == username).ToList<User>();

            foreach (User item in temp)
            {
                return item;
            }

            return null;
        }
    }
}

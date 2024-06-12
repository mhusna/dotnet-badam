using MehmetHusnaKisla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Data.Manager
{
    public class UserManager : BaseManager<User>
    {
        public User GetUserByUserNameAndPassword(string userName, string password)
        {
            User user = _dbSet.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            return user;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositries._GenericRepository;
using UMS_DAL.Repositries.Majors;

namespace UMS_DAL.Repositries.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(UmsContext umsContext) : base(umsContext)
        {
        }

        public User GetUserByUsername(string username)
        {
            return _dbSet.Where(x => x.Username == username).FirstOrDefault();
            
        }
    }
}

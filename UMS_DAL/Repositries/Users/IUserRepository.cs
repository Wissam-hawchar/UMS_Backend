using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositries._GenericRepository;

namespace UMS_DAL.Repositries.Users
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetUserByUsername(string username);
    }
}

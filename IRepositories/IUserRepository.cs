using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByUserAndPassword(string email, string password);
        User GetByEmail(string email);

        User GetUserAllDetails(int id);
        List<User> GetUsersAllDetails();
    }
}

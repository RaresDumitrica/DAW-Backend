using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IRepositories
{
    public interface IUserRoleRepository : IGenericRepository<UserRole>
    {
        UserRole GetUserRoleAllDetails(int id);
        List<UserRole> GetUserRolesAllDetails();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IRepositories
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Role GetRoleAllDetails(int id);
        List<Role> GetRolesAllDetails();
    }
}

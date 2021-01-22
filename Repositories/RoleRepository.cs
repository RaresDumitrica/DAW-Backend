using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Data;
using DawAppWithAngular.IRepositories;
using DawAppWithAngular.Entities;
using Microsoft.EntityFrameworkCore;

namespace DawAppWithAngular.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(TicketContext context) : base(context)
        {

        }

        public Role GetRoleAllDetails(int id)
        {
            return _table.Where(arg => arg.RoleId == id)
                .FirstOrDefault();
        }

        public List<Role> GetRolesAllDetails()
        {
            return _table
                .ToList();
        }
    }
}

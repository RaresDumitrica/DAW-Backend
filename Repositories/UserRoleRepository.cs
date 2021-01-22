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
    public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(TicketContext context) : base(context)
        {

        }

        public UserRole GetUserRoleAllDetails(int id)
        {
            return _table.Where(arg => arg.UserRoleId == id)
                .Include(ur => ur.User)
                .Include(ur => ur.Role)
                .FirstOrDefault();
        }

        public List<UserRole> GetUserRolesAllDetails()
        {
            return _table
                .Include(ur => ur.User)
                .Include(ur => ur.Role)
                .ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IServices
{
    public interface IUserRoleService
    {
        UserRole Create(UserRole role);
        UserRole Get(int id);
        UserRole Update(UserRole role);
        bool Delete(int id);
        List<UserRole> GetAll();
    }
}

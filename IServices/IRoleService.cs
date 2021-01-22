using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IServices
{
    public interface IRoleService
    {
        Role Create(Role role);
        Role Get(int id);
        Role Update(Role role);
        bool Delete(int id);
        List<Role> GetAll();
    }
}

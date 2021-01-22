using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IServices
{
    public interface ICategoryService
    {
        Category Create(Category cat);
        Category Get(int id);
        Category Update(Category cat);
        bool Delete(int id);
        List<Category> GetAll();
    }
}

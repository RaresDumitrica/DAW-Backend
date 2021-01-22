using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetCategoryAllDetails(int id);
        List<Category> GetCategoriesAllDetails();
    }
}

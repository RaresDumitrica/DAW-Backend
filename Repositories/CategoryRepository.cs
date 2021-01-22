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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TicketContext context) : base(context)
        {

        }

        public Category GetCategoryAllDetails(int id)
        {
            return _table.Where(arg => arg.CategoryId == id)
                .FirstOrDefault();
        }

        public List<Category> GetCategoriesAllDetails()
        {
            return _table
                .ToList();
        }
    }
}

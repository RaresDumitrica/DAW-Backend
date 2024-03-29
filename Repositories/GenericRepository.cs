﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Data;
using DawAppWithAngular.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DawAppWithAngular.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly TicketContext _context;
        protected readonly DbSet<T> _table;

        public GenericRepository(TicketContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void CreateRange(List<T> entities)
        {
            _table.AddRange(entities);
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
        }

        public T FindById(int id)
        {
            return _table.Find(id);
        }

        public T FindByIdAndForget(int id)
        {
            var result = _table.Find(id);
            _context.Entry(result).State = EntityState.Detached;
            return result;
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(T entity)
        {
            _table.Update(entity);
        }
    }
}

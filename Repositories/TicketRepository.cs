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
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(TicketContext context) : base(context)
        {

        }

        public Ticket GetTicketAllDetails(int id)
        {
            return _table.Where(arg => arg.TicketId == id)
                .Include(note => note.User)
                .Include(note => note.Category)
                .FirstOrDefault();
        }

        public List<Ticket> GetTicketsAllDetails()
        {
            return _table
                .Include(note => note.Category)
                .Include(note => note.User)
                .ToList();
        }
    }
}

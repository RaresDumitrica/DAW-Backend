using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IRepositories
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
        Ticket GetTicketAllDetails(int id);
        List<Ticket> GetTicketsAllDetails();
    }
}

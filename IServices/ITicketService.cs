using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.IServices
{
    public interface ITicketService
    {
        Ticket Create(Ticket ticket);
        Ticket Get(int id);
        Ticket Update(Ticket ticket);
        bool Delete(int id);
        List<Ticket> GetAll();
    }
}

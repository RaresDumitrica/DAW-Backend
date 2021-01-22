using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;
using DawAppWithAngular.IServices;
using DawAppWithAngular.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace DawAppWithAngular.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public Ticket Create(Ticket ticket)
        {
            _ticketRepository.Create(ticket);
            _ticketRepository.SaveChanges();

            return _ticketRepository.GetTicketAllDetails(ticket.TicketId);
        }

        public bool Delete(int id)
        {
            var entity = _ticketRepository.FindById(id);
            if (entity != null)
            {
                _ticketRepository.Delete(entity);
                _ticketRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Ticket Get(int id)
        {
            return _ticketRepository.GetTicketAllDetails(id);
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepository.GetTicketsAllDetails();
        }

        public Ticket Update(Ticket ticket)
        {
            if (_ticketRepository.FindByIdAndForget(ticket.TicketId) == null) return null;
            _ticketRepository.Update(ticket);
            _ticketRepository.SaveChanges();
            return _ticketRepository.GetTicketAllDetails(ticket.TicketId);
        }
    }
}

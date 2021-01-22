using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Helper;
using DawAppWithAngular.Entities;
using DawAppWithAngular.IServices;
using DawAppWithAngular.Models;

namespace DawAppWithAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: api/<TicketController>
       // [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ticketService.GetAll());
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_ticketService.Get(id));
        }

        // POST api/<TicketController>
        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            var result = _ticketService.Create(ticket);
            return Ok(result);
        }

        // PUT api/<TicketController>
        [HttpPut]
        public IActionResult Update(Ticket ticket)
        {
            return Ok(_ticketService.Update(ticket));
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ticketService.Delete(id));
        }
    }
}

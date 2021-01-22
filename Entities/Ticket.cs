using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DawAppWithAngular.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Color { get; set; }
        public string DateCreated { get; set; }
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
    }
}

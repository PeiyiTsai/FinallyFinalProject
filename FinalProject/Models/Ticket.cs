using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TicketID { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public int Price { get; set; }
        

        public virtual ICollection<Order> Orders { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("代碼")]
        public int TicketID { get; set; }
        [DisplayName("票別")]
        public string Type { get; set; }
        [DisplayName("對象")]
        public string Content { get; set; }
        [DisplayName("價錢")]
        public int Price { get; set; }
        

        public virtual ICollection<Order> Orders { get; set; }
    }
}
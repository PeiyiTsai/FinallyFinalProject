using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{


    public class Order
    {

        public int OrderID { get; set; }
        public byte MemberID { get; set; }
        public int TicketID { get; set; }
        /* public Amount? Amount { get; set; }*/

        public virtual Member Member { get; set; }
        public virtual Ticket Ticket { get; set; }


        
        [DisplayName("購買數量")]
        public byte Amount {  get; set; }

            


    }
}


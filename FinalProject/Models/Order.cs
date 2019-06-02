using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{

    public enum Amount 
        {
            A=1 , B=2 , C=3 , D=4 , E=5 , F=6
        }
    public class Order
    {
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public int TicketID { get; set; }
        public Amount? Amount { get; set; }

        public virtual Member Member { get; set; }
        public virtual Ticket Ticket { get; set; }
        public int Amount2 { get; internal set; }
    }
    }

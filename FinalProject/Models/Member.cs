using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public enum Sex
    {
        男 , 女
    }
    public class Member
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("會員代碼")]
        [Key]
        public byte MemberID { get; set; }
        [DisplayName("會員姓名")]
        public string Name { get; set; }
        [DisplayName("性別")]

        public Sex Sex { get; set; }
        public int Sex2 { get; set; }

        
    
        /*public string Sex { get; set; }*/
        [DisplayName("連絡電話")]
        public string Phone { get; set; }
        [DisplayName("地址")]
        public string Address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("會員購買日期")]
        public DateTime MemberDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
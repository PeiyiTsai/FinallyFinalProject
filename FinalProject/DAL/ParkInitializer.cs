using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.DAL
{
    public class ParkInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ParkContext>
    {
        protected override void Seed(ParkContext context)
        {
            var members = new List<Member>
            { 
                new Member{MemberID=1,Name="吳世昌", Sex="Boy",Phone="0912345678",Address="台北市松山區中山路123號",OrderDate=DateTime.Parse("2019-05-31")},
                new Member{MemberID=2,Name="余宜臻", Sex="Girl",Phone="0979555666",Address="台南市安南區西門路43號",OrderDate=DateTime.Parse("2019-05-31")},
                new Member{MemberID=3,Name="何佳琪", Sex="Girl",Phone="0912124358",Address="高雄市旗津區中港路87號",OrderDate=DateTime.Parse("2019-06-11")},
                new Member{MemberID=4,Name="蔡家祥", Sex="Boy",Phone="0987333568",Address="桃園市觀音區觀音路3段23號",OrderDate=DateTime.Parse("2018-12-31")},
                new Member{MemberID=5,Name="呂文賢", Sex="Boy",Phone="0929568123",Address="台北市士林區中山二路65號",OrderDate=DateTime.Parse("2019-01-01")},
                new Member{MemberID=6,Name="江玟君", Sex="Girl",Phone="0924568712",Address="台南市歸仁區長榮路1段1號",OrderDate=DateTime.Parse("2019-03-05")},
                new Member{MemberID=7,Name="方裕翰", Sex="Boy",Phone="0971568234",Address="新竹縣峨眉鄉峨眉路1號",OrderDate=DateTime.Parse("2018-11-30")},
                new Member{MemberID=8,Name="李宗屏", Sex="Boy",Phone="0984659873",Address="基隆市暖暖區暖心路2段3號",OrderDate=DateTime.Parse("2019-04-20")},
                new Member{MemberID=9,Name="陳麗伶", Sex="Girl",Phone="0955465897",Address="台中市大甲區進步路168號",OrderDate=DateTime.Parse("2019-02-28")},
                new Member{MemberID=10,Name="陳恆婷", Sex="Girl",Phone="0963559872",Address="新北市平溪區平安路5段8號",OrderDate=DateTime.Parse("2018-10-10")},
                new Member{MemberID=11,Name="張怡潔", Sex="Girl",Phone="0963228694",Address="高雄市甲仙區甲仙路68號",OrderDate=DateTime.Parse("2018-11-11")}
            };

            members.ForEach(s => context.Members.Add(s));
            context.SaveChanges();
            var tickets = new List<Ticket>
            {
                new Ticket{TicketID=0001,Type="成人票",Content="一般成人",Price=899},
                new Ticket{TicketID=0002,Type="軍警學生票",Content="國中(含)以上學生及軍警",Price=699},
                new Ticket{TicketID=0003,Type="學童票",Content="7-12歲或121cm以上之學童對象",Price=599},
                new Ticket{TicketID=0004,Type="樂齡票",Content="60歲(含)以上長者。孕婦並持有媽媽手冊",Price=399},
                new Ticket{TicketID=0005,Type="幼童愛心票",Content="3～6歲或100~120cm以下幼童。身障朋友及陪同者一名(憑手冊或身心障礙證明購票)",Price=350},
                new Ticket{TicketID=0006,Type="午後票",Content="13:00以後7-12歲以上對象入園(含成人)",Price=450}

            };
            tickets.ForEach(s => context.Tickets.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
                new Order{MemberID=1,TicketID=0001,Amount2=(int)Amount.B},
                new Order{MemberID=1,TicketID=0004,Amount2=(int)Amount.A},
                new Order{MemberID=1,TicketID=0005,Amount2=(int)Amount.A},
                new Order{MemberID=2,TicketID=0002,Amount2=(int)Amount.B},
                new Order{MemberID=2,TicketID=0001,Amount2=(int)Amount.C},
                new Order{MemberID=3,TicketID=0001,Amount2=(int)Amount.B},
                new Order{MemberID=3,TicketID=0003,Amount2=(int)Amount.B},
                new Order{MemberID=4,TicketID=0006,Amount2=(int)Amount.F},
                new Order{MemberID=5,TicketID=0001,Amount2=(int)Amount.D},
                new Order{MemberID=5,TicketID=0001,Amount2=(int)Amount.D},
                new Order{MemberID=6,TicketID=0004,Amount2=(int)Amount.B},
                new Order{MemberID=7,TicketID=0006,Amount2=(int)Amount.E},
                new Order{MemberID=8,TicketID=0001,Amount2=(int)Amount.E},
                new Order{MemberID=8,TicketID=0004,Amount2=(int)Amount.C},
                new Order{MemberID=8,TicketID=0005,Amount2=(int)Amount.B},
                new Order{MemberID=9,TicketID=0002,Amount2=(int)Amount.F}
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
        }
    }
}
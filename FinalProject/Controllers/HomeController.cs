using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.DAL;
using FinalProject.Viewmodel;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private ParkContext db = new ParkContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<OrderDateGroup> data = from member in db.Members
                                                   group member by member.MemberDate into dateAmount
                                              select new OrderDateGroup()
                                                   {
                                                       OrderDate = dateAmount.Key,
                                                       MemberCount = dateAmount .Count()
                                                   };
            return View(data.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

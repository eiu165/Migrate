using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }



        private readonly MigrateContext _context = new MigrateContext();
         


        public ActionResult Create(Customer c)
        {
            _context.Customers.Add(c);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Customers()
        { 
            return View(_context.Customers); 
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

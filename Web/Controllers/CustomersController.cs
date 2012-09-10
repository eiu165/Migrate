using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CustomersController : Controller
    {

        public ActionResult Index()
        {
            var r = (_context.Customers); 

            return View(r);
        }


        private readonly SupplyContext _context = new SupplyContext();


     
       public ActionResult Create(Customer c)
       {
           _context.Customers.Add(c);
           _context.SaveChanges();

           return RedirectToAction("Index");
       }



    }
}

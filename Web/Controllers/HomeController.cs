using System.Web.Mvc;
using Web.Models;


namespace Web.Controllers
{
	public class HomeController : Controller
	{
        private readonly AppDbContext _context = new AppDbContext();

        public ActionResult Index()
        {
            return View(_context.Users);
        }

        public ActionResult About()
        {
            return View();
        }

		public ActionResult Create(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}

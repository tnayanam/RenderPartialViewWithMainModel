using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using WebApplication3.Models;



namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            //var email = _context.Users.Where(c => c.Id == userId).First().Email;
            ViewBag.userId = userId;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Show(string text)
        {
            ViewBag.Message = text;
            return PartialView();
        }
    }
}
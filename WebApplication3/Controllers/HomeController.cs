using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;



namespace WebApplication3.Controllers
{
    [Authorize] // Allows only logged in user to hit any of the function in thecontroller.
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


            // get first and only result using lINQ
            //var email = _context.Users.Where(c => c.Id == userId).First().Email;
            //ViewBag.userId = userId;
            //TempData["User"] = "This is temp";
            return View();
        }

        public ActionResult Details()
        {
            var userId = User.Identity.GetUserId();

            // find an entry directly based on the id from DBSET
            var f = _context.Users.Find(userId);
            return View(f);
        }

        public ActionResult DetailsForAdmin(string id)
        {

            //var userId = User.Identity.GetUserId();
            // find an entry directly based on the id from DBSET

            var f = _context.Users.Find(id);
            //returning some other view and with some data
            return View("Details", f);
        }

        public ActionResult ListOfAllUser()
        {

            //all the stuff from Database
            return View(_context.Users.ToList());

        }

        [SomeRule]
        public ActionResult About()
        {
            string data;
            if (TempData["User"] != null)
            {
                data = TempData["User"] as string;
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [SomeRule(prop = "one")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [SomeRule(prop = "two")]
        public ActionResult Show(string text)
        {
            ViewBag.Message = text;
            return PartialView();
        }
    }

    public enum Hello
    {
        sim = 1
    }
}
using Microsoft.AspNet.Identity;
using System;
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

        public ActionResult Htmlcontent()
        {
            return View();
        }

        public PartialViewResult All()
        {
            System.Threading.Thread.Sleep(4000);
            var students = _context.Students.ToList();
            return PartialView("_Student", students);
        }

        public PartialViewResult Top3()
        {
            var students = _context.Students.OrderByDescending(s => s.Age).Take(3);
            return PartialView("_Student", students);
        }

        public PartialViewResult Bottom3()
        {
            // get top three or bottom three LINQ Queries for that
            var students = _context.Students.OrderBy(s => s.Age).Take(3);
            return PartialView("_Student", students);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Htmlcontent(string Comments)
        {
            return View();
        }

        public ActionResult PartialViewContainer()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            // throw new Exception("Code no handled");
            // receiving the value from ajax success 
            int val = Convert.ToInt32(TempData["Val"]);
            var userId = User.Identity.GetUserId();

            // get first and only result using lINQ
            var email = _context.Users.Where(c => c.Id == userId).First().Email;
            ViewBag.userId = userId;
            TempData["User"] = "This is temp";
            return View();
        }

        [ActionName("List")]
        [OutputCache(CacheProfile = "1MinuteCache")]
        public ActionResult Details()
        {
            var userId = User.Identity.GetUserId();

            // find an entry directly based on the id from DBSET
            var f = _context.Users.Find(userId);
            return View("Details", f);
        }

        public ActionResult DetailsForAdmin(string id)
        {

            //var userId = User.Identity.GetUserId();
            // find an entry directly based on the id from DBSET

            var f = _context.Users.Find(id);
            //returning some other view and with some data
            return View("Details", f);
        }

        [NonAction]
        public ActionResult ListOfAllUser()
        {

            //all the stuff from Database
            return View(_context.Users.ToList());

        }

        [SomeRule]
        public ActionResult About()
        {
            string data;
            TempData["Val"] = 2;
            if (TempData["User"] != null)
            {
                data = TempData["User"] as string;
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        [RequireHttps]
        public ActionResult About(int id)
        {
            string data;
            TempData["Val"] = 2;
            if (TempData["User"] != null)
            {
                data = TempData["User"] as string;
            }
            ViewBag.Message = "Your application description page.";

            return Json(true);
        }

        //[SomeRule(prop = "one")]
        [ActionName("Contact")]
        [OutputCache(CacheProfile = "1MinuteCache")]

        public ActionResult Contact_Abcd()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public PartialViewResult Hell()
        {
            return PartialView("_TempPartialView"); // second argument can be passed as data or model if required.
        }

        [SomeRule(prop = "two")]
        public ActionResult Show(string text)
        {
            ViewBag.Message = text;
            return PartialView();
        }

        public ActionResult shows()
        {
            //one department can have many employees and one employee can only be parrt of one department
            // below LINQ query fetches the count of employees belonging to each department\
            var x = _context.Employees.Include("Department").GroupBy(e => e.Department.Name).ToList();
            var px = _context.Employees.Include("Department").GroupBy(e => e.Department.Name)
            .Select(y => new MyViewModel
            {
                Department = y.Key,
                count = y.Count()
            }).ToList();

            //var x = _context.Employees.Include("Department").ToList().GroupBy(e => e.DepartmentId).Select(y => new MyViewModel { Department = y.First().Department.Name, count = y.Count() });


            //_context.Employees.Include("Department").ToList().GroupBy(e => e.DepartmentId)


            return View(x);
        }

        public JsonResult GetAjax(int dataInt, string dataString)
        {
            return Json("asdf", JsonRequestBehavior.AllowGet);
        }
    }

    public enum Hello
    {
        sim = 1
    }

}
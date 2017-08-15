using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication3.Models;

// **************************************************************************************************************************************** //

// LINQ Query can be written in many ways. 1. LINQ Query like SQl 2. LINQ Query like Lambda expression. I like the lambda ones. 

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

        public JsonResult GetStudents(string term)
        {
            List<string> students;

            students = _context.Students.Where(s => s.Name.StartsWith(term))
                .Select(y => y.Name).ToList();

            return Json(students, JsonRequestBehavior.AllowGet);
        }

        // LINQ => LINQ providers(converts LINQ query to SQL) => TRANSACT SQL
        public ActionResult PartialViewContainer()
        {
            var students = _context.Students.ToList();
            //var f = from x in _context.Students select x.Name;
            return View(students);
        }

        [HttpPost]
        public ActionResult PartialViewContainer(string searchTerm)
        {
            List<Student> students;
            if (string.IsNullOrEmpty(searchTerm))
            {
                students = _context.Students.ToList();
            }
            else
            {
                students = _context.Students.Where(s => s.Name.StartsWith(searchTerm)).ToList();
            }
            return View(students);
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            //// throw new Exception("Code no handled");
            //// receiving the value from ajax success 
            //int val = Convert.ToInt32(TempData["Val"]);
            //var userId = User.Identity.GetUserId();

            //// get first and only result using lINQ
            //var email = _context.Users.Where(c => c.Id == userId).First().Email;
            //ViewBag.userId = userId;
            //TempData["User"] = "This is temp";
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

        //email
        // ToDo: need to make ie secure
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFrom model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(model.FromEmail));  // replace with valid value 
                message.From = new MailAddress("consultancybridgehelp@gmail.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "consultancybridgehelp@gmail.com",  // replace with valid value
                        Password = "CBridge_007"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

        public ActionResult Sent()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }
        public ActionResult CoverLetter()
        {
            return View();
        }
        public ActionResult Account()
        {
            return View();
        }
        public ActionResult Rewards()
        {
            return View();
        }

        public JsonResult JsonData()
        {
            var dropdowndata = new List<SelectListItem>();
            dropdowndata.Add(new SelectListItem { Text = "One", Value = "1" });
            dropdowndata.Add(new SelectListItem { Text = "Two", Value = "2" });
            dropdowndata.Add(new SelectListItem { Text = "Three", Value = "3" });
            dropdowndata.Add(new SelectListItem { Text = "Four", Value = "4" });
            return Json(dropdowndata, JsonRequestBehavior.AllowGet);
        }

        [Authorize(Roles = "Manager")]
        public ActionResult ForManager()
        {
            return View();
        }

        public ActionResult ForOwner()
        {
            return View();
        }

    }

    public enum Hello
    {
        sim = 1
    }

}

////Git commands

//1. git init
//2. git add .
//3. git commit -m "Add the commit name"
//4. git push
//5. git clone

/* create a new repo
create a new folder
create the basic VS solution there
create a repo in git
 * and now locate that folder in git CMD and then 
 * git init
 * git add .
 * git commit -m "repo link" 
 * git push -u ------------------- origin master
 * and now run the commnand as git status, and it should tell that everything is in sync ewith repo.
  
 */

/*
 * Local Publish
 * go to the web site and right click and  select "Publish"
 * in profile select "LocalPublish" in the dropdown
 * and now put the folder where you want to publish the code.
 * an then you can click on publish
 * ideally it will create a publish file. and you can copy paste all of them to the actual server where LIVE code in hosted.
*/
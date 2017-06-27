using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CourseEnumsController : Controller
    {
        // GET: CourseEnums
        public ActionResult Index()
        {
            CourseEnumsModel model = new CourseEnumsModel();
            System.Web.HttpContext.Current.Session["sessionString"] = "Hello World";
            return View(model);
        }

        // POST: CourseEnums
        [HttpPost]
        public ActionResult Index(CourseEnumsModel model)
        {
            // busiess logic here

            return RedirectToAction("Show");
        }

        // GET: CourseEnums
        public ActionResult Show()
        {
            return Content((string)(System.Web.HttpContext.Current.Session["sessionString"]));
        }
    }
}
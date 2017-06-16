using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            return View(model);
        }

        // POST: CourseEnums
        [HttpPost]
        public ActionResult Index(CourseEnumsModel model)
        {
            // business logic here
            return View();
        }
    }
}
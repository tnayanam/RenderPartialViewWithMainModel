﻿using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class FormController : Controller
    {
        private ApplicationDbContext _context;

        public FormController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Form
        public ActionResult Create()
        {
            return View();
        }

        public JsonResult IsAgeUnique(int age)
        {
            var r = true;
            if (_context.Forms.Any(f => f.age == age))
            {
                r = false;
            }
            //var x = Json(_context.Forms.Any(f => f.age == age), JsonRequestBehavior.AllowGet);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
    }
}
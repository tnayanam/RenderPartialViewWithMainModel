﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class CityController : Controller
    {
        private ApplicationDbContext _context;
        public CityController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: City
        public ActionResult Index()
        {
            return View();
        }
        // GET: City
        public ActionResult List()
        {
            var r = _context.Cities.ToList();
            var e = _context.Cities.Select(c => new { Name = c.CityName, Cityid = c.Id });

            var f = _context.Cities.Select(c => new { Name = c.CityName + " " + c.CityName, Cityid = c.Id });


            return View(r);
        }

        [HttpPost]
        public ActionResult Delete(IEnumerable<int> listOfCityIdToDelete)
        {
            var r = _context.Cities.Where(c => listOfCityIdToDelete.Contains(c.Id)).ToList();
            _context.Cities.RemoveRange(r);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Student()
        {
            // when I just want one result from LINQ Query, multiple calls.
            var x = _context.Students.Where(s => (s.Amount == 23) && (s.Age == 35)).SingleOrDefault();
            return View();
        }

    }
}
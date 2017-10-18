using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModel;


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

            List<Project> Projects = new List<Project>();
            Project proj1 = new Project { Name = "Cognizant", Cities = new List<string> { "Chennai", "Bangalore" } };
            Project proj2 = new Project { Name = "TCS", Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };

            Projects.Add(proj1);
            Projects.Add(proj2);
            // creates a collection of string found in the collection of native class.
            // example: output: "Chennai", "Benaglore", "Chennai", "Bangalore", "Delhi"
            // here Cities: needs to be collection
            var f1 = Projects.SelectMany(p => p.Cities);
            // example: output: "Chennai", "Benaglore", "Delhi"
            var f2 = Projects.SelectMany(p => p.Cities).Distinct();

            // Now suppse we want to display the project name too along with the city name
            // Output: Cognizant-Chennai, Cognizant-Bangalore
            var result = Projects.SelectMany(p => p.Cities, (Name, City) => new { ProjName = Name, CityName = City });
            // Write to console.
            foreach (var res in result)
            {
                Debug.Write(res.ProjName.Name + "-" + res.CityName);
            }
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
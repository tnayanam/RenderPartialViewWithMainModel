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
            Project proj1 = new Project { Name = "Cognizant", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore" } };
            Project proj2 = new Project { Name = "TCS", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };
            Project proj3 = new Project { Name = "CTS", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };
            Project proj4 = new Project { Name = "CSS", Distance = 600, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };

            Projects.Add(proj1);
            Projects.Add(proj2);
            Projects.Add(proj3);
            Projects.Add(proj4);
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

            //Orderby operator
            var w2 = _context.Cities.OrderBy(c => c.CityName);

            var w3 = _context.Cities.OrderByDescending(c => c.CityName);

            // chaining the order by clause
            var t3 = Projects.OrderBy(c => c.Distance).ThenBy(c => c.Name);

            var t8 = _context.Cities.Sum(c => c.Id);

            var t4 = Projects.Take(2);


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
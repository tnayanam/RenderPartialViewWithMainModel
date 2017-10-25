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
            Project proj1 = new Project { Id = 1, Name = "Cognizant", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore" } };
            Project proj2 = new Project { Id = 2, Name = "TCS", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };
            Project proj3 = new Project { Id = 3, Name = "CTS", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };
            Project proj4 = new Project { Id = 4, Name = "CSS", Distance = 600, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };
            Project proj5 = new Project { Id = 1, Name = "Cognizant", Distance = 1900, Cities = new List<string> { "Chennai", "Bangalore" } };
            Project proj6 = new Project { Id = 2, Name = "TCS", Distance = 2900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };
            Project proj7 = new Project { Id = 3, Name = "CTS", Distance = 3900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };
            Project proj8 = new Project { Id = 4, Name = "CSS", Distance = 4600, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" } };


            Projects.Add(proj1);
            Projects.Add(proj2);
            Projects.Add(proj3);
            Projects.Add(proj4);
            Projects.Add(proj5);
            Projects.Add(proj6);
            Projects.Add(proj7);
            Projects.Add(proj8);
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

            // skip first result
            var t5 = Projects.Skip(1);

            // does not work with the Enitty objects

            var t6 = _context.Cities.TakeWhile(c => c.Id > 3);
            var t7 = _context.Cities.SkipWhile(c => c.Id > 3);

            // Deferred Execution: It gets executed when actually we query them. More like Lazy Loading
            // where, select
            // Immediate Execution: It gets executed then and there when we actually execute them.Greedy Loading
            // count, toList

            // --- Conversion Operator
            // ToList
            // ToArray
            // ToDictionary

            //Dictionary<int, string> d1 = Projects.ToDictionary(p => p.Id, p => p.Name);

            //foreach (KeyValuePair<int, string> kvp in d1)
            //{
            //    Debug.Write(kvp.Key + "-" + kvp.Value);
            //}

            // suppose I want result as key: 1,val: {900,1900}
            //                          key: 2,val: {900,2900}
            // 

            var results = Projects.GroupBy(key => key.Id, val => val.Distance).ToDictionary(key => key.Key, val => val.ToList());
            // SO even below gives the same query result as above. and it is simple too. but lookup is immutable and also it can handle same key coming multupiple times unlike dictionary
            var results2 = Projects.ToLookup(key => key.Id, val => val.Distance);

            // problem is we needed to group by first based on Id in case of dictinary because it does not allow duplicate keys and woul have given the exception.
            // however, the normal tolokkup does the group by implicitly so we dnt need it in case of lookup
            // tolookup = groupby + dictionary 
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
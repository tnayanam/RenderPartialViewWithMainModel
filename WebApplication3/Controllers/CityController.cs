using System;
using System.Collections;
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

            var email = _context.Cities.Where(c => c.Id == 3).First().CityName;
            var emails = _context.Cities.First(c => c.Id == 3).CityName;

            //var emaiWls = _context.Cities.Last(c => c.Id == 3).CityName;
            //var emailss = _context.Cities.ElementAt(3);
            //var emailsFGs = _context.Cities.ElementAtOrDefault(3);


            int[] num = { 1, 2, 3 };
            var g = num.DefaultIfEmpty(); // return all three integers
            int[] num1 = { };
            var g1 = num.DefaultIfEmpty(); // return 0 if empty cpolletion

            int[] num1w = { };
            var wg1 = num.DefaultIfEmpty(23); // return 23 if empty collction



            List<Project> Projects = new List<Project>();
            Project proj1 = new Project { Id = 1, Name = "Cognizant", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore" }, IsOk = false };
            Project proj2 = new Project { Id = 2, Name = "TCS", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = false };
            Project proj3 = new Project { Id = 3, Name = "CTS", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = false };
            Project proj4 = new Project { Id = 4, Name = "CSS", Distance = 600, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = false };
            Project proj5 = new Project { Id = 5, Name = "Cognizant", Distance = 1900, Cities = new List<string> { "Chennai", "Bangalore" }, IsOk = true };
            Project proj6 = new Project { Id = 6, Name = "TCS", Distance = 2900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = true };
            Project proj7 = new Project { Id = 7, Name = "CTS", Distance = 3900, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = true };
            Project proj8 = new Project { Id = 8, Name = "CSS", Distance = 4600, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = true };
            Project proj9 = new Project { Id = 9, Name = "Cognizant", Distance = 900, Cities = new List<string> { "Chennai", "Bangalore" }, IsOk = true };
            Project proj10 = new Project { Id = 10, Name = "TCS", Distance = 9050, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = true };
            Project proj11 = new Project { Id = 11, Name = "CTS", Distance = 9040, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = true };
            Project proj12 = new Project { Id = 12, Name = "CSS", Distance = 6030, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = true };
            Project proj13 = new Project { Id = 13, Name = "Cognizant", Distance = 19300, Cities = new List<string> { "Chennai", "Bangalore" }, IsOk = true };
            Project proj14 = new Project { Id = 14, Name = "TCS", Distance = 29030, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = false };
            Project proj15 = new Project { Id = 15, Name = "CTS", Distance = 39030, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = false };
            Project proj16 = new Project { Id = 16, Name = "CSS", Distance = 46020, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = false };

            Projects.Add(proj1);
            Projects.Add(proj2);
            Projects.Add(proj3);
            Projects.Add(proj4);
            Projects.Add(proj5);
            Projects.Add(proj6);
            Projects.Add(proj7);
            Projects.Add(proj8);
            Projects.Add(proj9);
            Projects.Add(proj10);
            Projects.Add(proj11);
            Projects.Add(proj12);
            Projects.Add(proj13);
            Projects.Add(proj14);
            Projects.Add(proj15);
            Projects.Add(proj16);

            var exps = Projects.GroupBy(p => new { p.Name, p.IsOk })
                .OrderBy(p => p.Key.Name)
                .ThenBy(p => p.Key.IsOk)
                .Select(grp => new { Key1 = grp.Key.Name, Key2 = grp.Key.IsOk, Items = grp.OrderBy(i => i.Distance) });


            //foreach (var grp in exps)
            //{
            //    Debug.WriteLine(grp.Key1, " - " + grp.Key2 + "- " + grp.Items.Count());

            //    Debug.WriteLine("-------------------------------------------------------");
            //    foreach (var g in grp.Items)
            //    {
            //        Debug.WriteLine(g.Name + "-" + g.IsOk + "-" + g.Distance);
            //    }
            //}

            // OUTPUT:

            //            -False - 1: Cognizant
            //------------------------------------------------------ -
            //Cognizant - False - 900
            // - True - 3: Cognizant
            // ------------------------------------------------------ -
            // Cognizant - True - 900
            //Cognizant - True - 1900
            //Cognizant - True - 19300
            // - False - 2: CSS
            // ------------------------------------------------------ -
            // CSS - False - 600
            //CSS - False - 46020
            // - True - 2: CSS
            // ------------------------------------------------------ -
            // CSS - True - 4600
            //CSS - True - 6030
            // - False - 2: CTS
            // ------------------------------------------------------ -
            // CTS - False - 900
            //CTS - False - 39030
            // - True - 2: CTS
            // ------------------------------------------------------ -
            // CTS - True - 3900
            //CTS - True - 9040
            // - False - 2: TCS
            // ------------------------------------------------------ -
            // TCS - False - 900
            //TCS - False - 29030
            // - True - 2: TCS
            // ------------------------------------------------------ -
            // TCS - True - 2900
            //TCS - True - 9050


            // groupby:
            var compGroups = Projects.GroupBy(p => p.Name);

            foreach (var grp in compGroups)
            {
                Debug.WriteLine(grp.Key + " - " + grp.Count());
            }




            // conditional groupby:
            var compGrous = Projects.GroupBy(p => p.Name);

            foreach (var grp in compGrous)
            {
                Debug.WriteLine(grp.Key + " - " + grp.Count());
                foreach (var t in grp)
                {
                    Debug.WriteLine(t.Name + "-" + t.Distance);
                }
            }


            // conditional groupby with sorting of the main group by as well as the inside element of the group by:
            var compGro = Projects
                .GroupBy(p => p.Name)
                .OrderBy(p => p.Key)
                .Select(grp => new { Key = grp.Key, Items = grp.OrderByDescending(p => p.Distance) });

            //foreach (var g in compGro)
            //{
            //    Debug.WriteLine(g.Key + " -- ");
            //    foreach (var t in g.Items)
            //    {
            //        Debug.WriteLine(g.Key + "\t" + t.Distance);
            //    }
            //}




            //var isOkselectId = Projects.Single(p => p.IsOk).Id;

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
            //foreach (var res in result)
            //{
            //    Debug.Write(res.ProjName.Name + "-" + res.CityName);
            //}

            // now conditional group by


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

            // As enummerable : Query written before it gets executed as LINQ to SQL
            // where as query after it gets executed LINQ TO Objects.
            var t9 = Projects.AsEnumerable().Where(c => c.Id > 2);

            //Project proj9 = new Project { Id = 4, Name = "CSS", Distance = 4600, Cities = new List<string> { "Chennai", "Bangalore", "Delhi" }, IsOk = false };
            //Projects.Add(proj9);

            // the query in the where clause will be exec
            foreach (var u in t9)
            {
                Debug.Write(u.Id + "\n");
            }

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

            ArrayList al = new ArrayList();
            al.Add(1); // here 1 is object not an integer
            al.Add(2);
            al.Add("1");
            al.Add("tanuj");

            // Since tanuj string cannot be converted to integer type it will throw an exception while looping, the linq query itsef will not throw the exception
            // because it is deferred execution so when we start looping we get the exception.

            IEnumerable<int> resultdd = al.Cast<int>();

            //foreach (int re in resultdd)
            //{
            //    Debug.Write(re + "\t");
            //}

            ArrayList al1 = new ArrayList();
            al1.Add(1); // here 1 is object not an integer
            al1.Add(2);
            al1.Add("1");
            al1.Add("tanuj");
            IEnumerable<int> resud = al.OfType<int>();

            // exception wil not be thrown here, as cast will ignpre thetype which cannot be converted.
            foreach (int re in resud)
            {
                Debug.Write(re + "\t");
            }

            //-------------------------------------------------------------------------------------------------------//
            // basically below will tell Maths has who all stude4nts enroilled and science has who all students enrolled
            // Outer Join 
            var candidateByCourse = Course.GetAllCourses()
                .GroupJoin(Candidate.GetAllCandidates(),
                c => c.Id,
                ca => ca.CourseId,
                (course, candidates) => new
                {
                    Course = course,
                    Candidates = candidates
                });

            foreach (var course in candidateByCourse)
            {
                Debug.WriteLine(course.Course.CourseName);
                foreach (var candidate in course.Candidates)
                {
                    Debug.WriteLine(candidate.Name);
                }
                Debug.WriteLine("--------------------------------");
            }


            // output

            //Maths
            //Tanuj
            //Raz
            //--------------------------------
            //Science
            //Nayanam
            //Arundhati
            //Sharma
            //--------------------------------


            //==================
            Debug.WriteLine("******************************");
            var rest = Candidate.GetAllCandidates().Join
                (Course.GetAllCourses(),
                c => c.CourseId,
                ca => ca.Id,
                (candidate, course)
                => new
                {
                    CandidateName = candidate.Name,
                    Course = course.CourseName
                });

            foreach (var course in rest)
            {
                Debug.WriteLine(course.CandidateName + "-" + course.Course);
                Debug.WriteLine("--------------------------------");
            }
            //output just like inner join
            //            Tanuj - Maths
            //--------------------------------
            //Nayanam - Science
            //--------------------------------
            //Arundhati - Science
            //--------------------------------
            //Sharma - Science
            //--------------------------------

            //======================================
            // Left Outer Join
            var re1 = Candidate.GetAllCandidates()
                .GroupJoin(Course.GetAllCourses(),
                ca => ca.CourseId,
                c => c.Id,
                (candidate, courses) =>
                new
                {
                    candidate,
                    courses
                })
                .SelectMany(z => z.courses.DefaultIfEmpty(),
                (a, b) => new
                {
                    CandidateName = a.candidate.Name,
                    CourseName = b == null ? "No couse" : b.CourseName
                });

            foreach (var g12 in re1)
            {
                Debug.WriteLine(g12.CandidateName + "--", g12.CourseName);
                Debug.WriteLine("--");
            }

            // output

            //            Maths: Tanuj--
            //--
            //Science: Nayanam--
            //--
            //Science: Arundhati--
            //--
            //Science: Sharma--
            //--
            //No couse: Raz--

            // Select Many Cross Join

            var rt = Candidate.GetAllCandidates().SelectMany(c => Course.GetAllCourses(), (c, co) => new { c, co });

            foreach (var or in rt)
            {
                Debug.WriteLine(or.c.Name + "\t" + or.co.CourseName);
            }
            // Distinct for complex objects

            var rf = Course.GetAllCourses().Distinct();
            foreach (var or in rf)
            {
                Debug.WriteLine(or.CourseName + "\t" + or.Id);
            }

            // Output:

            // Maths   1
            // Maths   1
            // Maths   2

            // we expected output to be just 2. but we got three because Courese is complex class. so try below

            var rfq = Course.GetAllCourses().Select(c => new { c.Id, c.CourseName }).Distinct();
            foreach (var or in rfq)
            {
                Debug.WriteLine(or.CourseName + "\t" + or.Id);
            }

            // Output: as expected.
            //            Maths   1
            //Maths   2

            // Union
            int[] nu1 = { 1, 2, 3, 4, 5 };
            int[] nu2 = { 1, 3, 5 };
            var t1 = nu1.Union(nu2);

            foreach (var or in t1)
            {
                Debug.WriteLine(or);
            }

            // output
            //            ///1
            //            2
            //3
            //4
            //5

            // Intersect
            int[] nu3 = { 1, 2, 3, 4, 5 };
            int[] nu4 = { 1, 3, 5 };
            var t2 = nu3.Intersect(nu4);

            foreach (var or in t2)
            {
                Debug.WriteLine(or);
            }
            //            // output
            //            1
            //3
            //5


            // Except
            int[] nuq3 = { 1, 2, 3, 4, 5 };
            int[] nuq4 = { 1, 3, 5 };
            var tq2 = nuq3.Intersect(nuq4);

            foreach (var or in tq2)
            {
                Debug.WriteLine(or);
            }
            //            // output
            //            2
            //4

            var evennum = Enumerable.Range(1, 10).Where(c => c % ~2 == 0);

            var evennum1 = Enumerable.Repeat("HJello", 10);

            var res = nuq3.Concat(nuq4);

            string[] str1 = { "USA", "India", "UK" };
            string[] str2 = { "USA", "India", "UK" };

            var seqEql = str1.SequenceEqual(str2); // true

            string[] str3 = { "USA", "India", "UK" };
            string[] str4 = { "USA", "InDia", "UK" };

            var seqEq2 = str3.SequenceEqual(str4); // false

            var seqEq3 = str3.SequenceEqual(str4, StringComparer.OrdinalIgnoreCase); // true

            string[] str5 = { "USA", "India", "UK" };
            string[] str6 = { "India", "USA", "UK" };

            var seqEq4 = str5.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c)); // true

            int[] num4 = { 1, 2, 3, 4, 5 };
            var f3 = num4.All(c => c > 3); // false

            int[] num5 = { 1, 2, 3, 4, 5 };
            var f5 = num4.Any(); // true

            var f9 = num4.Any(c => c > 10); // false

            var d1 = str6.Contains("USA"); // true
            var d2 = str6.Contains("usa"); // false
            var d9 = str6.Contains("usa", StringComparer.OrdinalIgnoreCase); // true


            // Want to test LINQ QUeries use LINQPad Tool
            // https://www.youtube.com/watch?v=reRfw22XG18&index=32&list=PL6n9fhu94yhWi8K02Eqxp3Xyh_OmQ0Rp6




            return View();
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


        public ActionResult State(int month, int year)
        {

            return Content(month + " " + year);
        }

    }
}
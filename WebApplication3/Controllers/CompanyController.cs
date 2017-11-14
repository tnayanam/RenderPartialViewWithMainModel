using System;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CompanyController : Controller
    {
        ApplicationDbContext _context;
        public CompanyController()
        {
            _context = new ApplicationDbContext();
        }
        private void Configure(Company viewModel)
        {
            viewModel.Parkings = _context.Parkings.ToList();
            viewModel.date = DateTime.Now;
            viewModel.Name = "My Company";
        }

        // GET: DropDown
        public ActionResult Index()
        {
            var viewModel = new Company();
            Configure(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        public string Index(Company viewModel)
        {
            return viewModel.selectedRadio;
        }

        // GET: DropDown
        public ActionResult Display()
        {
            var viewModel = new Company();
            viewModel = _context.Companies.Where(c => c.Id == 1).Single();

            return View(viewModel);
        }

        // GET: DropDown
        public ActionResult Edit()
        {
            var viewModel = new Company();
            Configure(viewModel);
            return View(viewModel);
        }

    }
}


// Difference between Const and readonly
// Const
// They can not be declared as static (they are implicitly static)
// The value of constant is evaluated at compile time
// constants are initialized at declaration only

// readonly
// They can be either instance-level or static
// The value is evaluated at run time
// readonly can be initialized in declaration or by code in the constructor

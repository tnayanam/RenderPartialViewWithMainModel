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
        // GET: DropDown
        public ActionResult Index()
        {
            var viewModel = new Company();
            viewModel.Parkings = _context.Parkings.ToList();
            viewModel.Name = "My Company";
            return View(viewModel);
        }

    }
}
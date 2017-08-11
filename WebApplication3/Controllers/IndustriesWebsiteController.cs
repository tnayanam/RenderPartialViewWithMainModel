using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class IndustriesWebsiteController : Controller
    {
        private ApplicationDbContext _context;
        public IndustriesWebsiteController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: IndustriesWebsite
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var viewModel = new IndustriesWebsiteViewModel
            {
                Industries = _context.Industries.ToList()
            };
            return View(viewModel);
        }
    }
}
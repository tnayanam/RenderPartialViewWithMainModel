using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmpController : Controller
    {
        private ApplicationDbContext _context;

        public EmpController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Emp
        public ActionResult Create()
        {
            var s = _context.Depots.ToList();
            var viewModel = new EmpDepotViewModel();
            viewModel.Depots = s;
            return View(viewModel);
        }
    }
}
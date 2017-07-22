using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class DepotController : Controller
    {
        private ApplicationDbContext _context;

        public DepotController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Emp
        public ActionResult Index()
        {
            //-------------------------------// source, // value to be submitted, name to display
            ViewBag.Depots = new SelectList(_context.Depots, "Id", "Name");
            return View();
        }
    }
}
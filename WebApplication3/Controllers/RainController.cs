using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class RainController : Controller
    {
        private ApplicationDbContext _context;

        public RainController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Rain
        public ActionResult Index(int Id = 2)
        {
            var rain = _context.Rains.Single(ra => ra.Id == Id);
            return View();
        }
    }
}
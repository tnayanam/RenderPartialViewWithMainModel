using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ParkingController : Controller
    {
        ApplicationDbContext _context;

        public ParkingController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Parking
        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "Name")
            {
                return View(_context.Parkings.Where(p => p.Name.StartsWith(search)).ToList());

            }
            else if (searchBy == "Location")
            {
                return View(_context.Parkings.Where(p => p.Location.StartsWith(search)).ToList());

            }
            else
            {
                return View(_context.Parkings);
            }

            return View();
        }
    }
}
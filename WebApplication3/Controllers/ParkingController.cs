using PagedList;
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
        public ActionResult Index(string searchBy, string search, int? page, string sortBy)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Name desc" : "";

            var parkings = _context.Parkings.AsQueryable();

            if (searchBy == "Name")
            {
                parkings = _context.Parkings.Where(p => p.Name.StartsWith(search));
            }
            else if (searchBy == "Location")
            {
                parkings = _context.Parkings.Where(p => p.Location.StartsWith(search));

            }
            else
            {
                parkings = _context.Parkings;
            }

            switch (sortBy)
            {
                case "Name desc":
                    parkings = parkings.OrderByDescending(x => x.Name);
                    break;
                default:
                    parkings = parkings.OrderBy(x => x.Name);
                    break;

            }
            return View(parkings.ToPagedList(page ?? 1, 3));
        }
    }
}
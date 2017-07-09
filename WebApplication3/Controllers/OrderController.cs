using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;
        public OrderController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Order
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Order viewModel)
        {
            return View();
        }
    }
}
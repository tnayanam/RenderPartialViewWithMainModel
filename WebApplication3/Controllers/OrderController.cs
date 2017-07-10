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
        [Authorize]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(Order viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(viewModel);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}
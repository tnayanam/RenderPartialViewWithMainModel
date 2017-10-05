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
            ViewBag.Depots = new SelectList(_context.Depots, "Id", "Name", "1");
            return View();
        }
    }
}

/// For deploying any web app on godaddy we need to follow these steps. 
/// //https://stackoverflow.com/questions/46416694/how-to-deploy-asp-net-mvc-5-code-from-visual-studio-to-godaddy-plesk-server-cod
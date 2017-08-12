using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PageController : Controller
    {
        private ApplicationDbContext _context;
        public PageController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Page
        public ActionResult Create()
        {
            var viewModel = new CopyPageViewModel
            {
                Copies = _context.Copies.Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.CopyName
                })
            };
            return View(viewModel);
        }
    }
}
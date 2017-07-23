using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GenreController : Controller
    {
        ApplicationDbContext _context;
        public GenreController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Genre
        public ActionResult Index()
        {
            var x = _context.Genres.ToList();
            return View(x);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Genre viewModel)
        {
            _context.Genres.Add(viewModel);
            _context.SaveChanges();
            return View();
        }

        public ActionResult Display(int id)
        {
            var x = _context.Genres.Single(g => g.Id == id);
            return View(x);
        }

        // GET: Genre
        public ActionResult Edit(int id)
        {
            var x = _context.Genres.Single(g => g.Id == id);
            return View(x);
        }

        [HttpPost]
        public ActionResult Edit(Genre viewModel)
        {
            //here we AreaReference reeiving ghe viewModel.ArtistId even though we have not sent it from the hidden fieed if CSHTML file"
            //var x = _context.Genres.Single(g => g.Id == id);
            return View();
        }
    }
}
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SongController : Controller
    {
        private ApplicationDbContext _context;

        public SongController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Song
        public ActionResult Index()
        {
            var songModel = _context.Songs.ToList();
            return View(songModel);
        }

    }
}
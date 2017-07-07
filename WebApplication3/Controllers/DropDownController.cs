using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class DropDownController : Controller
    {
        // GET: DropDown
        public ActionResult Index()
        {
            DropDownViewModel dropdown = new DropDownViewModel();
            dropdown.SongList.Add(new SelectListItem { Text = "Four", Value = "4" });
            dropdown.SongList.Add(new SelectListItem { Text = "Five", Value = "5" });
            dropdown.SongList.Add(new SelectListItem { Text = "Six", Value = "6" });
            dropdown.SongList.Add(new SelectListItem { Text = "Seven", Value = "7" });

            return View(dropdown);
        }

        // GET: DropDown
        [HttpPost]
        public ActionResult Index(DropDownViewModel viewModel)
        {
            DropDownViewModel dropdown = new DropDownViewModel();
            dropdown.SongList.Add(new SelectListItem { Text = "Four", Value = "4" });
            dropdown.SongList.Add(new SelectListItem { Text = "Five", Value = "5" });
            dropdown.SongList.Add(new SelectListItem { Text = "Six", Value = "6" });
            dropdown.SongList.Add(new SelectListItem { Text = "Seven", Value = "7" });
            return View(dropdown);
        }
    }
}
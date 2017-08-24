using System.Web.Mvc;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class CoverLetterController : Controller
    {
        // GET: CoverLetter
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CoverLetterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // some code
            }
            return View();
        }
    }
}
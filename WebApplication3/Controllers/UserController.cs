using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Fix Below Errors.");
                return View();
            }
            else
                return Content("Everything Alright");
        }
    }
}
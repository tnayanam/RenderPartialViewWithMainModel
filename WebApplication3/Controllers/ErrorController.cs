using System.Web.Mvc;
// the previous git hub checkin workls for al the exception thrown at controller level. But what if resource itself is not found in that case we need to do all this stuff.

namespace WebApplication3.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFound()
        {
            return View();
        }
    }
}

/*
 * How to uninstall a package from git
 * 1. Get-Package
 * 2. Uninstall-Package packagename
*/

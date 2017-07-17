using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3.Controllers
{
    public class SomeRule : System.Web.Mvc.ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            // If someone tries to visit "about" page redirect them to contact page
            if (filterContext.ActionDescriptor.ActionName == "About")
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Home" }, { "action", "Contact" } });
            }

        }
    }
}
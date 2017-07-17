using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3.Controllers
{
    public class SomeRule : System.Web.Mvc.ActionFilterAttribute
    {
        public string prop { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);


            // If someone tries to visit "about" page redirect them to contact page
            if (filterContext.ActionDescriptor.ActionName == "About")
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Home" }, { "action", "Contact" } });
            }

            // if contact is clicked go to Index of Home
            if (prop == "one")
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Home" }, { "action", "Index" } });
            }
            // if contact is clicked go to Index of Song
            if (prop == "two")
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Song" }, { "action", "Index" } });
            }

        }
    }
}
using System.Web.Mvc;

namespace WebApplication3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // what ever added here is added to the entire controller. so error attribute has been added as a whole to all the controller actions.
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AuthorizeAttribute());
            //filters.Add(new RequireHttpsAttribute()); // http address will not be accessible.
        }
    }
}


/*
 * .Net is combination of CLR + Class Library : It's a framework for creating application for windows
 * CLR is more like an application which converts Intermediate Language code to Machine Native code
 * c# code => IL code => Machine Native Code
 * Process of converting IL into Machine native code by CLR is called JIT Just In Time Compiler.
 * Class 
 * Many CLasses => Namespaces
 * Many Namespaces => Assemblies or dll
 * Many dll's => Application
 
     
     */

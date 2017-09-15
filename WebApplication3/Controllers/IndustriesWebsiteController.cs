using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class IndustriesWebsiteController : Controller
    {
        private ApplicationDbContext _context;
        public IndustriesWebsiteController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: IndustriesWebsite
        public ActionResult Index()
        {
            var x = _context.Industries.Where(i => (i.Name == "technology") && i.Websites.Any(w => w.Name == "googhle"));
            return View();
        }

        public ActionResult Create()
        {
            var viewModel = new IndustriesWebsiteViewModel
            {
                Industries = _context.Industries.ToList()
            };
            return View(viewModel);
        }
    }
}

// ISSUE:
//Validation failed for one or more entities while saving changes to SQL Server Database using Entity Framework

//FIx below:
//https://stackoverflow.com/questions/5400530/validation-failed-for-one-or-more-entities-while-saving-changes-to-sql-server-da

//      try
//{
//         if (TryUpdateModel(theEvent))
//         {
//             storeDB.SaveChanges();
//             return RedirectToAction("Index");
//         }
//}
//catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
//{
//    Exception raise = dbEx;
//    foreach (var validationErrors in dbEx.EntityValidationErrors)
//    {
//        foreach (var validationError in validationErrors.ValidationErrors)
//        {
//            string message = string.Format("{0}:{1}",
//                validationErrors.Entry.Entity.ToString(),
//                validationError.ErrorMessage);
//// raise a new exception nesting
//// the current instance as InnerException
//raise = new InvalidOperationException(message, raise);
//        }
//    }
//    throw raise;
//}
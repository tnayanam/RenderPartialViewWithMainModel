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


//FLUENT API ERROR 1:
// WebApplication3.Models.Instrument_Gigs: : Multiplicity conflicts with the
// referential constraint in Role 'Instrument_Gigs_Source' in relationship 'Instrument_Gigs'. Because all of the properties in the Dependent Role are
// non-nullable, multiplicity of the Principal Role must be '1'.

// means one colunmn needs to be nullable as per the fluent api convention but in model that property is not set to nullable "?"
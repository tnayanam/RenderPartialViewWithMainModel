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


// Get a datatable from a strongly types dataset


/* Dataset: dsDirectory
 * Datatable: GroupDataTable
 * Variable in which that datatable's is stored in Dataset is "Group"
 *     dsDirectory groupData = mdlLogViewer.LoadGroupInfoForAccount(ref user, selectedAccountId);
            dsDirectory.GroupDataTable groupTableData = groupData.Tables["Group"] as dsDirectory.GroupDataTable;

            dsDirectory.LocationDataTable locationTableData = groupData.Tables["Location"] as dsDirectory.LocationDataTable;
 * 
 * 
*/

/*
 How to host a website:
 * 1. Buy a domain
 * 2. Buy a server
 * 3. Now you need to tell server/IIS where you want to put the website, I mean where to redirect when the request comes. (if you are using a standard lcoation then you dont need to touch it, 
 * If not then you need to add a physical path there so that it knows if a request comes to it which folder it needs to point to. Also here you tell which port request it should handle. 
 * I mean you can tell that only :80 should be redirected if :4747 is coming it should be redirected to a different port. Here suppose you want to put the code at C://abc then you cna add that
 * also you can add an alias for that website/location say:ABC
 * 4. Now from your local system you when you publish the code you need to tell where to put the code on server. THIS IS called publish profile. It has information on where to put the
 * compiled code on server. Also here you dont need to put the C://abc you can just put the alias which is ABC, and IIS server will understand where to paste the published code because
 * ABC is pointed to c://abc
 * 
 * Site Binding means what are the allowed ports/URL  for this websites
*/
using System.Data.Entity.Infrastructure;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class DocumentController : Controller
    {

        private ApplicationDbContext _context;

        public DocumentController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Document
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Document doc, HttpPostedFileBase uploadedresume)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (uploadedresume != null && uploadedresume.ContentLength > 0)
                    {
                        var tempdoc = new Document
                        {
                            FileName = System.IO.Path.GetFileName(uploadedresume.FileName),
                            ContentType = uploadedresume.ContentType,
                            DocumentName = doc.DocumentName
                        };
                        using (var reader = new System.IO.BinaryReader(uploadedresume.InputStream))
                        {
                            tempdoc.Content = reader.ReadBytes(uploadedresume.ContentLength);
                        }
                        _context.Documents.Add(tempdoc);
                    }
                    _context.SaveChanges();
                    return RedirectToAction("Create");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View("Create");
        }
    }
}
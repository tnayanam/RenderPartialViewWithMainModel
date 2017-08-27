using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class ManagerWorkerController : Controller
    {
        private ApplicationDbContext _context;

        public ManagerWorkerController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: ManagerWorker
        public ActionResult Create()
        {
            var viewModel = new ManagerWorkerViewModel
            {
                Managers = _context.Managers.Select(m => new SelectListItem
                {
                    Text = m.ManagerName,
                    Value = m.ManagerId.ToString()
                })
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(ManagerWorkerViewModel viewModel)
        {
            // this code is now throwing exception becase by defalt if supoose we do not select any manager fot hsi worker
            // then the managerid will be set to zero and that is not present in manager table managerid = 0,
            // hence we need to stop manager id from getting defalt vale as 0, so make it NULLABLE.
            // is it NULLABLE THEN bedefault no vale (0) will be set to it.
            var worker = new Worker
            {
                WorkerName = viewModel.WorkerName,
                ManagerId = viewModel.ManagerId
            };
            _context.Workers.Add(worker);
            _context.SaveChanges();
            return RedirectToAction("Create");
        }

    }
}
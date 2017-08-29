using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class GigController : Controller
    {
        private ApplicationDbContext _context;


        public GigController()
        {
            _context = new ApplicationDbContext();
        }

        private void ConfigureViewModel(GigViewModel viewModel)
        {
            // Populate companies always
            viewModel.MusicTypes = _context.MusicTypes.Select(x => new SelectListItem
            {
                Text = x.MusicTypeName,
                Value = x.MusicTypeId.ToString()
            });

            viewModel.Instruments = _context.Instruments.Select(x => new SelectListItem
            {
                Text = x.InstrumentName,
                Value = x.InstrumentId.ToString()
            });
            // Populate cover letters only if a company has been selected
            // i.e. if your editing and existing Referral, or if you return the view in the POST method
            if (viewModel.MusicTypeId.HasValue)
            {
                viewModel.Instruments = _context.Instruments.Where(x => x.MusicTypeId == viewModel.MusicTypeId.Value).Select(x => new SelectListItem
                {
                    Text = x.InstrumentName,
                    Value = x.InstrumentId.ToString()
                });
            }
            else
            {
                viewModel.Instruments = new SelectList(Enumerable.Empty<SelectListItem>());
            }
        }

        public ActionResult Create()
        {
            GigViewModel viewModel = new GigViewModel();
            ConfigureViewModel(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(GigViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var gig = new Gig
                {
                    GigName = viewModel.GigName,
                    InstrumentId = viewModel.InstrumentId
                };
                if (viewModel.MusicTypeId.HasValue)
                {
                    gig.MusicTypeId = viewModel.MusicTypeId.Value;

                }
                _context.Gigs.Add(gig);
                _context.SaveChanges();
                return RedirectToAction("Create");
            }
            return RedirectToAction("Create");
        }

        public JsonResult GetInstrumentJson(int musicTypeId)
        {
            var instruments = _context.Instruments
                .Where(c => c.MusicTypeId == musicTypeId)
                .ToList();

            var dropdown = new List<SelectListItem>();
            foreach (var cl in instruments)
            {
                dropdown.Add(new SelectListItem { Text = cl.InstrumentName, Value = cl.InstrumentId.ToString() });
            }
            return Json(dropdown, JsonRequestBehavior.AllowGet);
        }
    }
}
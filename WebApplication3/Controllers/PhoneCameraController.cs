using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class PhoneCameraController : Controller
    {
        private ApplicationDbContext _context;

        public PhoneCameraController()
        {
            _context = new ApplicationDbContext();
        }

        //// GET: PhoneCamera
        //public ActionResult Create()
        //{
        //    var viewModel = new PhoneCameraViewModel
        //    {
        //        Cameras = _context.Cameras.Select(x => new SelectListItem
        //        {
        //            Text = x.CameraName,
        //            Value = x.CameraId.ToString()
        //        })
        //    };
        //    return View(viewModel);
        //}
    }
}
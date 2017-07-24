using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class DropDownController : Controller
    {
        // GET: DropDown
        public ActionResult Index()
        {
            //return typeof(Controller).Assembly.GetName().Version.ToString();
            DropDownViewModel dropdown = new DropDownViewModel();
            dropdown.SongList.Add(new SelectListItem { Text = "Four", Value = "4" });
            dropdown.SongList.Add(new SelectListItem { Text = "Five", Value = "5" });
            dropdown.SongList.Add(new SelectListItem { Text = "Six", Value = "6" });
            dropdown.SongList.Add(new SelectListItem { Text = "Value as the ENum itself", Value = ENUMS.SIM.ToString() }); // this will send value of string as "SIM"
            dropdown.SongList.Add(new SelectListItem { Text = "Value as integer of SIM", Value = ((int)ENUMS.SIM).ToString() }); // this will send value of string as "3"
            dropdown.SongList.Add(new SelectListItem { Text = "Seven", Value = "7" });
            dropdown.FirstName = "Tanuj";
            dropdown.LastName = "Nayanam";
            dropdown.RateInDollar = 23;

            return View(dropdown);
        }

        public enum ENUMS
        {
            SIM = 3
        }

        // POST : DropDown
        [HttpPost]
        public ActionResult Index(DropDownViewModel viewModel)
        {
            DropDownViewModel dropdown = new DropDownViewModel();
            dropdown.SongList.Add(new SelectListItem { Text = "Four", Value = "4" });
            dropdown.SongList.Add(new SelectListItem { Text = "Five", Value = "5" });
            dropdown.SongList.Add(new SelectListItem { Text = "Six", Value = "6" });
            dropdown.SongList.Add(new SelectListItem { Text = "Seven", Value = "7" });
            return View(dropdown);
        }

        [HttpPost]
        public JsonResult hello(int id)
        {
            List<SelectListItem> l1 = new List<SelectListItem>();
            if (id == 1)
            {
                l1.Add(new SelectListItem { Text = "Dropdown value for One", Value = "1" });
                l1.Add(new SelectListItem { Text = "1A", Value = "2" });
                l1.Add(new SelectListItem { Text = "1B", Value = "3" });
                l1.Add(new SelectListItem { Text = "1C", Value = "4" });
            }
            if (id == 2)
            {
                l1.Add(new SelectListItem { Text = "Dropdown value for Two", Value = "1" });
                l1.Add(new SelectListItem { Text = "2A", Value = "2" });
                l1.Add(new SelectListItem { Text = "2B", Value = "3" });
                l1.Add(new SelectListItem { Text = "2C", Value = "4" });
            }
            var d = Json(l1);
            return Json(l1);
        }




        [HttpPost]
        public JsonResult gethiddenvalue(bool boolVal)
        {
            return Json("df");
        }
    }
}
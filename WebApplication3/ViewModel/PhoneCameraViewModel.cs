using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication3.ViewModel
{
    public class PhoneCameraViewModel
    {
        public int Id { get; set; }
        public IEnumerable<SelectListItem> Cameras { get; set; }
        public int CameraId { get; set; }
        public string PhoneName { get; set; }
    }
}
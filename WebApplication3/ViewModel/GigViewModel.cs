using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication3.ViewModel
{
    public class GigViewModel
    {
        public int Id { get; set; }

        [Required]
        public string GigName { get; set; }

        // we need to show the "Please select"as default dropdiown so keeping it nullable. 
        // but we need to keep it required when posting the form "underpostnig attack"
        [Required]
        public int? MusicTypeId { get; set; }
        public IEnumerable<SelectListItem> MusicTypes { get; set; }

        // its not required, but we need to show the "Please select"as default dropdiown so keeping it nullable so added "?". 
        public int? InstrumentId { get; set; }
        public IEnumerable<SelectListItem> Instruments { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace WebApplication3.Models
{
    public class DropDownViewModel
    {

        public DropDownViewModel()
        {
            SongList = new List<SelectListItem>();
            BoolVal = true;
        }

        public int Id { get; set; }

        public List<SelectListItem> SongList { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public bool BoolVal { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        [Display(Name = "In Dollar")]
        [DataType(DataType.Currency)]
        public int RateInDollar { get; set; }
    }
}
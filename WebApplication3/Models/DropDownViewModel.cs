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
            BoolVal = false;
            test = 2;
        }

        public int Id { get; set; }

        public List<SelectListItem> SongList { get; set; }

        [Display(Name = "Enter your First Name")]
        [Required]
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
        [DataType(DataType.Currency)] // for currency
        public double RateInDollar { get; set; }
        public int test { get; set; }

        public int classtest { get; set; }
        public int idtest { get; set; }

    }
}
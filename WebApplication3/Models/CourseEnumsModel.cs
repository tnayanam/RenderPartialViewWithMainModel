
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class CourseEnumsModel
    {
        //[DisplayName("<YOUR NAME>")]
        [Display(Name = "Select the Genre")]
        public CourseEnums OptionSelected { get; set; }

        public string prop { get; set; }

        public string Error { get; set; }
    }
}
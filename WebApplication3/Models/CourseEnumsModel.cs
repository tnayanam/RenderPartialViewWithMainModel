
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class CourseEnumsModel
    {
        [Display(Name = "Select the Genre")]
        public CourseEnums OptionSelected { get; set; }

        public string prop { get; set; }

        public string Error { get; set; }
    }
}
using Foolproof;
using System.ComponentModel.DataAnnotations;
using System.Web;
using WebApplication3.CustomValidation;

namespace WebApplication3.ViewModel
{
    public class CoverLetterViewModel
    {
        [FileConstraint("pdf|doc|txt", ErrorMessage = "File type is not valid.")]
        public HttpPostedFileBase File { get; set; }

        public string FirstName { get; set; }

        [RequiredIf("FirstName", "*", ErrorMessage = "Name field is required if first name is Tanuj")]
        public string LastName { get; set; }

        public string SelectedRoleType { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int PositiveNumber { get; set; }
    }
}

//<label>
//    @Html.RadioButtonFor(m => m.SelectedRoleType, "JobSeeker", new { @class="js-radio", id = "" })
//    <span>Job Seeker</span>
//</label>
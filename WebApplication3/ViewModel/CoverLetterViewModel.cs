using System.ComponentModel.DataAnnotations;
using System.Web;
using WebApplication3.CustomValidation;

namespace WebApplication3.ViewModel
{
    public class CoverLetterViewModel
    {
        [FileConstraint("pdf|doc|txt", ErrorMessage = "File type is not valid.")]
        [Required]
        public HttpPostedFileBase File { get; set; }

        [Required]
        public string Name { get; set; }
    }
}


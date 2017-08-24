using Foolproof;
using System.Web;
using WebApplication3.CustomValidation;

namespace WebApplication3.ViewModel
{
    public class CoverLetterViewModel
    {
        [FileConstraint("pdf|doc|txt", ErrorMessage = "File type is not valid.")]
        public HttpPostedFileBase File { get; set; }

        public string FirstName { get; set; }

        [RequiredIf("FirstName", "tanuj", ErrorMessage = "Name field is required if first name is Tanuj")]
        public string LastName { get; set; }
    }
}


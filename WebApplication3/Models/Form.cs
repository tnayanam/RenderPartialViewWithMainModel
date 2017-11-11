using System.ComponentModel.DataAnnotations;
using WebApplication3.CustomValidation;

namespace WebApplication3.Models
{
    public class Form
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        //[Remote("IsAgeUnique", "Form", ErrorMessage = "Age is not unique")] 
        public int age { get; set; }

        // if amount is greater than 100 then age must be > 18
        [AmountBasedOnAge]
        [Display(Name = "Amount Owed")]
        public decimal amount { get; set; }

    }
}
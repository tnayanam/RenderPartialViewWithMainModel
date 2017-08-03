using System.ComponentModel.DataAnnotations;

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
    }
}
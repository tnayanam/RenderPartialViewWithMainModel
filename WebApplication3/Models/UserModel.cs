
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication3.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name field cannot be blank")]
        [StringLength(10, MinimumLength = 5)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        [Display(Name = "Confirm Name")]
        [Compare("Name", ErrorMessage = "Both field should have same value")]
        public string ConfirmName { get; set; }
        public int Id { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
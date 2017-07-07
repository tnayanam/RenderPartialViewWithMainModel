
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name field cannot be blank")]
        public string Name { get; set; }
        public int Id { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
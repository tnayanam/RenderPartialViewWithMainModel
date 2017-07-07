
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class UserModel
    {
        [Required]
        public string Name { get; set; }
        public int Id { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
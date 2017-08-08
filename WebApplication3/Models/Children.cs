
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication3.Models
{
    public class Children
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int StandardId { get; set; }
        [ForeignKey("StandardId")]
        public virtual Standard Standard { get; set; }
    }
}
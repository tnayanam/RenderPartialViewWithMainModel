using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Child
    {
        [Key]
        public int ChildId { get; set; }
        public string ChildName { get; set; }
    }
}
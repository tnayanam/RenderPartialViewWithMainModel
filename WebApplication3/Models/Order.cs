// one user can place many orders.
// one order can be placed by on customer only
// one to many relationships

using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Range(1, 10)]
        public int onetoten { get; set; }
        public string productName { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

    }
}
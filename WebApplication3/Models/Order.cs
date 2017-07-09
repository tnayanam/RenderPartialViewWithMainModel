// one user can place many orders.
// one order can be placed by on customer only
// one to many relationships

namespace WebApplication3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

    }
}
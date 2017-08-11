
namespace WebApplication3.Models
{
    public class Website
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IndusId { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
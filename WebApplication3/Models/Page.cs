
namespace WebApplication3.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public int CopyId { get; set; }
        public virtual Copy Copy { get; set; }

    }
}
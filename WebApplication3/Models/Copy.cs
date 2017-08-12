
using System.Collections.Generic;
namespace WebApplication3.Models
{
    public class Copy
    {
        public int Id { get; set; }
        public string CopyName { get; set; }
        public ICollection<Page> Pages { get; set; }
    }
}
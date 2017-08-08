
using System.Collections.Generic;
namespace WebApplication3.Models
{
    public class Standard
    {

        public Standard()
        {
            Children = new List<Children>();
        }
        public int Id { get; set; }
        public string StandardName { get; set; }

        public virtual ICollection<Children> Children { get; set; }
    }
}
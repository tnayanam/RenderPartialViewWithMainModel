using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Flower> Flowers { get; set; }
    }
}
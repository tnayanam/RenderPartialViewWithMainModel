using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Website> Websites { get; set; }
    }
}
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Parking> Parkings { get; set; }
    }
}
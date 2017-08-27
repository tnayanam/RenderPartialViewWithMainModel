using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        //public ICollection<Camera> Cameras { get; set; }
    }
}



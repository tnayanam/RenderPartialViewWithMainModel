using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Parking> Parkings { get; set; }
        public string selectedRadio { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime date { get; set; }
    }
}
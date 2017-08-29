using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class MusicType
    {
        [Key]
        public int MusicTypeId { get; set; }

        [Required]
        public string MusicTypeName { get; set; }

        public ICollection<Gig> Gigs { get; set; }
        public ICollection<Instrument> Instruments { get; set; }
    }
}
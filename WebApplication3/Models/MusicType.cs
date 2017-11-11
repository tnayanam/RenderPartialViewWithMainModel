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


        // all these integers Id should match with the one in the database. 
        // And now moving forward instead of Enum 
        public static readonly int Blues = 0;
        public static readonly int Rock = 1;
        public static readonly int Metal = 2;

    }
}
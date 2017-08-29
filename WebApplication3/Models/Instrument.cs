using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class Instrument
    {
        [Key]
        public int InstrumentId { get; set; }

        [Required]
        public string InstrumentName { get; set; }

        [Required]
        public int MusicTypeId { get; set; }
        public virtual MusicType MusicType { get; set; }

        public ICollection<Gig> Gigs { get; set; }
    }
}
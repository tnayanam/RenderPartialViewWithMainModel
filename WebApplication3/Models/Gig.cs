using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class Gig
    {
        [Key]
        public int GigId { get; set; }
        [Required]
        public string GigName { get; set; }

        public int MusicTypeId { get; set; }
        public virtual MusicType MusicType { get; set; }

        // this needs to be nullable
        public int? InstrumentId { get; set; }
        public virtual Instrument Instrument { get; set; }
    }
}
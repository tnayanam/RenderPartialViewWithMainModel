using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class CoverLetter
    {
        public int CoverLetterId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
    }
}
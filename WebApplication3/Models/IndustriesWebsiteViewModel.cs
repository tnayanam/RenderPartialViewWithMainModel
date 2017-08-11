using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class IndustriesWebsiteViewModel
    {
        public int Id { get; set; }
        public IEnumerable<Industry> Industries { get; set; }
        public int IndustryId { get; set; }
        public string WebSiteName { get; set; }
    }
}
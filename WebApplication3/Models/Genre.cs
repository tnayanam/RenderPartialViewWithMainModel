
using System.Web.Mvc;
namespace WebApplication3.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}
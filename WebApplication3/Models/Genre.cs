
namespace WebApplication3.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isUnitNoEmptyInAllRow { get; set; } = true;
    }
}
namespace WebApplication3.Models
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlantId { get; set; }
        public virtual Plant Plant { get; set; }
    }
}
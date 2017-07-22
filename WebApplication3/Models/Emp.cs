// one emp can have on depot and one deop can be there in many emp.
namespace WebApplication3.Models
{
    public class Emp
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int DepotId { get; set; }
        public Depot Depot { get; set; }
    }
}
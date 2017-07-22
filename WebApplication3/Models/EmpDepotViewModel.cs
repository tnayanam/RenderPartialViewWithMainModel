using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class EmpDepotViewModel
    {
        public string EmpName { get; set; }
        public List<Depot> Depots { get; set; }
        public int depotId { get; set; }
    }
}
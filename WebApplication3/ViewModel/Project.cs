using System.Collections.Generic;

namespace WebApplication3.ViewModel
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Cities { get; set; }
        public int Distance { get; set; }
        public bool IsOk { get; set; }
    }
}
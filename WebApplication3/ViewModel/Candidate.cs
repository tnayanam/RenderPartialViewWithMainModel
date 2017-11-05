using System.Collections.Generic;

namespace WebApplication3.ViewModel
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }

        public static List<Candidate> GetAllCandidates()
        {
            return new List<Candidate>()
            {
                new Candidate { CourseId = 1, Id = 1, Name = "Tanuj" },
                new Candidate { CourseId = 2, Id = 2, Name = "Nayanam" },
                new Candidate { CourseId = 2, Id = 3, Name = "Arundhati" },
                new Candidate { CourseId = 2, Id = 4, Name = "Sharma" },
                new Candidate { Id = 5, Name = "Raz" }
            };
        }
    }
}
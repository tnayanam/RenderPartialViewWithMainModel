using System.Collections.Generic;

namespace WebApplication3.ViewModel
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }

        public static List<Course> GetAllCourses()
        {
            return new List<Course>()
            {
                new Course { Id = 1, CourseName = "Maths" },
                new Course { Id = 2, CourseName = "Science" },
                 new Course { Id = 3, CourseName = "Physics" }
            };
        }
    }
}
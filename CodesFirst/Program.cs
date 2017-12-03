using System.Collections.Generic;
using System.Data.Entity;

namespace CodesFirst
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; } // this is enum property, one course can have one level
        public float FullPrice { get; set; }
        public Author Author { get; set; } // navigational property, one course can have one author too
        public IList<Tag> Tags { get; set; } // one course can have multiple tags
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; } // one author can have many courses
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }  // Many to Many relationship b/w tag and course
    }

    public enum CourseLevel
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }

    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        // Since we did not follow the convention in connnection string , we are explicitly telling the DbCOntext about the connection string it needs to use.
        public PlutoContext() : base("name=DefaultConnection")
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
// Below is IMportnat
//install-package entityframework -Version 6.1.3 -projectName CodesFirst
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


// Error While Runnig Enable-Migrations:
// No context type was found in the assembly
// That means you have not mada a class that inherits from DBContext

/*
 * In order to crrate code first freom any existing database just crate the project and add a ADO.Net Entity Model and click on
 * Created designer from Database 4thoption I think
 * ANd then give sleect the new connection and give the instace server name and chose the right database
 * from bottom dropdown and click next
 * from there uncjeck the Migration table and then click next and you are all set.
 * Now go to project and "Enable-Migrations"
 * Now you will rund add-Migration "Inital Model" But the problem is all these migrations script generated already exists in
 * the database so we need to tell the Project to ignore this set of migration
 * SO you will run below command "add-migration InitialModel -IgnoreChanges -Force"
 * What this will do it it weill ignore current migration Model clases and will give you empty migration file
 * Since we can only havbe one pending mgraiton at a time so we will now update our DB with this empty Migration
 * "update-databse"
 * Now you are all set. keep aming model changes int he code and keep adding migrationa nd updating the db.

     */

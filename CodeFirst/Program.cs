using System.Data.Entity;

namespace CodeFirst
{
    public class Test
    {
        public int Id { get; set; }
    }

    public class AppDBContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

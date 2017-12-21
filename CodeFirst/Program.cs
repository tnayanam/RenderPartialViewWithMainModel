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
/*
 * When you are trying to host on IIS a WCF Service then we need to add Service Reference to the client. And for that we need the URL of the service. GO to the
 * IIS and find the serviec browse to the .svc file and in the browser the url that appears along with the WSDL docuemnt
 * that url needs to go there.
 */

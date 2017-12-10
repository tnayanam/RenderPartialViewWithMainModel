using System;
using System.ServiceModel;

namespace CompanyServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new
                ServiceHost(typeof(CompanyService.CompanyService)))
            {
                host.Open();
                System.Console.WriteLine("Host Started" + DateTime.Now);
                Console.ReadLine();
            }

        }
    }
}

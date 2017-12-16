using System;
using System.ServiceModel;

namespace CalculatorServiceHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new
               ServiceHost(typeof(CalculatorService.CalculatorService)))
            {
                host.Open();
                System.Console.WriteLine("Host Started" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}

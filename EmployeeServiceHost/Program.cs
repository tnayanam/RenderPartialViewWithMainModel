using System;
using System.ServiceModel;

namespace EmployeeServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new
                ServiceHost(typeof(EmployeeService.EmployeeService)))
            {
                host.Open();
                System.Console.WriteLine("Host Started " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}

/*
 * First thing we do is add the service reference of the WCF Serive by going to referecne and adding a service rerefere
 * FOr adding referecnce go to the config file of the host and see the base addrtess to which the service is being hosted
 * now that base address needs to be added as a part of service reference in the client
 * But in order to do that you need to first run the host, so that the end point is discoverable
 * and then yu need to add the service reference, as soon as tyou add the ser4vife reference the end point interfaces will be dscovered. add them now
 */

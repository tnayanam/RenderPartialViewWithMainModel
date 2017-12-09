using System;
using System.ServiceModel;
namespace HelloServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                host.Open();
                System.Console.WriteLine("Host Started" + DateTime.Now);
            }
        }
    }
}

/*
 * Now we are creating a host which will host this WCF Service
 * for that in the  separate console application we need to add the DLL of the WCF Service created in lst commit
 * and also we need to add refernce of system.serviceModdel
 * SO here our aim is to host the service via this console application, we want to create two end points. so let's change the
 * config file.
 * 
 * 
 * Its all little tough but you will get eventually used to it. For now I had to run the host in Administrator Mode.
 */



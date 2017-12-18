using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleService.SimpleServiceClient client = new SimpleService.SimpleServiceClient();
            int num  = client.IncrementNumber();
            Console.WriteLine("Number after first call " + num); // output = 1 expected 1
            num = client.IncrementNumber();
            Console.WriteLine(client.InnerChannel.SessionId);
            Console.WriteLine("Number after second call " + num);  // output  2
            num = client.IncrementNumber();
            Console.WriteLine("Number after third call " + num);    // output 3
            Console.ReadLine();
        }
    }
}

/*
 * Better Management usage as service objects are freed immediately after the method returns
 * Concurrency is not an issue
 * Application Scalability is better
 * State is not maintined b/w calls.
 */

/*
 * Here per session object is maintained. default session is 10 minutes.
 * However different client will have separtate instance, b/w clinet session is not shared.
 * state is maintained b/w calls
 * greATER MEMORY    consumption
 * concurrency is an issue in multithreaded clients.
 * Overall per session services perform better because the service objects are nt instantiated per call
 * but per call services scale better because the instance is destroyed once the call returns.
 * 
 * By Default behaviour is per session
 * Not all binding support per session. basic httpbinding does not support per session. so it behaves as per call.
 * How to control WCF Session TimeOut
 * 
 */
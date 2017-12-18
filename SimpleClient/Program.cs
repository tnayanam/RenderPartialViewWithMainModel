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
            Console.WriteLine("Number after second call " + num);  // output = 1 expected 2
            num = client.IncrementNumber();
            Console.WriteLine("Number after third call " + num);    // output = 1 expected 3
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimplestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplestService.SimplestserviceClient client = new SimplestService.SimplestserviceClient();

            for (int i = 1; i <= 100; i++)
            {
                Thread thread = new Thread(client.DoWork);
                thread.Start();
            }
        }
    }
}

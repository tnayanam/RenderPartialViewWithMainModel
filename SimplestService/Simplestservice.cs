using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace SimplestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Simplestservice" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Simplestservice : ISimplestservice
    {
        public void DoWork()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread {0} processing request at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace SimplesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimplesService" in both code and config file together.

    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.PerSession)]
    public class SimplesService : ISimplesService
    {
        public List<int> GetEvenNumber()
        {
            Console.WriteLine("Thread Id {0} started GetEvenNuumbers at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
            List<int> lstEvenNum = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    lstEvenNum.Add(i);
                }
            }
            Thread.Sleep(2000);
            Console.WriteLine("Thread Id {0} stopped GetEvenNuumbers at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
            return lstEvenNum;
        }

        public List<int> GetOddNumber()
        {
            Console.WriteLine("Thread Id {0} started GetOddNuumbers at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
            List<int> lstOddNum = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    lstOddNum.Add(i);
                }
            }
            Thread.Sleep(2000);
            Console.WriteLine("Thread Id {0} stopped GetOddNuumbers at {1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString());
            return lstOddNum;
        }
    }
}

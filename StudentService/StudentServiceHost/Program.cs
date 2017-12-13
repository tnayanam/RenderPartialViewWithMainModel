﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new
                ServiceHost(typeof(StudentService.StudentService)))
            {
                host.Open();
                System.Console.WriteLine("Host Started" + DateTime.Now);
                Console.ReadLine();
            }

        }
    }
}

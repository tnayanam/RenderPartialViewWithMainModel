using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int y = 2147483647;
            double u = 10.3456;

            Console.WriteLine(string.Format("Temperature at {0:hh:mm tt} {0:MM/dd/yyyy} on {1:N2}", DateTime.Now, u));

            //Temperature at 11:05 PM 01 - 30 - 2018 on 10.35



            // checked is used to detect and capture - "The checked keyword is used to explicitly 
            // enable overflow checking for integral-type arithmetic operations and conversions."
            //try
            //{
            //    int h = checked(y + u);
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            Console.ReadLine();
        }
    }
}

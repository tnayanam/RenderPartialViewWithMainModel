using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int y = 2147483647;
            int u = 10;

            // checked is used to detect and capture - "The checked keyword is used to explicitly 
            // enable overflow checking for integral-type arithmetic operations and conversions."
            try
            {
                int h = checked(y + u);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}

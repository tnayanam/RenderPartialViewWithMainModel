using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new int[3];
            Console.WriteLine(num[0]); // all value wil be defaulted to the integer default value which is 0.
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);
            var str = new string[3] { "Tanuj", "Nayanam", "HelloWorld" }; // Object Initialization Syntax.

            // String.Format
            var strFirstName = "Tanuj";
            var strLastName = "Nayanam";
            Console.WriteLine(string.Format("{0} - {1}", strFirstName, strLastName));
            Console.WriteLine(string.Join(",", num)); // output "0,0,0"
        }
    }
}

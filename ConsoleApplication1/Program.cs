using System;

namespace ConsoleApplication1
{
    public enum Postal
    {
        FedEx = 0,
        USPS = 1,
        UPS = 2
    }

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

            //Verbatim String displays the output as it is
            // No Verbatim Example
            Console.WriteLine("Kindly look into \n  this folder c:\\folder1\\folder2 \n c:\\folder4\\folder4");

            //In here the actual path is c:\folder1\folder2 but we had to use one more back slash. a better way is
            Console.WriteLine(@"
Kindly Look into
this folder
c:\folder1\folder2
");


            // from front end you got 1
            var enumfromFrontEnd = 2;

            if (enumfromFrontEnd == (int)Postal.USPS)
            {
                Console.WriteLine("USPS");
            }
            else
                Console.WriteLine("Something else");

            // Now suppose you want to check the exact enum it belongs to then
            Console.WriteLine((Postal)enumfromFrontEnd);


        }
    }
}

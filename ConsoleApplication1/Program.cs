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
            //            var num = new int[3];
            //            Console.WriteLine(num[0]); // all value wil be defaulted to the integer default value which is 0.
            //            Console.WriteLine(num[1]);
            //            Console.WriteLine(num[2]);
            //            var str = new string[3] { "Tanuj", "Nayanam", "HelloWorld" }; // Object Initialization Syntax.

            //            // String.Format
            //            var strFirstName = "Tanuj";
            //            var strLastName = "Nayanam";
            //            Console.WriteLine(string.Format("{0} - {1}", strFirstName, strLastName));
            //            Console.WriteLine(string.Join(",", num)); // output "0,0,0"

            //            //Verbatim String displays the output as it is
            //            // No Verbatim Example
            //            Console.WriteLine("Kindly look into \n  this folder c:\\folder1\\folder2 \n c:\\folder4\\folder4");

            //            //In here the actual path is c:\folder1\folder2 but we had to use one more back slash. a better way is
            //            Console.WriteLine(@"
            //Kindly Look into
            //this folder
            //c:\folder1\folder2
            //");


            //            // from front end you got 1
            //            var enumfromFrontEnd = 2;

            //            if (enumfromFrontEnd == (int)Postal.USPS)
            //            {
            //                Console.WriteLine("USPS");
            //            }
            //            else
            //                Console.WriteLine("Something else");

            //            var shipType = "UPS";
            //            var postalCasting = (Postal)Enum.Parse(typeof(Postal), shipType);
            //            Console.WriteLine(postalCasting);
            //            // Now suppose you want to check the exact enum it belongs to then
            //            Console.WriteLine((Postal)enumfromFrontEnd);


            //            /*
            //             * Value type and Reference Type
            //             * All primitive types are value type
            //             * String, Array and other custom classes that we create are reference types.
            //             * Value types are stored in stack and we do ont need new keyword for them as son as value types goes out of scope it is deleted automatically
            //             * But for reference types we need a new keyword to allocate memeory manually
            //             * EXCEPTIONM: String 
            //             * Also, as soon as they out of scope they do not ge deallocatred. One garbage colection runs and deallocate them
            //             * Also, the re3fderence types are stored in nHEAPS.            
            //             */

            System.Console.WriteLine("Enter a number");
            var input1 = Console.ReadLine();

            System.Console.WriteLine("Enter a number");
            var input2 = Console.ReadLine();
            var num1 = Convert.ToInt32(input1);
            var num2 = Convert.ToInt32(input2);

            Console.WriteLine(num1 > num2 ? num1 : num2);

            var arr = new int[10] { 3, 2, 1, 6, 7, 5, 4, 3, 1, 0 };
            Console.WriteLine("Length : {0}", arr.Length); // 10

            var indexOf5 = Array.IndexOf(arr, 5); // 5
            Console.WriteLine("Index of 5: {0}", indexOf5);
            Array.Clear(arr, 0, 3);
            Console.WriteLine();
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }
            var arrDes = new int[10];
            Console.WriteLine();
            Array.Copy(arr, arrDes, 10);
            foreach (var elem in arrDes)
            {
                Console.Write(elem + " ");
            }

            Array.Sort(arrDes);
            Console.WriteLine();
            foreach (var elem in arrDes)
            {
                Console.Write(elem + " ");
            }

            Array.Reverse(arr);

            foreach (var elem in arrDes)
            {
                Console.Write(elem + " ");
            }
        }
    }
}

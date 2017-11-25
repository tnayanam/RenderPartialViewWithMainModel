using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication1
{
    public enum Postal
    {
        FedEx = 0,
        USPS = 1,
        UPS = 2
    }

    public class Calculator
    {
        public void Add(params int[] arr)
        {
            var sum = arr.Sum();
        }
    }
    public class Test
    {
        public string Name { get; set; }
    }

    public class Order
    {

    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public readonly List<Order> Orders; // now it can only be initialized once mostly in constructor or directly like below. It can never be initialized again.
        public readonly List<Order> Orderss = new List<Order>();
        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        //public Customer(int id, string name) : this(id) // nice way to initialize all the filed w/o repeating them in
        //                                                // the constructor
        //{
        //    this.Name = name;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cal = new Calculator();
            cal.Add(1, 2); // MULTIPLE PARAMETERS
            cal.Add(1, 2, 3); // MULTIPLE PARAMETERS

            Test t1 = new Test();
            var customer = new Customer(); // default
            var customer1 = new Customer(3);
            var customer2 = new Customer() // when we use Object Initializers we do not need the constructors
            {
                Name = "hello",
                Id = 2,
                Orders = new List<Order>()
            };
            customer.Orders.Add(new Order());
            t1.Name = "Tanuj";
            Test t2 = t1;
            t2.Name = "Abc";
            System.Console.WriteLine(t1.Name); // here t1.Name is also changed to Abc
            var t = 2;


            //    //            var num = new int[3];
            //    //            Console.WriteLine(num[0]); // all value wil be defaulted to the integer default value which is 0.
            //    //            Console.WriteLine(num[1]);
            //    //            Console.WriteLine(num[2]);
            //    //            var str = new string[3] { "Tanuj", "Nayanam", "HelloWorld" }; // Object Initialization Syntax.

            //    //            // String.Format
            //    //            var strFirstName = "Tanuj";
            //    //            var strLastName = "Nayanam";
            //    //            Console.WriteLine(string.Format("{0} - {1}", strFirstName, strLastName));
            //    //            Console.WriteLine(string.Join(",", num)); // output "0,0,0"

            //    //            //Verbatim String displays the output as it is
            //    //            // No Verbatim Example
            //    //            Console.WriteLine("Kindly look into \n  this folder c:\\folder1\\folder2 \n c:\\folder4\\folder4");

            //    //            //In here the actual path is c:\folder1\folder2 but we had to use one more back slash. a better way is
            //    //            Console.WriteLine(@"
            //    //Kindly Look into
            //    //this folder
            //    //c:\folder1\folder2
            //    //");


            //    //            // from front end you got 1
            //    //            var enumfromFrontEnd = 2;

            //    //            if (enumfromFrontEnd == (int)Postal.USPS)
            //    //            {
            //    //                Console.WriteLine("USPS");
            //    //            }
            //    //            else
            //    //                Console.WriteLine("Something else");

            //    //            var shipType = "UPS";
            //    //            var postalCasting = (Postal)Enum.Parse(typeof(Postal), shipType);
            //    //            Console.WriteLine(postalCasting);
            //    //            // Now suppose you want to check the exact enum it belongs to then
            //    //            Console.WriteLine((Postal)enumfromFrontEnd);


            //    //            /*
            //    //             * Value type and Reference Type
            //    //             * All primitive types are value type
            //    //             * String, Array and other custom classes that we create are reference types.
            //    //             * Value types are stored in stack and we do ont need new keyword for them as son as value types goes out of scope it is deleted automatically
            //    //             * But for reference types we need a new keyword to allocate memeory manually
            //    //             * EXCEPTIONM: String 
            //    //             * Also, as soon as they out of scope they do not ge deallocatred. One garbage colection runs and deallocate them
            //    //             * Also, the re3fderence types are stored in nHEAPS.            
            //    //             */

            //    //System.Console.WriteLine("Enter a number");
            //    //var input1 = Console.ReadLine();

            //    //System.Console.WriteLine("Enter a number");
            //    //var input2 = Console.ReadLine();
            //    //var num1 = Convert.ToInt32(input1);
            //    //var num2 = Convert.ToInt32(input2);

            //    //Console.WriteLine(num1 > num2 ? num1 : num2);

            //    //var arr = new int[10] { 3, 2, 1, 6, 7, 5, 4, 3, 1, 0 };
            //    //Console.WriteLine("Length : {0}", arr.Length); // 10

            //    //var indexOf5 = Array.IndexOf(arr, 5); // 5
            //    //Console.WriteLine("Index of 5: {0}", indexOf5);
            //    //Array.Clear(arr, 0, 3);
            //    //Console.WriteLine();
            //    //foreach (var elem in arr)
            //    //{
            //    //    Console.Write(elem + " ");
            //    //}
            //    //var arrDes = new int[10];
            //    //Console.WriteLine();
            //    //Array.Copy(arr, arrDes, 10);
            //    //foreach (var elem in arrDes)
            //    //{
            //    //    Console.Write(elem + " ");
            //    //}

            //    //Array.Sort(arrDes);
            //    //Console.WriteLine();
            //    //foreach (var elem in arrDes)
            //    //{
            //    //    Console.Write(elem + " ");
            //    //}

            //    //Array.Reverse(arr);

            //    //foreach (var elem in arrDes)
            //    //{
            //    //    Console.Write(elem + " ");
            //    //}
            //    //Console.WriteLine();
            //    //var list = new List<int>() { 1, 5, 7, 9, 1, 2, 0 };

            //    //list.Add(30);
            //    //list.AddRange(new int[3] { 45, 12, 14 });

            //    //foreach (var lst in list)
            //    //{
            //    //    Console.Write(lst + " ");
            //    //}
            //    //Console.WriteLine();
            //    //list.Remove(1);

            //    //foreach (var lst in list)
            //    //{
            //    //    Console.Write(lst + " ");
            //    //}
            //    //Console.WriteLine();
            //    //for (int i = 0; i < list.Count; i++)
            //    //{
            //    //    if (list[i] == 1)
            //    //    {
            //    //        list.Remove(list[i]);
            //    //    }
            //    //}
            //    //foreach (var lst in list)
            //    //{
            //    //    Console.Write(lst + " ");
            //    //}
            //    //Console.WriteLine();

            //    ////list.RemoveAll()

            //    //var r = list.IndexOf(9);
            //    //var r1 = list.LastIndexOf(1);
            //    //var t = list.Contains(7);
            //    //list.Clear(); // removes all elemnt from list
            //    ////list.Count;


            //    //string e = "er";
            //    //e = "dsfd";

            //    //// String are Immutable, means their value cannot be modified. If you try to modify a new memory is allocated and 
            //    ////old memory still exists which will be deleted by garbage collection.
            //    //// ImmmutABLE MEANING VALUES CANNOT be changed, if we try to change it will return a new object wth new value.
            //    //string test = "Tanuj Nayanam ";
            //    //Console.WriteLine("Trim '{0}'", test.Trim()); // Removes leading and trailing spaces.
            //    //Console.WriteLine("ToUpper '{0}'", test.ToUpper()); // Removes leading and trailing spaces.

            //    //var newStringarr = test.Split(' '); // splits string based on the delimiter and returns the array
            //    //Console.WriteLine(newStringarr[0]);
            //    //Console.WriteLine(test.Substring(3));

            //    //Console.WriteLine(test.Replace("Tanuj", "Helo"));

            //    //var tr = "";
            //    //if (string.IsNullOrEmpty(tr))
            //    //    Console.WriteLine("Empty Or Null");
            //    //else
            //    //    Console.WriteLine("Empty Or Null");

            //    //var tr1 = " ";
            //    //if (string.IsNullOrWhiteSpace(tr1))
            //    //    Console.WriteLine("Empty Or whiutesaoace");
            //    //else
            //    //    Console.WriteLine("Not");

            //    //var tr3 = "dfd";
            //    //if (string.IsNullOrEmpty(tr3))
            //    //    Console.WriteLine("Empty Or Null");
            //    //else
            //    //    Console.WriteLine("Not");

            //    //string tr4 = null;

            //    //if (string.IsNullOrEmpty(tr4))
            //    //    Console.WriteLine("Empty Or Null");
            //    //else
            //    //    Console.WriteLine("Not");


            //    //var qw = "24";
            //    //var age = Convert.ToInt32(qw); // we cannot use normal casting here.

            //    //float price = 34.8f;
            //    //Console.WriteLine(price.ToString("C"));
            //    //Add(8);

            //    var stringbuilder = new StringBuilder("oops");
            //    stringbuilder.Append('-', 10);

            //    Console.WriteLine(stringbuilder);
            //    stringbuilder.AppendLine(); // adds a new line.

            //    Console.WriteLine(stringbuilder);
            //    stringbuilder.Append("Header");
            //    stringbuilder.AppendLine();

            //    Console.WriteLine(stringbuilder);
            //    stringbuilder.Append('-', 10);

            //    Console.WriteLine(stringbuilder);
            //    stringbuilder.Replace('-', '+');
            //    stringbuilder.Insert(0, "Hell");
            //    stringbuilder.Remove(0, 4);

            //    Console.WriteLine(stringbuilder);
            //    Console.WriteLine(stringbuilder[0]);

            //}
            //public static void Add(int a, int r = 9)
            //{
            //    Console.WriteLine("OK!");
            //}

            ////    String Builder is a Mutable String unlike string class, so any changes you make is made to the same string rather
            ////a new one which is the case with String class. It is not meant for seaching though.It is more for manipulating.

            //// String does not have functionlke indexof lastindex of and al of that.

            // We have two classes for file manipulation: file and fileinfo
            // methods in file are static
            // Methods in FileInfo are Instance type.]

            File.Copy(@"C:\temp\old.jpeg", @"c:\temp\new.jpeg");
            var path = @"c:\temp.jpeg";
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);


            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(path);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }


            /*
             * DirectoryInfo and Directory
             * Direcrtory has static methods AND DirectoryInfo has Instance methods.
             
             */
            var direct = Directory.CreateDirectory(path);

            var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);

            Directory.Exists(path);

            var dirObj = new DirectoryInfo(path);
            dirObj.GetFiles();
            dirObj.GetDirectories();

            var pathlocation = @"C:\Project\HelloWorld\HelloWorld.sln";

            // extension name
            Path.GetExtension(pathlocation);
            // file name with erxtension
            Path.GetFileName(pathlocation);
            // w/o extension
            Path.GetFileNameWithoutExtension(pathlocation);
            // directory
            Path.GetDirectoryName(pathlocation);

            var Name = "Mosh"; // pointing to memory location: XABC12
            var FName = Name; // till here both are pointing to same memory locaton which is XABC12
            FName = "Hello"; // Now at this place Immutable concept takes precedence and FName gets
            // a brand new instance of string. At this point Name is pointing to XABC12 but FNAME will point to AABNCD2
            System.Console.WriteLine(Name);
            System.Console.WriteLine(FName);

            //Expected output: Hello, Hello
            // Actual output: Mosh, Hello

            var arr1 = new int[3] { 1, 2, 3 };
            var arr2 = arr1;
            arr2[0] = 2;
            System.Console.WriteLine("");
            foreach (var item in arr1)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("------------");

            foreach (var item in arr2)
            {
                System.Console.WriteLine(item);
            }


        }
    }
}

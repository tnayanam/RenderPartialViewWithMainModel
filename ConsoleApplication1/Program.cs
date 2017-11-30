/*
 * Inehritance is "Is Relationship"
 * Composition is a "Has a Relationship"
 * 
 */
/*
 * Upcasting: Casting a derived class to base class
 * DownCasting: Casting a SUper class to the derovedf class


 */

using ConsoleApplication1;
using System;
using System.Collections.Generic;

public class SuperClass
{
    public int Height { get; set; }
    public void Draw()
    {

    }
}

public class DerivedClass : SuperClass
{
    public int Width { get; set; }
    public void Do() { }
}


public class PublicTest
{
    public int Id { get; set; }
    private int age { get; set; }
    protected int birthDate { get; set; }

    protected int GetbirthDate() { return 4; }

    public int GetAge()
    {
        this.age = 2; // accessing private memebr;
        return 5;
    }
}

public class protectTest : PublicTest
{
    public void Name()
    {
        this.birthDate = 4;
        this.GetbirthDate(); // protected accessible;
    }
}



public class Animal
{
    public string Name { get; set; }
    public void NumberOfLegs()
    {
        System.Console.WriteLine("It has these many number of legs.");
    }
}
/*
 * Composition is a Has a Relationship.
 */
public class Man
{
    private Animal _animal;

    public Man(Animal animal)
    {
        _animal = animal;
    }

    public void wife()
    {
        _animal.Name = "asds";
        System.Console.WriteLine("My wife");
    }
}

public class MessageService
{
    public void OnMessageSent(object source, EventArgs e)
    {
        Console.WriteLine("Message sent.");
    }
}

public class Fish
{
    private Animal _animal;

    public Fish(Animal animal)
    {
        _animal = animal;
    }

    public void NoOfFins()
    {
        _animal.NumberOfLegs();
        System.Console.WriteLine("Number of fins");
    }
}

/*
 * Always Base class constructor is called first.  
*/

public class Vehicle
{
    //public Vehicle()
    //{
    //    System.Console.WriteLine("This is base class constructor");
    //}

    private readonly string _registration;

    public Vehicle(string registration)
    {
        _registration = registration;
    }
}

/*
 * Abstract Class cannot incluce implementation
 * If a member is declared abstract the containing class also  needs to be abstract
 * IN derived class all the abstract methods needs to be implemented of not then WONT COMPILE
 * Abstract class cannot be instantiated.
 
     */

public class Car : Vehicle
{
    public Car(string registrationNumber) : base(registrationNumber) // initialized the base class constructor
    {
        System.Console.WriteLine("This is child class constructor");
    }
}

// Man Has a Animal // Man is composed of animal
// Fish Has a  animal


public class Stack
{
    private readonly List<object> _obj;  // OBJECT IS THE PARENT OF ALL CLASSES IN DOT NET. SO this means it is a super class
                                         //. which means Upcastingf so it can store anything and everything.
                                         // readonlyt means it can opnl;y be initlized inconstriuctor or directly but not anywhere else.

    public Stack()
    {
        _obj = new List<object>();
    }

    public void Push(object input)
    {
        if (input == null)
            throw new Exception("Null input passed");
        _obj.Add(input);
    }

    public object Pop()
    {
        if (_obj.Count == 0)
            throw new Exception("Stack is Empty");
        var temp = _obj[_obj.Count - 1];
        _obj.RemoveAt(_obj.Count - 1);
        return temp;
    }

    public void Clear()
    {
        _obj.Clear();
    }
}

/*
 * Polymorphism
 * - Method Overriding   
     */


public class Logger : ILogger
{
    public void LogError(string message)
    {
        Console.WriteLine("Error Message");
    }

    public void LogMessage(string message)
    {
        Console.WriteLine("Info Message");
    }
}

public class FileLogger : ILogger
{
    public void LogError(string message)
    {
        Console.WriteLine("I want top write in file");
    }

    public void LogMessage(string message)
    {
        Console.WriteLine("I have a different logic");
    }
}


/*
 Difference between interface and abstract class
 that being an Abstract Class can contain implementation of methods, fields,
 constructors, etc, while an Interface only contains method and property prototypes. 
 A class can implement multiple interfaces, but it can only inherit one class (abstract or otherwise).
 An Interface member cannot be defined using the keyword static, virtual, abstract or sealed

    Interface is What I can do  ** IMPORTANT
    Class is what am I          ** IMPORTANT
     
     */

public interface ILogger
{
    void LogError(string message);
    void LogMessage(string message);
}

public class DBMigrator
{
    private readonly ILogger _Logger;

    public DBMigrator(ILogger logger)  // THis is called dependency injection DI ** IMPORTANT
    {
        _Logger = logger;
    }
    public void Migrate()
    {
        _Logger.LogError("Some Error Occured");

        // Some Logic

        _Logger.LogMessage("Some Message");
    }
}




public abstract class Shape
{
    public abstract void Draw(); // a promise that all inherited calss must havbe to implement it.

    public void Add()
    {

    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw Circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw Rectangle");
    }
}

public class Canvas
{
    public void Drawing(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}

public class GenericsDictionary<TKey, TVal> //THis is generics
{
    public void Add(TKey key, TVal val)
    {

    }
}

/**
 * Delegates are Reference to a function
 * Used for extensibility and flexible application
 */

public class Photo
{
    public static Photo Load(string path)
    {
        return new Photo();
    }

    public void Save()
    {

    }
}

// This is a framework for designing photographs.
// Now the problem is if we want to add another method to the photofilter we will have to make changes in the PhotoProcessor class
// Something like  filters.Resize(photo);
// Also if the cutomer who will use our framework wants to add any of their own functionality they will not be able to do so.
public class PhotoProcessor
{
    // instead of creating our oewn delegate we can use the delegate provied by the frmmework.
    // Action<: generic delegate>
    //public delegate void PhotoFilterHandler(Photo photo);

    public void Process(string path, Action<Photo> filterHandler)
    {
        var photo = Photo.Load(path);
        filterHandler(photo);
        photo.Save();
    }
}

public class PhotoFilters
{
    public void ApplyBrightness(Photo photo)
    {
        Console.WriteLine("Bright Photo Applied");
    }

    public void ApplyContrast(Photo photo)
    {
        Console.WriteLine("Contrast Applied");
    }
}

// Events and Delegates
/*
 * What are events?
 * A mechanism for commnunication between objects
 * Used in building loosely Coupled Applcation
 * Helps extending applications
 * 
 * If something at one place changes in one object we can notify it at other objects about it.
 */

// Events is based on Publisher and Subscriber
// Delegate is an agreememnt between Publisher and Subscriber

class Program
{
    // This is an example without the Lambda expression
    static int Square(int number)
    {
        return number * number;

    }

    // Steps to follow for publisher and subscriber
    // Define a delegate: It is the contract between Publisher and Subscriber
    // So based on signature of delegate the subsriber function will be called.
    // Define the event based on thehat delegate
    // Raise the event
    static void Main(string[] args)
    {
        var video = new Video()
        {
            Title = "EventVideo"
        };
        var videoencoder = new VideoEncoder(); // publisher
        var mailService = new MailService(); // Subscriber
        var messageService = new MessageService(); // Subscriber
        videoencoder.VideoEncoded += mailService.OnVideoEncoded;
        videoencoder.VideoEncoded += messageService.OnMessageSent;
        videoencoder.Encode(video);



        var books = new BookRepository().GetBooks();
        var bo = books.FindAll(b => b.Price < 15f); // here b is the argument and b.Price<15 is the expression

        // Syantax for Lambda Expression
        // args => expression "args goes to expression"
        // number => number * number
        // Func<int,int> Delegate example: 1st parameter is the Argument and the 2nd type is the Datatype or return value
        // This is an example with lambda expressio and Func delegates.
        Func<int, int> calsquare = Square; // pointing to the external Square function
        Func<int, int> square = number => number * number; // this is where logic is written inline.
        const int factor = 5;
        Func<int, int> multiplier = n => n * factor;
        var resul = multiplier(4);// this is how we call a lamda function

        Console.WriteLine(square(5));
        // Since calculating square needs int as parement and return type is int.
        var photoprocessor = new PhotoProcessor();
        var filter = new PhotoFilters();
        Action<Photo> filterhandler = filter.ApplyBrightness;

        //calling other filter
        filterhandler += filter.ApplyContrast;

        filterhandler += Program.removeREDeYE; //. this is a example of multicast delegate because it points to multipl functions




        photoprocessor.Process("ABC", filterhandler);
        // No go to @@@@@@@

        var dict = new GenericsDictionary<string, int>();
        dict.Add("hello", 2);

        var dbMigrator = new DBMigrator(new Logger());
        var dbMigratorForFile = new DBMigrator(new FileLogger()); // CHhanging to this is so easy now
        dbMigrator.Migrate();

        // Now suppose we want to have some other class lets say fileLogger, then we need to change the DBMIgrator class
        // because it is dependent on the Logger class currently. Now lets see how we can do this usiong interface
        // Now this problem is solved.
        // THIS IS CALLEC OPen Close Principole. open for extension but closed for modification. We do not have to modify the DbMigrator class



        var shapes = new List<Shape>();
        //var shape = new Shape(); // WOnt compile because we cannot instantiate the abstract class. 

        shapes.Add(new Circle()); // upcasting
        shapes.Add(new Rectangle()); // upcasting

        var canvas = new Canvas();
        canvas.Drawing(shapes);



        var s1 = new Stack();
        s1.Push(1);
        s1.Push(2);
        s1.Push(3);
        Console.WriteLine(s1.Pop());
        Console.WriteLine(s1.Pop());
        Console.WriteLine(s1.Pop());


        var car = new Car("WSD");
        var man = new Man(new Animal());

        man.wife();
        // Now in this situation if we want to add another method in animal class it will be difficult so if we want
        // to add another method such has NoOfHair, we can create another class altogether 

        //man.a

        //man.Name = "Tanuj";// inherited
        //man.wife(); // its own fucntion
        //man.NumberOfLegs();

        //var fish = new Fish();
        //fish.NoOfFins(); // its own function                                                                                                                                                                          nbm
        //fish.Name = "Tippy"; // inherited one
        // So, this is Inheritance.

        // Problem with Inheritance:
        // If we modify and add another property in Animal class lets say "Number of Hair". Now may
        //be there are 100 anials who needs this method, so we are tempted to keep it in Animal class
        // but there are many animals who dont need it, so for them its a waste to keep it in parent class which is ANimal
        // SO we end up creating another class just for 50 type pof animals whioch needs that no of hair method.
        // an now this is how inheritance iwll look like Animal=>ANimalWIthHair=> Anod now al the child classes/
        // SO we have a heirarchy now. and thats what we want to avoid
        /*
         * Different types of Access Modifier: Public, Private, Protected, Internal, Protected Internal
         
         */

        PublicTest p1 = new PublicTest();
        p1.Id = 2; // Public
                   // p1.Age = 3; // Not Accessible

        // Upcasting
        var derivedClass = new DerivedClass();
        SuperClass sp = derivedClass;
        //sp. now only super calss methods are availbale.

        // downcasting
        var superClass = new SuperClass();
        DerivedClass dc = (DerivedClass)superClass;
        // dc all the methods availbale

        // Boxing and Unboxing
        var num = 2; // this is a value type hence stored in stack
        object obj = 2; // this is a reference type so a memory is allocated for 2 and that memory reference is stored to obj
                        // Unboxing
        object obwj = 4;
        int num1 = (int)obwj;





    }
    //@@@@@@@
    // clkient/consume can add their own filters too. As long as the definniton of delegate is mathcing wit the filter

    static void removeREDeYE(Photo photo)
    {
        Console.WriteLine("red eye removed");
    }

}

/* What is a Lamda expression.
 *  Anonymous Method
 *  - No Access modifier
 *  - No Name
 *  - No Return Statement 
 */

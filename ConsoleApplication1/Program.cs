/*
 * Inehritance is "Is Relationship"
 * Composition is a "Has a Relationship"
 * 
 */

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

public class Car : Vehicle
{
    public Car(string registrationNumber) : base(registrationNumber) // initialized the base class constructor
    {
        System.Console.WriteLine("This is child class constructor");
    }
}

// Man Has a Animal // Man is composed of animal
// Fish Has a  animal
class Program
{
    static void Main(string[] args)
    {
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





    }
}

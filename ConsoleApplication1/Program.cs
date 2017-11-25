/*
 * Inehritance is "Is Relationship"
 * Composition is a "Has a Relationship"
 * 
 */

public class Animal
{
    public string Name { get; set; }
    public void NumberOfLegs()
    {
        System.Console.WriteLine("It has these many number of legs.");
    }
}

public class Man : Animal
{
    public void wife()
    {
        System.Console.WriteLine("My wife");
    }
}

public class Fish : Animal
{
    public void NoOfFins()
    {
        System.Console.WriteLine("Number of fins");
    }
}

// Man Is A Animal
class Program
{
    static void Main(string[] args)
    {
        var man = new Man();
        man.Name = "Tanuj";// inherited
        man.wife(); // its own fucntion
        man.NumberOfLegs();

        var fish = new Fish();
        fish.NoOfFins(); // its own function
        fish.Name = "Tippy"; // inherited one
        // So, this is Inheritance.

        // Problem with Inheritance:
        // If we modify and add another property in Animal class lets say "Number of Hair". Now may
        //be there are 100 anials who needs this method, so we are tempted to keep it in Animal class
        // but there are many animals who dont need it, so for them its a waste to keep it in parent class which is ANimal
        // SO we end up creating another class just for 50 type pof animals whioch needs that no of hair method.
        // an now this is how inheritance iwll look like Animal=>ANimalWIthHair=> Anod now al the child classes/
        // SO we have a heirarchy now. and thats what we want to avoid




    }
}
}

using System;
using Animals;

Console.WriteLine("Hello, World!");

// First int specifies type of return value, second int specifies type of the paramter being input

int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}

Console.WriteLine(FeetToInches(10));

// Void indicates no type is being returned.

SayBye();

void SayBye()
{
    Console.WriteLine("Bye");
}

// Custom Types
  
UnitConverter milesToFeetConverter = new UnitConverter (5280);

Console.WriteLine (milesToFeetConverter.Convert(100));

Panda p1 = new Panda ("Pan Dee");
Panda p2 = new Panda ("Pan Dah");

Console.WriteLine(p1.Name);
public class UnitConverter
{
    int ratio;  // Field

    public UnitConverter (int unitRatio)    // Constructor
    {
        ratio = unitRatio;
    }

    public int Convert (int unit)
    {
        return unit * ratio;    // Method
    }
}

/*
    Public keyword exposes members to other classes so they can be accessed.
*/
public class Panda
{
    public string Name; // instance field
    public static int Population; // static field. Static means belonging to type itself rather than specific object or instance.

    public Panda (string n) // Constructor
    {
        Name = n;   // Assign the instance field
        Population = Population + 1;    // Increment the static Population field
    }
}

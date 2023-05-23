using System;

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

// Data Type Conversion

int myInt = 3;
double myDouble = myInt; // Turns myInt into a double.
/*
Converting double to int does not work however, because
C# checks for data loss upon conversion. Implicit conversion
will occur if no data will be lost. Explicit conversion
requires cast operator to convert a data type into another one.
*/

double newDouble = 3.2;
int newInt = (int)newDouble; // Rounds newDouble to nearest integer.

// May have to use built-in method, such as below.
Console.Write("Enter your favorite number!: ");
int faveNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(faveNumber);

// Custom Types

UnitConverter milesToFeetConverter = new UnitConverter (5280);

Console.WriteLine (milesToFeetConverter.Convert(100));

Panda p1 = new Panda ("Pan Dee");
Panda p2 = new Panda ("Pan Dah");

Console.WriteLine(p1.Name);

Console.WriteLine("How old are you?");
    string input = Console.ReadLine();
    Console.WriteLine($"You are {input} years old!");
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

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

// Built-In Methods

Console.WriteLine(Math.Abs(-5));    // Absolute value
Console.WriteLine(Math.Sqrt(16));   // Square Root
Console.WriteLine(Math.Floor(8.65));    // Rounds down double or decimal to nearest whole number
Console.WriteLine(Math.Ceiling(8.65)); // Rounds up double or decimal to nearest whole number
Console.WriteLine(Math.Min(39, 12));    // Returns smaller of two numbers
Console.WriteLine(Math.Max(69, 420));   // Returns larger of two numbers
Console.WriteLine(Math.Pow(3, 3));  // Raise specified number to specified power; takes two doubles

// String Interpolation, methods

string yourFaveMusician = "Jack White";
string myFaveMusician = "Dan Auerbach";

Console.WriteLine($"Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}.");
Console.WriteLine(yourFaveMusician.Length);
Console.WriteLine(myFaveMusician.IndexOf("x"));
Console.WriteLine(yourFaveMusician.ToUpper());
Console.WriteLine(myFaveMusician.ToLower());
Console.WriteLine(yourFaveMusician.Substring(2, 5));

// Ternary

int pepperLength = 4;
    string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

    Console.WriteLine(message);

// Switch Statements

string genre = Console.ReadLine();
    switch (genre)
    {
        case "Drama":
        Console.WriteLine("Citizen Kane");
        break;
        case "Comedy":
        Console.WriteLine("Duck Soup");
        break;
        case "Adventure":
        Console.WriteLine("King Kong");
        break;
        case "Horror":
        Console.WriteLine("Pick a genre");
        break;
        case "Science Fiction":
        Console.WriteLine("2001: A Space Odyssey");
        break;
        default:
        Console.WriteLine("No movie found");
        break;
    }

// Custom Types

UnitConverter milesToFeetConverter = new UnitConverter (5280);

Console.WriteLine (milesToFeetConverter.Convert(100));

Panda p1 = new Panda ("Pan Dee");
Panda p2 = new Panda ("Pan Dah");

Console.WriteLine(p1.Name);

Console.WriteLine("How old are you?");
    string input = Console.ReadLine();
    Console.WriteLine($"You are {input} years old!");

// Defining methods

static void VisitPlanets(
    string adjective = "brave",
    string name = "Cosmonaut",
    int numberOfPlanets = 0,
    double gForce = 4.2)    // Name with PascalCase
// Parameters can only be used inside their method.
// Default parameters defined with =
    {
        Console.WriteLine($"Welcome back, {adjective} {name}.");
        Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }

VisitPlanets(numberOfPlanets: 2);   // Optional parameters can be called by name.
// Can mix positional arguments with named ones, but positional ones MUST come first!

/*
With Method Overloading, methods with the same name can differ based on paramater types
or parameter numbers.
*/

Math.Round(3.14159, 2);  // With a double and an integer, rounds double to int number of decimal points.
Math.Round(3.14159);    // With just a double, rounds to nearest integer.

/*
Out parameter, for when you need to out put two pieces of information even
though methods can only return one value.
*/

int number;
bool success = Int32.TryParse("10602", out number);
// number is 10602 and success is true
int number2;
bool success2 = Int32.TryParse(" !!! ", out number2);

/*
Out parameters for when you need a method to out put more than one pice of information.
The following Int32.TryParse() tries to parse in put as integer.
*/

string ageAsString = "102";
    string nameAsString = "Granny";

    int ageAsInt;
    bool outcome = Int32.TryParse(ageAsString, out ageAsInt);

    int nameAsInt;
    bool outcome2 = Int32.TryParse(nameAsString, out nameAsInt);

    Console.WriteLine(outcome);
    Console.WriteLine(ageAsInt);
    Console.WriteLine(outcome2);
    Console.WriteLine(nameAsInt);

// Custom method overloads
class pets
{
    static void NamePets(string nameOne, string nameTwo)
    {
        Console.WriteLine($"Your pets {nameOne} and {nameTwo} will be joining your voyage across space!");
    }
    static void NamePets(string nameOne, string nameTwo, string nameThree)
    {
        Console.WriteLine($"Your pets {nameOne}, {nameTwo}, and {nameThree} will be joining your voyage across space!");
    }
    static void NamePets()
    {
        Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
}

// NamePets("Laika", "Albert");
// NamePets("Mango", "Puddy", "Bucket");
// NamePets();



// Return
/*
When method is declared, the type of value it will return must be declared.
*/

namespace Return
{
    class Planet
    {
        static void Main()
        {
            DecoratePlanet("Jupiter");
        }
        static string DecoratePlanet(string planet)
        {
            Console.WriteLine($"*.*.* Welcome to {planet} *.*.*");
            return planet;
        }
    }
}



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

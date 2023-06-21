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

/*
ALTERNATE EXPRESSIONS

Expression-bodied definitions are good for one-liners. Use fat-arrow notation.
*/

bool isEven(int num) => num % 2 == 0;
void Shout(string x) => Console.WriteLine(x.ToUpper());

Console.WriteLine(isEven(3));
Shout("butts butts butts");

// Methods as Arguments

int[] numbers = {1,2,3,4,5};

bool IsEven(int num) => number % 2 == 0;

bool hasEvenNumber = Array.Exists(numbers, IsEven);

Console.WriteLine(hasEvenNumber);

/*
What is happening above is that Array.Exists uses the array
as one argument, and is told to use the IsEven method on every
item in the array. If ANY of those are true, .Exists returns true.

Another example below is Array.Find, which finds the first element
for which the method returns true.
*/

string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};

bool IsLong(string word) => word.Length > 8;
string firstLongAdjective = Array.Find(adjectives, IsLong);
Console.WriteLine($"The first long word is: {firstLongAdjective}");

// Lambda functions. Anonymous functions defined directly in method call.

bool hasOddNumber = Array.Exists(numbers, (int num) => num % 2 != 0);
Console.WriteLine(hasOddNumber);

/*
Above can be shortened even further to:
bool hasOddNumber = Array.Exists(numbers, num => num % 2 != 0);
since type can be assumed given the operators.
*/

/*
ARRAYS

Arrays in C# must have all items be the same type.
Defined as follows:
*/

int[] inty = {3, 44, 12};
string[] stringy = {"butts", "wieners", "boobies"};

double[] doubly;

doubly = new double[] {3.16, 0.2, 140.0};
Console.WriteLine(stringy);
Console.WriteLine(stringy.Length);

// New keyword denotes a new instance of that array class.

/*
Array methods include:
Array.Sort(arrayItself), Array.IndexOf(arrayItself, value), Array.Find(arrayItself, value)
*/

/*
Do...While Loop

Will always run at least once no matter what, regardless of stopping condition.
*/

bool buttonClick = true;
int numRung = 0;

do {
    if (numRung == 3) {
        buttonClick = false;
        break;
    }
    Console.WriteLine("RING RING BOYZZZZZZ!!!!!!!");
} while (!buttonClick);

// For Loop

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(i);
}

/*
BREAK: Ends loop block.
CONTINUE: Bypasses parts of code, ignoring whatever comes after in loop and goes
back to top of loop and starts again.
RETURN: Will break loop and return to control point in program where method
was called.
*/

// For Each Loop
string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

    foreach (string item in todo)
    {
        Console.WriteLine(item);
    }

// CLASSES
Forest f = new Forest();
f.Name = "Congo";
f.Trees = 0;
f.age = 2000;
f.Biome = "Tropical";
Console.WriteLine($"{f.Name}, {f.Biome}");
Console.WriteLine(f.IncreaseAge(2));

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

public class Forest
{
    public string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Trees
    { get; set; } // same as declaring getter/setter above, called an automatic property
    public int age;
    public int Age
    {
        get { return age; }
        private set { age = value; } // getter is public, setter is private.
    }
    private string biome;
    /*
    External code would be able to access the biome field directly with public,
    so set to private so only code within the class definition code.
    */
    public string Biome
    {
        get { return biome; }
        set {
        if (value == "Tropical" || value == "Temperate" || value == "Boreal")
        {
            biome = value;
        } else {
            biome = "Unknown";
        }
    }
    }

    // Methods
    public int IncreaseAge(int growth)
    {
        Age = Age + growth;
        return Age;
    }
}

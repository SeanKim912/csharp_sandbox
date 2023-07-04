using Basics;

    Sedan nissan = new Sedan(4);
    nissan.LicensePlate = "AAAA";
    nissan.Wheels = 4;
    nissan.Honk();

    Console.WriteLine($"{nissan.LicensePlate} {nissan.Speed} {nissan.Wheels}");

    Truck ford = new Truck(2);
    ford.LicensePlate = "BBBB";
    ford.Wheels = 4;
    ford.Honk();

    Console.WriteLine($"{ford.LicensePlate} {ford.Speed} {ford.Wheels}");

    // Array of references, can use base, superclass, or interface, but only get functionality of the type you used.
    IAutomobile[] garage = new IAutomobile[] { new Sedan(4), new Sedan(4), new Truck(2) };

    // Can use foreach to access members on each array.
    foreach(IAutomobile a in garage)
    {
        Console.WriteLine(a.Speed);
    }

    /*
    CASTING

    Upcasting in polymorphism is the concept of referring to objects with a reference of their own type, an
    inherited type, or an implemented interface.

    For example:

    Sedan a = new Sedan();
    Vehicle b = a;
    IAutomobile = a;

    Downcasting is referencing an object by a subclass, such as:

    Vehicle c = new Vehicle();
    Sedan d = c;

    The above will throw an error saying you need an explicit conversion, which looks like:

    Vehicle c = new Vehicle();
    Sedan d = (Sedan)c;

    This tells computer user is aware of risk. Will still fail in most cases. Can deal with
    as/is operators.
    */

    /*
    NULL AND UNASSIGNED

    Missing/empty references are set with keyword null.
    Reference variables created without a value are unassigned.
    Can only compare null references when explicitly labeled with "null".

    Comparing unassigned variables will throw an error.
    */

    Sedan blank = null;
    Sedan blank2;
    Sedan[] sedans = new Sedan[5]; // This creates empty array of reference types, where each element is unassigned.

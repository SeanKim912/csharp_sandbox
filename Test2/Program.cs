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

    /*
    OBJECT

    Every class is derived from Object, and is at the top of inheritance hierarchy and can always be upcast to.
    You lose type-checking and specific functionality of subclasses when declaring as Object, but useful for when you're
    not sure what type a variable will be, and will always have access to standard Object members.
    */

    Object o1 = new Sedan(4);
    Object o2 = new Truck(2);
    Object o3 = o1;

    /*
    In the background,
    class Sedan
    is implied to equal
    class Sedan : Vehicle
    and
    class Sedan : Object
    */

    // Object members, accessible to all types with Object.

    Object[] objArr = { o1, o2, nissan, ford };

    foreach (Object obj in objArr)
    {
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj.ToString()); // Returns string describing object
    }

    Console.WriteLine(o1.Equals(o2));
    Console.WriteLine(o1.Equals(o3));

    /*
    Equals and ToString are virtual members in Object, so can be overridden by
    defining a public override method.

    Console.WriteLine uses ToString as part of Object, so overriding ToString affects
    Console.WriteLine!
    */

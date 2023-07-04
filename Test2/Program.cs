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

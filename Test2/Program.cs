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

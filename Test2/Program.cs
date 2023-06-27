using Basics;

    Sedan nissan = new Sedan();
    nissan.LicensePlate = "AAAA";
    nissan.Speed = 88.0;
    nissan.Wheels = 4;
    nissan.Honk();

    Console.WriteLine($"{nissan.LicensePlate} {nissan.Speed} {nissan.Wheels}");

    Truck ford = new Truck();
    ford.LicensePlate = "BBBB";
    ford.Speed = 65.0;
    ford.Wheels = 4;
    ford.Honk();

    Console.WriteLine($"{ford.LicensePlate} {ford.Speed} {ford.Wheels}");

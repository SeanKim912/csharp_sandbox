using System;

namespace Basics
{
    /*
    An interface is a group of interactions in C# that includes properties, methods,
    and other members. Declared with a signature but bheaviors are not defined. A class
    is said to implement an interface when it defines those properties and methods.
    */
    interface IAutomobile // An interface should always be named with a capital "I".
    {
        /*
        You don't really care HOW the properties below work when it comes to the interface,
        you just care that every instance of the related class HAS the properties below.
        Interfaces provide another layer of code safety by catching errors early.

        Interfaces cannot specify constructors or fields.
        */
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }

    class Vehicle // Superclass
    {
        public double MPG
        { get; protected set; }
        /*
            Protected is another access modifier stricter than public but less than private.
            A protected member can be accessed by the current class any class that inherits
            from it.
        */

        public int Seats
        { get; private set;}

        public Vehicle(int seats)
        {
            Seats = seats;
        }
    }

    class Sedan : Vehicle, IAutomobile // Type superclass before interfaces
    {
        // base calls the constructor of hte superclass.
        public Sedan(int seats) : base(seats)
        {
            Wheels = 4;
        }

        public string LicensePlate
        { get; set; }
        public double Speed
        { get; set; }
        public int Wheels
        { get; set; }
        public void Honk()
        {
            Console.WriteLine("HONK");
        }
    }

    // If code above did not properly implement IAutomobile interface, would throw error CS0535;

    class Truck : Vehicle, IAutomobile
    {
        public string LicensePlate
        { get; set; }
        public double Speed
        { get; set; }
        public int Wheels
        { get; set; }
        public double Weight
        { get; set; }
        public void Honk()
        {
            Console.WriteLine("HONK");
        }

    }
}

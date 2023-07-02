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

    abstract class Vehicle // Superclass
    {
        public double MPG
        { get; protected set; }
        /*
            Protected is another access modifier stricter than public but less than private.
            A protected member can be accessed by the current class any class that inherits
            from it.
        */

        public double Speed
        { get; protected set; }

        public int Seats
        { get; private set;}

        public Vehicle(int seats)
        {
            Seats = seats;
        }

        // Virtual keyword indicates this member may be overridden by an inherited class
        public virtual void SpeedUp()
        {
            Speed += 5;
        }

        public abstract string Describe();
        /*
            Abstract keyword indicates a member that will be different for every subclass
            but MUST nonetheless be implemented. No defined default in superclass. If a member
            in a superclass is abstract, entire class itself must be abstract, so add abstract
            at top. Subclass needs to use override keyword to denote it is overriding the abstract
            member in the superclass.
        */
    }

    class Sedan : Vehicle, IAutomobile // Type superclass before interfaces
    {
        // base calls the constructor of hte superclass.
        public Sedan(int seats) : base(seats)
        {
            Wheels = 4;
            LicensePlate = "AAAA";
            Speed = 10;
        }

        public string LicensePlate
        { get; set; }

        public int Wheels
        { get; set; }
        public void Honk()
        {
            Console.WriteLine("HONK");
        }

        // Override keyword indicates we are changing the properties of the member defined in the superclass.
        public override void SpeedUp()
        {
            Speed += 4;

            if (Speed > 20 )
            {
                Speed = 20;
            }
        }

        public override string Describe()
        {
            return $"Sedan, {Wheels} wheels, {Speed} km/h";
        }
    }

    // If code above did not properly implement IAutomobile interface, would throw error CS0535;

    class Truck : Vehicle, IAutomobile
    {
        public Truck(int seats) : base(seats)
        {
            Wheels = 4;
            LicensePlate = "BBBB";
            Speed = 5;
        }

        public string LicensePlate
        { get; set; }
        public int Wheels
        { get; set; }
        public double Weight
        { get; set; }
        public void Honk()
        {
            Console.WriteLine("HONK");
        }

        public override string Describe()
        {
            return $"Truck, {Wheels} wheels, {Speed} km/h";
        }
    }
}

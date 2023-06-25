// See https://aka.ms/new-console-template for more information

/*
To start a new C# program, create new project folder, then run
"dotnet new console" in the terminal.
*/

using System;

Console.WriteLine("Butts");

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
        */
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }
}

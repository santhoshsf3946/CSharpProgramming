using System;
using Outside;
namespace Inside;

public class Program : Third
{
    public static void Main(string[] args)
    {
        First one = new First();
        Console.WriteLine("Public Number: " + one.publicNumber);
        Console.WriteLine("Private Number: " + one.PrivateOutput);
        Console.WriteLine("Internal Number: " + one.internalNumber);

        Second second = new Second();
        Console.WriteLine("Protected Number: " + second.ProtectedOutput);

        Third third = new Third();
        Console.WriteLine("Protected Internal Number: " + one.ProtectedInternalOutput);
    }
}

using System;

namespace ExOne;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Concatination
        Console.WriteLine("Hello: " + name);

        //Placeholder
        Console.WriteLine("Hello: {0}", name);

        //Interpolation
        Console.WriteLine($"Hello: {name}");
    }
}

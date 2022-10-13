using System;
namespace ByType;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n=============== Method Overloading by Type ===============");

        // Calling overloaded methods with different types of parameter
        Display(100);
        Display("Hello world");
    }

    static void Display(int number)
    {
        Console.WriteLine($"\nint type: {number}\n");
    }

    static void Display(string name)
    {
        Console.WriteLine($"string type: {name}\n");
    }
}

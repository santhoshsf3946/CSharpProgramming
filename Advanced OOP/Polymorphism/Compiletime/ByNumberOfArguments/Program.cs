using System;
namespace ByNumberOfArguments;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n=============== Method Overloading by Number of Arguments ===============");

        // Calling overloaded methods different number of arguments
        Display(10);
        Display(20, 30);
    }

    static void Display(int number)
    {
        Console.WriteLine("\nOverloaded method with one parameter is called");
        Console.WriteLine($"Arguments: {number}");
    }

    static void Display(int number1, int number2)
    {
        Console.WriteLine("\nOverloaded method with two parameter is called");
        Console.WriteLine($"Arguments: {number1} and {number2}\n");
    }
}

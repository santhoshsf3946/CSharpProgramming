using System;
namespace ExSeven;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("a - ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b - ");
        double b = double.Parse(Console.ReadLine());

        double result = a * a + 2 * a * b + b * b;

        Console.WriteLine($"Output: {result}");
    }
}

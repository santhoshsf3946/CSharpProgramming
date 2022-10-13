using System;
namespace Question11;

public class Program
{
    public static void Main(string[] args)
    {
        int x, y, result;

        Console.WriteLine("=========== X power Y calculator ===========");

        Console.Write("Enter x value: ");
        x = int.Parse(Console.ReadLine());
        
        Console.Write("Enter y value: ");
        y = int.Parse(Console.ReadLine());

        result = x;

        for (int i = 1; i < y; i++)
        {
            result *= x;
        }

        Console.WriteLine($"{x} power {y} is: {result}");
    }
}
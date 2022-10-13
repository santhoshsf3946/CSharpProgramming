using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        double celsius;

        Console.WriteLine("============= Celsius to Fahrenheit =============\n");

        Console.Write("Enter degrees on Celsius scale: ");
        celsius = double.Parse(Console.ReadLine());

        Console.WriteLine($"{celsius} degree celsius is equal to: {Math.Round(celsius * 9 / 5 + 32, 2)}\n");
    }
}
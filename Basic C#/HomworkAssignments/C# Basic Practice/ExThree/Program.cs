using System;
namespace ExThree;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the amount of Celsius: ");
        int celsius = int.Parse(Console.ReadLine());

        int kelvin = celsius + 273;
        int fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine($"Kelvin = {kelvin}");
        Console.WriteLine($"Fahrenheit = {fahrenheit}");
    }
}

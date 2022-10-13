using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        double inches;

        Console.WriteLine("============== Inches to Centimeters ==============\n");

        Console.Write("Enter inches: ");
        inches = double.Parse(Console.ReadLine());

        Console.WriteLine($"{inches} inches is equal to: {inches * 2.54} centimeters\n");
    }
}

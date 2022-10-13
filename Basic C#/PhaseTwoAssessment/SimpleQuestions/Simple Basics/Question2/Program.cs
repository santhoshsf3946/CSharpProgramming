using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("============= Area and Perimeter of a Circle =============\n");

        Console.Write("Enter the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine($"Area = {Math.PI * r * r}");
        Console.WriteLine($"Perimeter = {2 * Math.PI * r}\n");
    }
}
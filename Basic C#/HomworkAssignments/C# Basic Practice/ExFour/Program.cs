using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input radius = ");
        int radius = int.Parse(Console.ReadLine());
        Console.Write("Height = ");
        int height = int.Parse(Console.ReadLine());

        double volume = 3.14 * radius * radius * height;

        Console.WriteLine($"Volume : {volume}");
    }
}

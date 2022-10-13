using System;
namespace ExEight;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Length in meter: ");
        double meter = double.Parse(Console.ReadLine());

        double cm = meter * 100;
        double mm = cm * 10;
        double inch = meter * 39.3;
        double foot = meter * 12;
        double mile = meter * 0.0006213715277778;

        Console.WriteLine($"CM = {cm}");
        Console.WriteLine($"MM = {mm}");
        Console.WriteLine($"Inch = {inch}");
        Console.WriteLine($"Foot = {foot}");
        Console.WriteLine($"Mile = {mile}");
    }
}

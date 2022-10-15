using System;
namespace CalculatorApp;

public class Program
{
    public static void Main(string[] args)
    {
        // CircleArea onject
        CircleArea circle = new CircleArea() { Radius = 10 };
        Console.WriteLine("\nCircle Area: " + circle.CalculateCircleArea());

        // CylinderVolume object
        CylinderVolume cylinder = new CylinderVolume() { Radius = 10, Height = 8 };
        Console.WriteLine("\nCylinder Volume: " + cylinder.CalculateVolume());
    }
}

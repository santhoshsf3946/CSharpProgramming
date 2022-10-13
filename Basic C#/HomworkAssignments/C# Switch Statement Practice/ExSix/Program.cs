using System;
namespace ExSix;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Choose one of the below options,");
        Console.WriteLine("\t1. Area\n\t2. Perimeter\n\t3. Diameter");
        Console.Write("Enter the choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            {
                double area = 3.14 * radius * radius;
                Console.WriteLine($"\nThe Area is: {area}");
                break;
            }
            case 2:
            {
                double perimeter = 2 * 3.14 * radius;
                Console.WriteLine($"\nThe Perimeter is: {perimeter}");
                break;
            }
            case 3:
            {
                double diameter = radius * 2;
                Console.WriteLine($"\nThe Diameter is: {diameter}");
                break;
            }
            default:
            {
                Console.WriteLine("\nInvalid choice");
                break;
            }
        }
    }
}

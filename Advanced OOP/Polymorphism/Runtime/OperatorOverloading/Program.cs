using System;
namespace OperatorOverloading;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("============== Operator Overloading ==============");

        Box box1 = new Box(1.2, 3.2, 4.2);  // Declaring box1 of type Box
        Box box2 = new Box(10.1, 11.1, 12.2);  // Declaring box2 of type Box
        Box box3;  // Store the added values of the two boxes here
        double volume = 0;

        volume = box1.CalculateVolume();
        Console.WriteLine($"\nVolume of Box 1: {volume}");

        volume = box2.CalculateVolume();
        Console.WriteLine($"\nVolume of Box 2: {volume}");

        // Adding two box objexts
        box3 = box1 +  box2;
        volume = box3.CalculateVolume();
        // Volume of box 3
        Console.WriteLine($"\nVolume of Box 3: {volume}\n");
    }
}

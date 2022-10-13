using System;
namespace Question7;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("============ Pipes in Pool ============\n");

        Console.Write("Enter the volume of pool in liters: ");;
        int poolVolume = int.Parse(Console.ReadLine());

        Console.Write("Enter flow rate of the first pipe per hour: ");
        int pipe1 = int.Parse(Console.ReadLine());

        Console.Write("Enter flow rate of the second pipe per hour: ");
        int pipe2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the hours that the worker is absent: ");
        double leftHour = double.Parse(Console.ReadLine());

        double totalWater = (pipe1 + pipe2) * leftHour;

        if (totalWater > poolVolume)
        {
            Console.WriteLine($"\nFor {leftHour} hours the pool overflows with {totalWater - poolVolume} liters.\n");
        }
        else
        {
            Console.WriteLine($"\nThe pool is {(int) (totalWater / poolVolume * 100)}% full. Pipe 1: {(int) (pipe1 * leftHour / totalWater * 100)}%. Pipe 2: {(int) (pipe2 * leftHour / totalWater * 100)}%.\n");
        }
    }
}

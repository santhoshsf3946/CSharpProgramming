using System;
namespace Question7;

public class Program
{
    public static void Main(string[] args)
    {
        int startingNumber, difference, numberOfElements, sum = 0;

        Console.WriteLine("======== Sum of Arithmetic Progression Series ========\n");

        Console.Write("Enter the starting number: ");
        startingNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the difference :");
        difference = int.Parse(Console.ReadLine());

        Console.Write("Enter the number elements: ");
        numberOfElements = int.Parse(Console.ReadLine());

        Console.Write("\nSeries: ");

        while (numberOfElements > 0)
        {
            Console.Write(startingNumber + " ");
            sum += startingNumber;
            startingNumber += difference;
            numberOfElements--;
        }

        Console.WriteLine("\nThe sum is: " + sum);
    }
}

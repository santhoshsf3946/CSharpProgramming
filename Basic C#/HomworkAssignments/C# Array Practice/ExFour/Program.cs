using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the number of elements to store in the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine($"Input {size} number of elements in the array: ");

        for (var i = 0; i < size; i++)
        {
            Console.Write($"Element {i}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Maximum element is: ");
        int max = numbers[0];
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.Write(max);

        Console.Write("\nMinimum element is: ");
        int min = numbers[0];
        foreach (var number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.Write(min);
    }
}

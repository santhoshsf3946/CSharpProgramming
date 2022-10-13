using System;
namespace ExFive;

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

        Console.WriteLine("Even numbers are: ");
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine("\nOdd numbers are: ");
        foreach (var number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
    }
}

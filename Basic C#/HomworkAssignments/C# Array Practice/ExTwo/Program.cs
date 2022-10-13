using System;
namespace ExTwo;

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

        Console.WriteLine("The values stored into the array are: ");

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nThe values stored into the array in reverse are :");

        for (var i = size - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}

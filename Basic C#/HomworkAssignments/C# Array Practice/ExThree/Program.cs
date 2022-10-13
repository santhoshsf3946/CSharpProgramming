using System;
namespace ExThree;

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

        int sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Sum of all elements stored in the array is: " + sum);
    }
}

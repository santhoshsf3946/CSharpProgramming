using System;
namespace ExOne;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[10]; 
        Console.WriteLine("Input 10 elements in the array:");

        for (var i = 0; i < 10; i++)
        {
            Console.Write($"Element {i}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Elements in the array are: ");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

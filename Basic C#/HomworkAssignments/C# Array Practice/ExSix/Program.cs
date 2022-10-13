using System;
namespace ExSix;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine($"Input {size} number of elements in the array: ");

        for (var i = 0; i < size; i++)
        {
            Console.Write($"Element {i}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Elements of array in sorted ascending order: ");

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

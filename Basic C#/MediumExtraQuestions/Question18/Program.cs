using System;
namespace Question18;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ Division Without Reminder ================\n");

        Console.Write("Enter how many numbers to get: ");
        int length = int.Parse(Console.ReadLine());

        int[] numbers = new int[length];

        Console.WriteLine();

        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int count1 = 0, count2 = 0, count3 = 0;

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                count1++;
            }
            if (number % 3 == 0)
            {
                count2++;
            }
            if (number % 4 == 0)
            {
                count3++;
            }
        }

        Console.WriteLine("\nPercentage of numbers divisible by 2 without reminder: {0:0.00} %", Math.Round((double) count1 / length * 100, 2));
        Console.WriteLine("Percentage of numbers divisible by 3 without reminder: {0:0.00} %", Math.Round((double) count2 / length * 100, 2));
        Console.WriteLine("Percentage of numbers divisible by 4 without reminder: {0:0.00} %", Math.Round((double) count3 / length * 100, 2));
    }
}

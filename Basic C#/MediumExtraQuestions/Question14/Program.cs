using System;
namespace Question14;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================== Histogram ==================\n");

        Console.Write("Enter how many numbers to get: ");
        int length = int.Parse(Console.ReadLine());

        int[] numbers = new int[length];

        Console.WriteLine();

        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        double count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;

        foreach (var number in numbers)
        {
            if (number < 200)
            {
                count1++;
            }
            else if (number < 400)
            {
                count2++;
            }
            else if (number < 600)
            {
                count3++;
            }
            else if (number < 800)
            {
                count4++;
            }
            else
            {
                count5++;
            }
        }

        Console.WriteLine("\nPercentage of numbers below 200:  {0:0.00} %", Math.Round(count1 / length * 100, 2));
        Console.WriteLine("Percentage of numbers below 400:  {0:0.00} %", Math.Round(count2 / length * 100, 2));
        Console.WriteLine("Percentage of numbers below 600:  {0:0.00} %", Math.Round(count3 / length * 100, 2));
        Console.WriteLine("Percentage of numbers below 800:  {0:0.00} %", Math.Round(count4 / length * 100, 2));
        Console.WriteLine("Percentage of numbers below 1000: {0:0.00} %", Math.Round(count5 / length * 100, 2));
    }
}

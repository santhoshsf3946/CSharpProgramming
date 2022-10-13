using System;
using System.Threading;
namespace BubbleSort;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n================ Bubble Sort ================\n");

        int[] numbers = new int[] { 18, 19, 1, 5, 7, 3, 20 };

        Console.WriteLine("Sorting the array using Bubble sort\n");

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]}");

            if (i != numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("\n");
    }
}

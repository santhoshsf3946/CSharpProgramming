using System;
namespace SelectionSort;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n================ Selection Sort ================\n");

        int[] numbers = new int[] { 18, 19, 1, 5, 7, 3, 20 };

        Console.WriteLine("Sorting the array using Selection sort\n");

        int minValue, minIndex, temp;

        for (int i = 0; i < numbers.Length; i++)
        {
            minIndex = i;
            minValue = numbers[i];

            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[j] < minValue)
                {
                    minValue = numbers[j];
                    minIndex = j;
                }
            }
            
            if (minValue < numbers[i])
            {
                temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
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

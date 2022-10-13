using System;
namespace InsertionSort;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n================ Insertion Sort ================\n");

        int[] numbers = new int[] { 18, 19, 1, 5, 7, 3, 20 };

        Console.WriteLine("Sorting the array using Insertion sort\n");

        int key, temp, j;

        for (int i = 1; i < numbers.Length; i++)
        {
            key = numbers[i];
            j = i - 1;

            while (j >= 0 && key < numbers[j])
            {
                temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
                j--;
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

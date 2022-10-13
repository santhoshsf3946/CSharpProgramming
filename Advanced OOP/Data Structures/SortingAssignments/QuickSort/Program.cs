using System;
namespace QuickSort;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n================ Quick Sort ================\n");

        int[] numbers = new int[] { 18, 19, 1, 5, 7, 3, 20 };

        Console.WriteLine("Sorting the array using Quick sort\n");

        
        QuickSort(numbers, 0, numbers.Length - 1);


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

    public static void QuickSort(int[] list, int low, int high)
    {
        if (low < high)
        {
            int partitioningIndex = Partition(list, low, high);

            QuickSort(list, low, partitioningIndex - 1);
            QuickSort(list, partitioningIndex + 1, high);
        }
    }

    public static int Partition(int[] list, int low, int high)
    {
        int pivot = list[high];

        int  i = low - 1;

        int temp;
        for (int j = low; j <= high - 1; j++)
        {
            if (list[j] < pivot)
            {
                i++;
                temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        temp = list[i + 1];
        list[i + 1] = list[high];
        list[high] = temp;

        return i + 1;
    }
}

using System;
namespace MergeSort;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n================ Merge Sort ================\n");

        int[] numbers = new int[] { 18, 19, 1, 5, 7, 3, 20 };

        Console.WriteLine("Sorting the array using Merge sort\n");

        MergeSort(numbers, 0, numbers.Length - 1);

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

    public static void MergeSort(int[] list, int low, int high)
    {
        if (low < high)
        {
            int mid = low + (high - low) / 2;

            MergeSort(list, low, mid);
            MergeSort(list, mid + 1, high);

            Merge(list, low, mid, high);
        }
    }

    public static void Merge(int[] list, int low, int mid, int high)
    {
        int[] leftArray = new int[mid - low + 1];
        int[] rightArray = new int[high - mid];

        int i, j;

        for (i = 0; i < leftArray.Length; ++i)
        {
            leftArray[i] = list[low + i];
        }

        for (j = 0; j < rightArray.Length; ++j)
        {
            rightArray[j] = list[mid + 1 + j];
        }


        i = 0;
        j = 0;
        int k = low;

        while (i < leftArray.Length && j < rightArray.Length)
        {
            if (leftArray[i] <= rightArray[j])
            {
                list[k] = leftArray[i];
                i++;
            }
            else
            {
                list[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < leftArray.Length)
        {
            list[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < rightArray.Length)
        {
            list[k] = rightArray[j];
            j++;
            k++;
        }
    }
}

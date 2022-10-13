using System;
namespace IntegerBinarySearch;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ Integer Binary Search ================\n");

        Console.Write("Enter number of elements of a list: ");
        int length = int.Parse(Console.ReadLine());

        int[] integerArray = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter number [{i}]: ");
            integerArray[i] = int.Parse(Console.ReadLine());
        }

        // Binary search needed a sorted array of elements to perform the search
        Array.Sort(integerArray);

        Console.Write("\nEnter number to search in the list: ");
        int searchTerm = int.Parse(Console.ReadLine());

        int beg = 0, end = integerArray.Length - 1, mid;        
        bool found = false;

        while (beg <= end)
        {
            mid = (beg + end) / 2;

            if (searchTerm == integerArray[mid])
            {
                Console.WriteLine($"\nNumber {searchTerm} is found\n");
                found = true;
                break;
            }
            else if (searchTerm < integerArray[mid])
            {
                end = mid - 1;
            }
            else
            {
                beg = mid + 1;
            }
        }

        if (!found)
        {
            Console.WriteLine($"\nNumber {searchTerm} is not found\n");
        }
    }
}

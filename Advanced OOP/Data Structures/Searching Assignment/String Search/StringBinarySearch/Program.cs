using System;
namespace StringBinarySearch;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ String Binary Search ================\n");

        Console.Write("Enter number of strings of a list: ");
        int length = int.Parse(Console.ReadLine());

        string[] stringArray = new string[length];
        
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter string [{i}]: ");
            stringArray[i] = Console.ReadLine().ToLower();
        }

        // Binary search needed a sorted array of elements to perform the search
        Array.Sort(stringArray);

        Console.Write("\nEnter string to search in the list: ");
        string searchTerm = Console.ReadLine();

        int beg = 0, end = length - 1, mid;
        bool found = false;

        while (beg <= end)
        {
            mid = (beg + end) / 2;

            if (searchTerm.ToLower() == stringArray[mid])
            {
                Console.WriteLine($"\nString \"{searchTerm}\" is found\n");
                found = true;
                break;
            }
            else if (searchTerm.ToLower().CompareTo(stringArray[mid]) < 0)
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
            Console.WriteLine($"\nString \"{searchTerm}\" is not found\n");
        }
    }
}

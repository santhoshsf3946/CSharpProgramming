using System;
namespace CharacterBinarySearch;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ Character Binary Search ================\n");

        Console.Write("Enter number of characters of a list: ");
        int length = int.Parse(Console.ReadLine());

        char[] charArray = new char[length];
        
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter character [{i}]: ");
            charArray[i] = Console.ReadLine().ToLower()[0];
        }

        // Binary search needed a sorted array of elements to perform the search
        Array.Sort(charArray);

        Console.Write("\nEnter character to search in the list: ");
        char searchTerm = Console.ReadLine().ToLower()[0];

        int beg = 0, end = length - 1, mid;
        bool found = false;

        while (beg <= end)
        {
            mid = (beg + end) / 2;

            if (searchTerm == charArray[mid])
            {
                Console.WriteLine($"\nCharacter \"{searchTerm}\" is found\n");
                found = true;
                break;
            }
            else if (searchTerm < charArray[mid])
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
            Console.WriteLine($"\nCharacter \"{searchTerm}\" is not found\n");
        }
    }
}

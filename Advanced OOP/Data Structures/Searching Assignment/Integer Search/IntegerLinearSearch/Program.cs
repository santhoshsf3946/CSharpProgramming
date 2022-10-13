using System;
namespace InetegerLinearSearch;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ Integer Linear Search ================\n");

        Console.Write("Enter number of elements of a list: ");
        int length = int.Parse(Console.ReadLine());

        int[] integerArray = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter number [{i}]: ");
            integerArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nEnter number to search in the list: ");
        int searchTerm = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < length; i++)
        {
            if (integerArray[i] == searchTerm)
            {
                Console.WriteLine($"\nNumber {searchTerm} is found at the index position: {i}\n");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"\nNumber {searchTerm} is not found\n");
        }
    }
}

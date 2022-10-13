using System;
namespace StringLinearSearch;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ String Linear Search ================\n");

        Console.Write("Enter number of strings of a list: ");
        int length = int.Parse(Console.ReadLine());

        string[] stringArray = new string[length];
        
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter string [{i}]: ");
            stringArray[i] = Console.ReadLine().ToLower();
        }

        Console.Write("\nEnter string to search in the list: ");
        string searchTerm = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < length; i++)
        {
            if (searchTerm.ToLower() == stringArray[i])
            {
                Console.WriteLine($"\nString \"{searchTerm}\" is found at the index: {i}\n");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"\nString \"{searchTerm}\" is not found\n");
        }
    }
}

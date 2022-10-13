using System;
namespace CharacterLinearSearch;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ Character Linear Search ================\n");

        Console.Write("Enter number of characters of a list: ");
        int length = int.Parse(Console.ReadLine());

        char[] charArray = new char[length];
        
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter character [{i}]: ");
            charArray[i] = Console.ReadLine().ToLower()[0];
        }

        Console.Write("\nEnter character to search in the list: ");
        char searchTerm = Console.ReadLine().ToLower()[0];

        bool found = false;

        for (int i = 0; i < length; i++)
        {
            if (searchTerm == charArray[i])
            {
                Console.WriteLine($"\nCharacter \"{searchTerm}\" is found at the index: {i}\n");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"\nCharacter \"{searchTerm}\" is not found\n");
        }
    }
}

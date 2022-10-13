using System;
namespace ExNine;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the string: ");
        string text = Console.ReadLine();

        Console.Write("Input the substring to search: ");
        string searchText = Console.ReadLine();

        if (text.Contains(searchText))
        {
            Console.WriteLine("The substring exists in the string");
        }
        else
        {
            Console.WriteLine("The substring not exists in the string");
        }
    }
}

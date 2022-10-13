using System;
namespace StringAssignment;

public class Program
{
    public static void Main(string[] args)
    {
        string mainString, searchString;
        int occurrence = 0;

        Console.WriteLine("Enter the Main string: ");
        mainString = Console.ReadLine();

        Console.WriteLine("Enter the string to be searched: ");
        searchString = Console.ReadLine();

        for (int i = 0; i < mainString.Length - searchString.Length + 1; i++)
        {
            if(searchString.Equals(mainString.Substring(i, searchString.Length)))
            {
                occurrence++;
            }
        }

        Console.WriteLine($"String searched count is: {occurrence}");
    }
}

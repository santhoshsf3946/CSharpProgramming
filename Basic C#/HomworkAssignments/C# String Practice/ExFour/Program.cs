using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the string: ");
        string text = Console.ReadLine();

        string[] splittedText = text.Split();

        Console.WriteLine("Total number of words in the string is: " + splittedText.Length);
    }
}

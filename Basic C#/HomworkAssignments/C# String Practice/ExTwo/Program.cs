using System;
namespace ExTwo;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the string: ");
        string sentence = Console.ReadLine();

        char[] charArray = sentence.ToCharArray();

        Console.WriteLine("The characters of the string are: ");
        foreach (char letter in charArray)
        {
            Console.Write(letter + " ");
        }
    }
}

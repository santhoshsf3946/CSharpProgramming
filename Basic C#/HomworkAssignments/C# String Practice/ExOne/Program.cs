using System;
namespace ExOne;

public class Program
{
    public static void Main(string[] args)
    {
        int length = 0;

        Console.Write("Input the string: ");
        string sentence = Console.ReadLine();

        foreach (char letter in sentence)
        {
            length++;      
        }

        Console.WriteLine("Length of the string: " + length);
    }
}

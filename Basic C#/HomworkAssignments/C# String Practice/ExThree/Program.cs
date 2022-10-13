using System;
namespace ExThree;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the string: ");
        string sentence = Console.ReadLine();

        char[] charArray = sentence.ToCharArray();

        Console.WriteLine("The characters of the string in reverse are: ");
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            Console.Write(charArray[i] + " ");
        }
    }
}

using System;
namespace ExEleven;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        string resultText = "";

        Console.WriteLine("Original string: " + text);

        foreach (char letter in text)
        {
            if (!resultText.Contains(letter))
            {
                resultText += letter;
            }
        }

        Console.WriteLine("After removing duplicates characters from the said string: " + resultText);
    }
}

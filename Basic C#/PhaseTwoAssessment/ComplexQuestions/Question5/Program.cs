using System;
namespace Question5;

public class Program
{
    public static void Main(string[] args)
    {
        string text, reversedText;
        string originalText;
        char[] textArray;

        Console.WriteLine("============= Palindrome or Not =============\n");

        Console.Write("Enter a string: ");
        originalText = Console.ReadLine();
        text = originalText.ToLower();

        textArray = text.ToCharArray();

        Array.Reverse(textArray);

        reversedText = string.Join("", textArray);

        if (text == reversedText) 
        {
            Console.WriteLine(originalText + " is a Palindrome");
        }
        else
        {
            Console.WriteLine(originalText + " is not a Palindrome");
        }
    }
}

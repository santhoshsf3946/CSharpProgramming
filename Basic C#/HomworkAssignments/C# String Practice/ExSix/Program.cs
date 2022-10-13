using System;
namespace ExSix;

public class Program
{
    public static void Main(string[] args)
    {
        int alphabetCount = 0, digitCount = 0, specialCharacterCount = 0;

        Console.Write("Input the string: ");
        string text = Console.ReadLine();

        foreach (char letter in text)
        {
            if ('a' <= letter && letter <= 'z' || 'A' <= letter && letter <= 'Z')
            {
                alphabetCount++;
            }
            else if ('0' <= letter && letter <= '9')
            {
                digitCount++;
            }
            else
            {
                specialCharacterCount++;
            }
        }
        
        Console.WriteLine("Number of Alphabets in the string is: " + alphabetCount);
        Console.WriteLine("Number of Digits in the string is: " + digitCount);
        Console.WriteLine("Number of Special Characters in the string is: " + specialCharacterCount);
    }
}

using System;
namespace ExSeven;

public class Program
{
    public static void Main(string[] args)
    {
        int vowelCount = 0, consonantCount = 0;

        Console.WriteLine("============= Voweland and Consonants =============");

        Console.Write("Input the string: ");
        string text = Console.ReadLine().ToLower();

        foreach (char letter in text)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                vowelCount++;
            }
            else if('a' <= letter && letter <= 'z')
            {
                consonantCount++;
            }
        }

        Console.WriteLine("The total number of vowel in the string: " + vowelCount);
        Console.WriteLine("The total number of consonant in the string: " + consonantCount);
    }
}

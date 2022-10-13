using System;
namespace ExSeven;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a String: ");
        string word = Console.ReadLine();

        if (isPalindrome(word))
        {
            Console.WriteLine("The String is a Palindrome");
        }
        else
        {
            Console.WriteLine("The String is not a Palindrome");
        }

        bool isPalindrome(string phrase)
        {
            phrase = phrase.ToLower();
            string newWord = "";
            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                newWord += phrase[i];
            }

            return word.ToLower().Equals(newWord);
        }
    }
}

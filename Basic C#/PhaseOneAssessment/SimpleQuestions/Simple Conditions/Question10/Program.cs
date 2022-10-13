using System;
namespace Question10;

public class Program
{
    public static void Main(string[] args)
    {
        char charater;

        Console.WriteLine("================ Vowel or Not Vowel ================\n");

        Console.Write("Enter a charater: ");
        charater = Console.ReadLine().Trim().ToLower()[0];

        if (charater == 'a' || charater == 'e' || charater == 'i' ||  charater == 'o' || charater == 'u')
        {
            Console.WriteLine("It is a Vowel\n");
        }
        else if ('a' <= charater && charater <= 'z')
        {
            Console.WriteLine("It is not a Vowel\n");
        }
    }
}

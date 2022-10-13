using System;
namespace Question8;

public class Program
{
    public static void Main(string[] args)
    {
        string text, number = "";

        Console.Write("Enter the string: ");
        text = Console.ReadLine();

        foreach (char letter in text)
        {
            if (char.IsDigit(letter))
            {
                number += letter;
            }
        }

        if (int.Parse(number) % 2 == 0)
        {
            Console.WriteLine("\n" + number + " is Even number\n");
        }
        else
        {
            Console.WriteLine("\n" + number + " is Odd number\n");
        }
    }
}
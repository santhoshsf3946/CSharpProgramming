using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        int number, value, reverseNumber = 0;
        string result;

        Console.WriteLine("============ Palindrome or Not ============\n");

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        
        value = number;

        while (value > 0)
        {
            reverseNumber *= 10;
            reverseNumber += value % 10;
            value /= 10;
        }

        result = number == reverseNumber ? "is Palindrome" : "is not a Palindrome";
        Console.WriteLine(number + " " + result);
    }
}

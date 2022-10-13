using System;
namespace ExThirteen;

public class Program
{
    public static void Main(string[] args)
    {
        int sum = 0, number;
        bool flag = false;

        Console.Write("Enter input string: ");
        string text = Console.ReadLine();

        foreach (char letter in text)
        {
            flag = int.TryParse(letter + "", out number);

            if (flag)
            {
                sum += number;
            }
        }

        Console.WriteLine("Sum of numbers in the string: " + sum);
    }
}

using System;
namespace Question5;

public class Program
{
    public static void Main(string[] args)
    {
        int n;

        Console.WriteLine("============ Leap Year from 1 to N ============\n");

        Console.Write("Enter the value of N: ");
        n = int.Parse(Console.ReadLine());

        DateTime date = new DateTime();

        date = date.AddYears(n - 1);

        Console.WriteLine($"Leap years from 1 to {n}: ");

        for (int i = 1; i <= n; i++)
        {
            if (DateTime.IsLeapYear(i))
            {
                Console.Write(i + " ");
            }
        }
    }
}
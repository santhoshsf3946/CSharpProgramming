using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        int count = 8;

        double sum = 3;

        for (int i = 2; i <= count; i++)
        {
            sum += (Math.Pow(2, i) / Factorial(i));
        }

        Console.WriteLine("The result is = " + Math.Round(sum, 4));

        int Factorial(int number)
        {
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}

using System;
namespace ExNine;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=========== Armstrong Number ===========");

        Console.Write("Enter a number: ");
        string numString = Console.ReadLine();
        int length = numString.Length;
        int num = int.Parse(numString);
        int val = num, sum = 0, reminder;
        
        while (num > 0)
        {
            reminder = num % 10;
            sum += (int) Math.Pow(reminder, length);
            num /= 10;
        }

        if (sum == val)
        {
            Console.WriteLine($"{val} is Armstrong number");
        }
        else
        {
            Console.WriteLine($"{val} is not an Armstrong number");
        }
    }
}

using System;
namespace ExFive;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=============== Sum of Digits ===============");
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int value = number, sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        
        Console.WriteLine($"Sum of digits of {value} is {sum}");
    }
}

using System;
namespace ExThree;

public class Program
{
    public static void Main(string[] args)
    {
        int number1, number2;

        Console.Write("Enter first number: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        number2 = int.Parse(Console.ReadLine());

        Swap();

        Console.WriteLine($"\nNow the 1st number is: {number1}, and the second 2nd number is: {number2}");



        void Swap()
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}

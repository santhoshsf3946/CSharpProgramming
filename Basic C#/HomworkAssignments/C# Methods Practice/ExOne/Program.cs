using System;
namespace ExOne;

public class Program
{
    public static void Main(string[] args)
    {
        int number1, number2;

        Console.WriteLine("============= Calculator =============");

        Console.Write("Enter first number: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        number2 = int.Parse(Console.ReadLine());

        Addition(number1, number2);
        Substraction(number1,  number2);
        Multiplication(number1, number2);
        Divison(number1, number2);

        void Addition(int value1, int value2)
        {
            Console.WriteLine($"Addition: {value1 + value2}");
        }

        void Substraction(int value1, int value2)
        {
            Console.WriteLine($"Substraction: {value1 - value2}");
        }

        void Multiplication(int value1, int value2)
        {
            Console.WriteLine($"Multiplication: {value1 * value2}");
        }

        void Divison(int value1, int value2)
        {
            Console.WriteLine($"Divison: {value1 / value2}");
        }
    }
}

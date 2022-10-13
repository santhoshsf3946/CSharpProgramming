using System;
namespace SwitchStatement;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first value: ");
        double value1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second value: ");
        double value2 = double.Parse(Console.ReadLine());
        Console.Write("Enter one of the mentioned operation (+, -, *, /, %): ");
        char oper = Console.ReadLine()[0];

        switch (oper)
        {
            case '+':
            {
                Console.WriteLine($"{value1} + {value2} = {value1 + value2}");
                break;
            }
            case '-':
            {
                Console.WriteLine($"{value1} - {value2} = {value1 - value2}");
                break;
            }
            case '*':
            {
                Console.WriteLine($"{value1} * {value2} = {value1 * value2}");
                break;
            }
            case '/':
            {
                Console.WriteLine($"{value1} / {value2} = {value1 / value2}");
                break;
            }
            case '%':
            {
                Console.WriteLine($"{value1} % {value2} = {value1 % value2}");
                break;
            }
            default:
            {
                Console.WriteLine("Operation Invalid");
                break;
            }
        }
    }
}

using System;

namespace ExTwo;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Input the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
    }
}

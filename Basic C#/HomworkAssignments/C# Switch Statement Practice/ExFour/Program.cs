using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Select one of the options from the lis,");
        Console.WriteLine("1 - Addition\n2 - Substraction\n3 - Multiplication\n4 - Division\n5 - Exit");
        Console.Write("Input your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            {
                Console.WriteLine($"The Addition of {num1} and {num2} is: {num1 + num2}");
                break;
            }
            case 2:
            {
                Console.WriteLine($"The Substraction of {num1} and {num2} is: {num1 - num2}");
                break;
            }
            case 3:
            {
                Console.WriteLine($"The Multiplication of {num1} and {num2} is: {num1 * num2}");
                break;
            }
            case 4:
            {
                Console.WriteLine($"The Division of {num1} and {num2} is: {num1 / num2}");
                break;
            }
            case 5:
            {
                break;
            }
            default:
            {
                Console.WriteLine("Invalid input");
                break;
            }
        }
    }
}

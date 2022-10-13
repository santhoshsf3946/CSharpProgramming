using System;
namespace MethodsAssignment;

public class Program
{
    public static void Main(string[] args)
    {
        int choice, number1, number2;
        string option;

        Console.Write("============= Calculator =============");

        do
        {
            Console.WriteLine("\n\t1. Addition\n\t2. Substraction\n\t3. Multiplication\n\t4. Divison");
            Console.Write("\nChoose the one of the above option: ");

            choice  = int.Parse(Console.ReadLine());

            GetNumbers();

            switch (choice)
            {
                case 1:
                {
                    Console.Write($"\n\t{number1} + {number2} = {Addition(number1, number2)}");
                    break;
                }
                case 2:
                {
                    Console.Write($"\n\t{number1} - {number2} = {Substraction(number1, number2)}");
                    break;
                }
                case 3:
                {
                    Console.Write($"\n\t{number1} X {number2} = {Multiplication(number1, number2)}");
                    break;
                }
                case 4:
                {
                    Console.Write($"\n\t{number1} / {number2} = {Division(number1, number2)}");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInvalid Input");
                    break;
                }
            }
                
            Console.Write("\n\nDo you want to continue: ");
            option = Console.ReadLine().ToLower();
            
        } while (option == "yes");

        int Addition(int value1, int value2)
        {
            return value1 + value2;
        }

        int Substraction(int value1, int value2)
        {
            return value1 - value2;
        }

        int Multiplication(int value1, int value2)
        {
            return value1 * value2;
        }

        int Division(int value1, int value2)
        {
            return value1 / value2;
        }

        void GetNumbers()
        {
            Console.Write("\n\tEnter first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("\tEnter second number: ");
            number2 = int.Parse(Console.ReadLine());
        }
    }
}

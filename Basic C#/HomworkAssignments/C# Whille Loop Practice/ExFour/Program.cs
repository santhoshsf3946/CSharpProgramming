using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        bool flag = false;
        int number = 0;

        Console.Write("Enter a number: ");

        bool condition = !flag && number < 1 && number > 5;

        while(!flag || number < 1 || number > 5)
        {
            flag = int.TryParse(Console.ReadLine(), out number);

            if (!flag || number < 1 || number > 5)
            {
                Console.Write("Invalid input. Enter again: ");
            }
        }
        Console.WriteLine($"{number} is a Valid input");
    }
}

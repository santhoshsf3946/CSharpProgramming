using System;
namespace ExFour;

public class Program
{
    public static void Main(string[] args)
    {
        bool flag = false;
        int number = 0;

        Console.WriteLine("============== Valid number program ==============");
        
        Console.Write("Enter a number: ");
        do
        {
            flag = int.TryParse(Console.ReadLine(), out number);
            
            if (!flag || number < 1 || number > 10)
            {
                Console.Write("Invalid input. Enter again: ");
            }
        } while (!flag || number < 1 || number > 10);

        Console.WriteLine($"{number} is a valid integer");
    }
}

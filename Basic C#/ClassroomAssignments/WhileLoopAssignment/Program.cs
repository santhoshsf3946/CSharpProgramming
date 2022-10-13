using System;
namespace WhileLoopAssignment;

public class Program
{
    public static void Main(string[] args)
    {
        int i = 0;

        while (i < 25)
        {
            Console.WriteLine(i);
            i += 2;
        }

        Console.WriteLine("==========================================");

        double number = 0;
        bool flag = false;

        while (!flag)
        {
            Console.Write("Enter number: ");
            flag = double.TryParse(Console.ReadLine(),out number);
            if (!flag)
            {
                Console.WriteLine("Invalid input format. Please Enter the input format");
            }
        }
        Console.WriteLine($"Entered number is {number}");
    }
}

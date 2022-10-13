using System;
namespace ExEight;

public class Program
{
    public static void Main(string[] args)
    {
        int mark1, mark2, mark3;
        
        GetDetails();

        Console.WriteLine("Mark 1: " + mark1);
        Console.WriteLine("mark 2: " + mark2);
        Console.WriteLine("Mark 3: " + mark3);

        Console.WriteLine("percentage: " + CalculatePercentage(mark1, mark2, mark3));

        void GetDetails()
        {
            Console.Write("Enter Mark 1: ");
            mark1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Mark 2: ");
            mark2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Mark 3: ");
            mark3 = int.Parse(Console.ReadLine());
        }

        int CalculatePercentage(int number1, int number2, int number3)
        {
            return (number1 + number2 + number3) / 3;
        }
    }
}

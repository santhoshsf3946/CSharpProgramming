using System;
namespace Question4;

public class Program
{
    public static void Main(string[] args)
    {
        int lower, upper;

        Console.WriteLine("============ Arms Strong Number ============\n");

        Console.Write("Enter lower limit: ");
        lower = int.Parse(Console.ReadLine());

        Console.Write("Enter upper limit: ");
        upper = int.Parse(Console.ReadLine());

        for (int i = lower; i <= upper; i++)
        {
            if (isArmstrongNumber(i))
            {
                Console.Write(i + " ");
            }
        }

        bool isArmstrongNumber(int number)
        {
            int value = number, sum = 0, reminder, digits;
            string stringNumber = number + "";
            digits = stringNumber.Length;
            
            while (value > 0)
            {
                reminder = value % 10;
                sum += (int) Math.Pow(reminder, digits);
                value /= 10;
            }

            return sum == number;
        }
    }
}
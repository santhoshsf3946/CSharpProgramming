using System;
namespace Question10;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================== Firm ==================\n");

        Console.Write("Enter how much hours needed for completing the project: ");
        int neededHours = int.Parse(Console.ReadLine());

        Console.Write("Enter the days that the firm has: ");
        int daysLeft = int.Parse(Console.ReadLine());

        Console.Write("Enter number of workers: ");
        int numberOfWorkers = int.Parse(Console.ReadLine());

        double workedHours = daysLeft * 0.9 * 10 * numberOfWorkers;

        if (workedHours > neededHours)
        {
            Console.WriteLine($"\nYes! {(int) (workedHours - neededHours)} hours left.\n");
        }
        else
        {
            Console.WriteLine($"\nNot enough time! {(int) (neededHours - workedHours)} hours needed\n");
        }
    }
}

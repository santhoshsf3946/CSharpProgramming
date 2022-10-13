using System;
namespace ExTwelve;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime();

        Console.Write("Input the month number: ");
        date = date.AddMonths(int.Parse(Console.ReadLine()) - 1);

        Console.Write("Input the year: ");
        date = date.AddYears(int.Parse(Console.ReadLine()) - 1);
        
        date = date.AddDays(-1);
        date = date.AddMonths(1);

        Console.WriteLine($"The number of days in the month {date.ToString("MMMM")} is: {date.Day}");
    }
}

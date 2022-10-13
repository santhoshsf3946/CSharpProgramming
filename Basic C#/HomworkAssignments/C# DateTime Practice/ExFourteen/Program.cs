using System;
namespace ExFourteen;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime();
        Console.Write("Enter Month : ");

        date = date.AddMonths(int.Parse(Console.ReadLine()) - 1);

        TimeSpan span = new TimeSpan(DateTime.DaysInMonth(date.Year, date.Month), 0, 0, 0);

        Console.Write("Enter number of leaves taken: ");

        span = span.Subtract(new TimeSpan(int.Parse(Console.ReadLine()), 0, 0, 0));

        Console.WriteLine("Salary: Rs. " + span.TotalDays * 500);
    }
}

using System;
namespace ExNine;

public class Program
{
    public static void Main(string[] args)
    {
        for (int year = 1994; year <= 2014; year++)
        {
            if (DateTime.IsLeapYear(year))
            {
                DateTime date = new DateTime(year, 2, 29);
                Console.WriteLine(year + " is a leap year");
                Console.WriteLine($"\tOne year from {date.ToShortDateString()} is {date.AddYears(1).ToShortDateString()}\n");
            }
        }
    }
}

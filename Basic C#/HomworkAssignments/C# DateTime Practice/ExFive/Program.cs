using System;
namespace ExFive;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the starting year: ");
        int startYear = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending year: ");
        int endYear = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int year = startYear; year <= endYear; year++)
        {
            DateTime date = new DateTime(year, 12, 31);
            string isLeapYear = date.DayOfYear == 366 ? "(Leap Year)" : "";
            Console.WriteLine($"12/31/{year}: day {date.DayOfYear} of {year} {isLeapYear}");
        }
    }
}

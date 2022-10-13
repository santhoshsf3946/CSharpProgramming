using System;
namespace ExSix;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Today = " + date);

        date.AddDays(40);
        Console.WriteLine("Day of week after 40 days: " + date.DayOfWeek);
    }
}

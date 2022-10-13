using System;
namespace ExTen;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Yesterday: " + currentDate.AddDays(-1).ToShortDateString());
        Console.WriteLine("Tomorrow: " + currentDate.AddDays(1).ToShortDateString());
    }
}

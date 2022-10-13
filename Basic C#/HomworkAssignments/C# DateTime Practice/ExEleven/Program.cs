using System;
namespace ExEleven;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("The name of the months of a year: ");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("The date of Today: " + currentDate.ToShortDateString());
        Console.WriteLine("\nThe Twelve months are: ");
        
        for (int month = 0; month < 12; month++)
        {
            Console.WriteLine(currentDate.AddMonths(month).ToString("MMMM"));
        }
    }
}

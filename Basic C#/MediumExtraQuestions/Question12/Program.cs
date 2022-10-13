using System;
namespace Question12;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================ Volley Ball ================\n");

        Console.Write("Enter the year is leap or not ( Leap / Normal ): ");
        string yeartype = Console.ReadLine().Trim().ToLower();

        Console.Write("Enter the count of holidays in the year: ");
        double holidayCount = int.Parse(Console.ReadLine());

        Console.Write("Enter the count of weekends in the year: ");
        int travellingCount = int.Parse(Console.ReadLine());

        double totalPlayedTime = (double) (48 * 3 / 4 + holidayCount * 2 / 3);

        if (yeartype == "leap")
        {
            totalPlayedTime += totalPlayedTime * 0.15;
            totalPlayedTime = Math.Round(totalPlayedTime, 0, MidpointRounding.ToNegativeInfinity);
        }
        else
        {
            totalPlayedTime = Math.Round(totalPlayedTime, 0, MidpointRounding.ToPositiveInfinity);
        }

        Console.WriteLine($"\nNumber of times Vladimir has played Volley Ball through the year: {totalPlayedTime}\n");
    }
}

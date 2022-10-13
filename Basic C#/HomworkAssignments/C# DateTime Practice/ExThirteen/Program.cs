using System;
namespace ExThirteen;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime();

        Console.Write("Input the Day: ");
        date = date.AddDays(int.Parse(Console.ReadLine()) - 1);

        Console.Write("Input the Month: ");
        date = date.AddMonths(int.Parse(Console.ReadLine()) - 1);

        Console.Write("Input the Year: ");
        date = date.AddYears(int.Parse(Console.ReadLine()) - 1);

        Console.WriteLine("The formatted date is: " + date.ToShortDateString());

        for (int i = 0; i < 7; i++)
        {
            if (date.DayOfWeek.ToString() == "Saturday")
            {
                Console.WriteLine("The last day of the week for the above date is: " + date.ToShortDateString());
            }
            date = date.AddDays(1);
        }
    }
}

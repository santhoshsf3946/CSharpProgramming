using System;
namespace ExEight;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;
        
        DateTime futureDate = currentDate.AddYears(1);
        DateTime pastDate = currentDate.AddYears(-1);

        Console.WriteLine(currentDate.ToShortDateString() + " is later than " + pastDate.ToShortDateString());
        Console.WriteLine(currentDate.ToShortDateString() + " is earlier than " + futureDate.ToShortDateString());
    }
}

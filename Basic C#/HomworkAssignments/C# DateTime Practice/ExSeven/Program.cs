using System;
namespace ExSeven;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime firstDate = new DateTime(2016, 1, 8, 0, 0, 0);
        DateTime secondDate = new DateTime(2016, 1, 8, 12, 0, 0);

        if (firstDate == secondDate)
        {
            Console.WriteLine($"{firstDate} is equal to {secondDate}");
        }
        else if (firstDate < secondDate)
        {
            Console.WriteLine($"{firstDate} is earlier than {secondDate}");
        }
        else
        {
            Console.WriteLine($"{firstDate} is later than {secondDate}");
        }
    }
}

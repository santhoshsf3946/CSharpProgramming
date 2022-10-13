using System;
namespace ExFive;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=============== Fovorite Cricket Players ===============");

        Console.WriteLine("Choose the Country: ");
        Console.WriteLine("\tIndia\n\tPakistan\n\tBangladesh");
        Console.Write("Enter your choice: ");
        string country = (Console.ReadLine()).ToLower();
        Console.WriteLine("\nPlayers list");
        Console.WriteLine("-------------");

        switch (country)
        {
            case "india":
            {
                Console.WriteLine("\t1. Gambir\n\t2. Ashwin\n\t3. Dhoni\n\t4. Jadeja");
                break;
            }
            case "pakistan":
            {
                Console.WriteLine("\t1. Babar Azam\n\t2. Mohammad Hafeez\n\t3. Mohammad Yousuf\n\t4. Inzamam-Haq");
                break;
            }
            case "bangladesh":
            {
                Console.WriteLine("\t1. Mohammad Rafique\n\t2. Habibul Bashar\n\t3. Shakib Al Hasan\n\t4. Shahadat Hossain");
                break;
            }
            default:
            {
                Console.WriteLine("\tPlayers not available");
                break;
            }
        }
    }
}

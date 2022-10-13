using System;
namespace ExOne;

public class Program
{
    public static void Main(string[] args)
    {
        int number = 0;
        string ans = "";

        Console.WriteLine("============= Odd or Even =============\n");
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an Even number");
            }
            else
            {
                Console.WriteLine($"{number} is an Odd number");
            }

            Console.Write("Do you want to check another number: ");
            ans = (Console.ReadLine()).ToLower();
            while(!(ans == "yes" || ans == "no"))
            {
                Console.Write("Invalid output. Please enter a valid input: ");
                ans = Console.ReadLine().ToLower();
            }
        } while (ans == "yes");
    }
}

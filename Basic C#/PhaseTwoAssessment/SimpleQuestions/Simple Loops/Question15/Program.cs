using System;
namespace Question15;

public class Program
{
    public static void Main(string[] args)
    {
        int number, count = 0;
        string choice;

        Console.WriteLine("============ Prime or Not ============");

        do
        {
            Console.Write("\nEnter a number: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                count = number % i == 0 ? count + 1 : count + 0;
            }
            if (count == 2)
            {
                Console.WriteLine(number + " is a Prime number");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime number");
            }
            
            count = 0;

            Console.Write("\nDo you want to continue: ");
            choice = Console.ReadLine().ToLower();
        } while(choice == "yes");
    }
}

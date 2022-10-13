using System;
namespace ExOne;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Grade: ");
        char grade = Console.ReadLine()[0];

        switch (grade)
        {
            case 'E':
            {
                Console.WriteLine("Excellent");
                break;
            }
            case 'V':
            {
                Console.WriteLine("Very Good");
                break;
            }
            case 'G':
            {
                Console.WriteLine("Good");
                break;
            }
            case 'A':
            {
                Console.WriteLine("Average");
                break;
            }
            case 'F':
            {
                Console.WriteLine("Fail");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid grade");
                break;
            }
        }
        
    }
}

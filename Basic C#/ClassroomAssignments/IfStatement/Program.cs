using System;
namespace IfStatement;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Mark: ");
        int mark = int.Parse(Console.ReadLine());
        if (mark >= 0 && mark <= 100)
        {
            if (mark > 80)
            {
                Console.WriteLine("Grade A");
            } else if (mark > 60) {
                Console.WriteLine("Grade B");
            } else if (mark >= 60) {
                Console.WriteLine("Grade C");
            } else if (mark >= 35) {
                Console.WriteLine("Grade D");
            } else {
                Console.WriteLine("Invalid input");
            }
        } else {
            Console.WriteLine("Invalid input");
        }
        
    }
}

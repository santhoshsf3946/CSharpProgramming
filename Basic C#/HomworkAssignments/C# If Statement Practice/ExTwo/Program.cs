using System;
namespace ExTwo;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your Age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18) {
            Console.WriteLine("Congratulation!\nYou are eligible for casting your vote.");
        } else {
            Console.WriteLine("Sorry!\nYou are not eligiblle for casting your vote");
        }
    }
}

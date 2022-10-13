using System;
namespace ExTen;

public class Program
{
    public static void Main(string[] args)
    {
        string storedUsername = "user", storedPassword = "pass";

        Console.Write("Input a username : ");
        string enteredUsername = Console.ReadLine();

        Console.Write("Input a password: ");
        string enteredpassword = Console.ReadLine();

        if (enteredUsername == storedUsername)
        {
            if (enteredpassword == storedPassword)
            {
                Console.WriteLine("Username and password entered successfully!");
            }
            else
            {
                Console.WriteLine("Entered password is wrong!");
            }
        }
        else
        {
            Console.WriteLine("Username not found!");
        }
    }
}

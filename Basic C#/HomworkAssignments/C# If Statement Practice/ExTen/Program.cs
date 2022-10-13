using System;
namespace ExTen;

public class Program
{
    public static void Main(string[] args)
    {
        string defaultPassword = "HiTeam";
        Console.Write("Enter password: ");
        string enteredPassword = Console.ReadLine();

        if (enteredPassword == defaultPassword)
        {
            Console.WriteLine("Right password");
        }
        else
        {
            Console.WriteLine("Wrong password");
        }
    }
}

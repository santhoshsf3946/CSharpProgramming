using System;
namespace Question6;

public class Program
{
    public static void Main(string[] args)
    {
        string storedpassword = "s3cr3t!P@ssw0rd", enteredPassword;

        Console.WriteLine("============== Password Validator ==============\n");

        Console.Write("Enter the password: ");
        enteredPassword = Console.ReadLine();

        if (storedpassword == enteredPassword)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}

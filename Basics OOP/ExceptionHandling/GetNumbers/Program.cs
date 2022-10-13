using System;
namespace GetNmbers;

public class Program
{
    public static void Main(string[] args)
    {

        try
        {
            Console.Write("\nEnter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = firstNumber / secondNumber;

            Console.WriteLine("\n" + firstNumber + " / " + secondNumber + " = " + thirdNumber);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("\n" + e.Message);
            Console.WriteLine(e.StackTrace);
        }
        catch (FormatException e)
        {
            Console.WriteLine("\n" + e.Message);
            Console.WriteLine(e.StackTrace);
        }
        catch (Exception e)
        {
            Console.WriteLine("\n" + e.Message);
            Console.WriteLine(e.StackTrace);
        }
        finally
        {
            Console.WriteLine("\nTerminating...\n");
        }
    }
}

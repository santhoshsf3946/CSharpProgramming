using System;
namespace EnumTypes;

public class Program
{
    public enum Gender { Default, Male, Female, Transgender }
    public static void Main(string[] args)
    {
        Console.Write("Select Gender1 option: ");
        Gender gender1 = Enum.Parse<Gender>(Console.ReadLine(), true); // true will ignore casing
        Console.WriteLine(gender1);

        Console.Write("Console Gender2 option: ");
        Gender gender2;
        bool temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender2);

        while (!temp || !((int) gender2 > 0 && (int) gender2 < 4))
        {
            Console.Write("Invalid Gender\nTry again: ");
            temp = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender2);
        }

        Console.WriteLine(gender2);
    }
}

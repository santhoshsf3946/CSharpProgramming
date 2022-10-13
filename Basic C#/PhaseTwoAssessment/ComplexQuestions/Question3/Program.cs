using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        string nameOne, nameTwo;
        char[] nameOneArray, nameTwoArray;

        Console.WriteLine("=========== Anagram Checking ===========\n");

        Console.Write("Enter Name one: ");
        nameOne = Console.ReadLine().ToLower();

        Console.Write("Enter Name two: ");
        nameTwo = Console.ReadLine().ToLower();

        nameOneArray = nameOne.ToCharArray();
        nameTwoArray = nameTwo.ToCharArray();

        Array.Sort(nameOneArray);
        Array.Sort(nameTwoArray);

        nameOne = String.Join("", nameOneArray);
        nameTwo = string.Join("", nameTwoArray);

        if (nameOne == nameTwo)
        {
            Console.WriteLine("Name one and two are Anagrams");
        }
        else
        {
            Console.WriteLine("Name one and two are not Anagrams");
        }
    }
}
using System;
namespace ArrayAssignment;

public class Program
{
    public static void Main(string[] args)
    {
        int index = 0;
        bool found = false;
        Console.WriteLine("========== Array Manipulation ==========");

        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        string[] names = new string[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter name: ");
            names[i] = Console.ReadLine();
        }

        Console.WriteLine("\nNames present in te array,");
        foreach(string name in names)
        {
            Console.WriteLine("\t" + name);
        }

        Console.Write("\nEnter a name to search: ");
        string searchName = Console.ReadLine();

        Console.WriteLine("\nFor Loop");
        Console.WriteLine("--------");
        for (int i = 0; i < size; i++)
        {
            if (searchName == names[i])
            {
                Console.WriteLine("The name is present in the array");
                Console.WriteLine("Index is: " + i);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("The name is not present in the array");
            found = false;
        }

        Console.WriteLine("\nForeach Loop");
        Console.WriteLine("--------");
        foreach (string name in names)
        {
            if (name == searchName)
            {
                Console.WriteLine("The name is present in the array");
                Console.WriteLine("Index is: " + index);
                found = true;
            }
            index++;
        }

        if (!found)
        {
            Console.WriteLine("The name is not present in the array");
        }
        Console.WriteLine();
    }
}

using System;
namespace SingleCasting;

public delegate int Calculator (int n); // Can add methods having int return type & 1 int argument

public class Program
{
    static int value = 10;

    public static int AddNum (int number) 
    { 
        value += number; 
        return value; 
    }

    public static int MultNum (int number) 
    { 
        value *= number; 
        return value; 
    }

    public static int GetNum() 
    { 
        return value; 
    }

    public static void Main(string[] args)
    {
        // Create deligate instance
        Calculator calc1 = new Calculator(AddNum);
        Calculator calc2 = new Calculator(MultNum);

        //Calling the methods using the deligate objects
        calc1(25);
        Console.WriteLine($"\nValue: {GetNum()}");

        calc2(5);
        Console.WriteLine($"\nValue: {GetNum()}\n");
    }
}

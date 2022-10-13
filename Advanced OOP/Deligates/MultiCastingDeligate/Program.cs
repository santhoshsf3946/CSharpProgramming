using System;
namespace MultiCastingDeligate;

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
        // Multicasting
        // Create deligate instances
        Calculator calc;
        Calculator calc1 = new Calculator(AddNum);
        Calculator calc2 = new Calculator(MultNum);

        calc = calc1;
        calc += calc2;

        // Calling Multicast
        calc(5);
        Console.WriteLine($"\nValue: {GetNum()}\n");
    }
}

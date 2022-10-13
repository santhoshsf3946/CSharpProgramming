using System;
namespace StackDS;

public class Program
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peak());
        Console.WriteLine(stack.Peak());
        Console.WriteLine(stack.Peak());
    }
}

using System;

namespace QueueDS;

public class Program
{
    public static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Peak());
        Console.WriteLine(queue.Peak());
        Console.WriteLine(queue.Peak());
    }
}

namespace ReadWrite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name please: ");
        string myName = Console.ReadLine();

        Console.WriteLine("Your name is: " + myName);

        Console.ReadLine();
    }
}

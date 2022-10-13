namespace WriteType;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your name: ");
        string fatherName = Console.ReadLine();

        // Concatination
        Console.WriteLine("Your name is: " + name + ", Your father name is: " + fatherName);

        // Placeholder
        Console.WriteLine("Your name is: {0}, Your father name is: {1}",name, fatherName);

        //Interpolation
        Console.WriteLine($"Your name is: {name}, Your father name is: {fatherName}");
    }
}

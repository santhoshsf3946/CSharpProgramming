using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        RegisterApplication student = new RegisterApplication("Santhosh", Gender.Male, new DateTime(2000, 8, 21), 39829847, 98349347094, 36, "Development", "Iruthayaraj", "Silvia Carolin", "Rameswaram", 9492304838, "B.Tech", "Rameswaram");
        student.sem1 = new int[] { 89, 87, 98, 79, 81, 84 };
        student.sem2 = new int[] { 92, 97, 91, 85, 83, 84 };
        student.sem3 = new int[] { 89, 82, 91, 88, 82, 95 };
        student.sem4 = new int[] { 92, 93, 89, 81, 90, 96 };

        student.ShowDetails();
        if (student.CheckEligiblity())
        {
            Console.WriteLine("\nYou are eligible for admission\n");
        }
        else
        {
            Console.WriteLine("\nYou are not eligible for admission\n");
        }
    }
}

using System;
namespace StudentDetails;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========== Student Register ==========");

        Console.Write("Enter Student name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter Student's Father name: ");
        string fatherName = Console.ReadLine();

        Console.Write("Enter mobile number: ");
        long mobileNumber = long.Parse(Console.ReadLine());

        Console.Write("Enter mail id: ");
        string mailId = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter gender: ");
        char gender = char.Parse(Console.ReadLine());

        Console.WriteLine("\nSubject marks\n-------------");

        Console.Write("Enter Chemistry mark: ");
        int chemistryMark = int.Parse(Console.ReadLine());

        Console.Write("Enter Physics mark: ");
        int physicsMark = int.Parse(Console.ReadLine());

        Console.Write("Enter Maths mark: ");
        int mathsMark = int.Parse(Console.ReadLine());

        Console.WriteLine("Student registered successfully !\n");

        Console.WriteLine("========== Registered Student's Information ==========");
        Console.WriteLine($"Student name: {studentName}\nStudent's Father name: {fatherName}\nStudent Mobile number: {mobileNumber}");
        Console.WriteLine($"Student Mail ID: {mailId}\nStudent Age: {age}\nStudent Gender: {gender}\n");

        Console.WriteLine("Subject Marks\n-------------");
        Console.WriteLine($"Chemistry mark: {chemistryMark}\nPhysics mark: {physicsMark}\nMaths mark: {mathsMark}");

        double chemistryPercentage = chemistryMark / (double) 2;
        double physicsPercentage = physicsMark / (double) 2;
        double mathsPercentage = mathsMark / (double) 2;

        Console.WriteLine($"Chemistry percentage: {chemistryPercentage}%\nPhysics percentage: {physicsPercentage}%\nMaths percentage: {mathsPercentage}");

        double average = Math.Round((chemistryMark + physicsMark + mathsMark) / (double) 3, 2);
        Console.WriteLine($"Student's Average Mark: {average}\n");
        
        Console.Write("Press any key to Exit...");
        Console.ReadKey();
    }
}

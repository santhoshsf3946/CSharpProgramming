using System;
using System.IO;
using System.Collections.Generic;
namespace ListFile;

public class Program
{
    public static void Main(string[] args)
    {
        List<StudentDetails> studentDetailsList = new List<StudentDetails>();
        studentDetailsList.Add(new StudentDetails() {Name = "Santhosh", FatherName = "Iruthayaraj", Gender = Gender.Male, DOB = new DateTime(2000, 8, 21)});
        studentDetailsList.Add(new StudentDetails() {Name = "Baskaran", FatherName = "Sethurajan", Gender = Gender.Male, DOB = new DateTime(1980, 4, 11)});
        studentDetailsList.Add(new StudentDetails() {Name = "Ravichandran", FatherName = "Ettapparajan", Gender = Gender.Male, DOB = new DateTime(1975, 5, 5)});
        Insert(studentDetailsList);
        Display();
    }

    public static void Insert(List<StudentDetails> studentList)
    {
        StreamWriter write = null;
        if (!File.Exists("Data.csv"))
        {
            Console.WriteLine("\nFile doesn't exist. \n\nCreating a new CSV file...\n");
            File.Create("Data.csv");
        }
        else
        {
            Console.WriteLine("\nFile already exists\n");
        }
        
        write = new StreamWriter(File.OpenWrite("Data.csv"));

        foreach (var student in studentList)
        {
            write.WriteLine(student.Name + "," + student.FatherName + "," + student.Gender + "," + student.DOB.ToShortDateString());
        }

        write.Close();

        Console.WriteLine("\nValues inserted into file successfully\n");
    }

    public static void Display()
    {
        StreamReader reader = null;
        List<StudentDetails> studentList = new List<StudentDetails>();

        if (File.Exists("Data.csv"))
        {
            reader = new StreamReader(File.OpenRead("Data.csv"));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                if (values[0] != "")
                {
                    studentList.Add(new StudentDetails() { Name = values[0], FatherName = values[1], Gender = Enum.Parse<Gender>(values[2]), DOB = DateTime.ParseExact(values[3], "dd/MM/yyyy", null) });
                }
            }
        }
        else
        {
            Console.WriteLine("File doesn't exit");
        }
        
        reader.Close();

        Console.WriteLine("\tStudent Name\tFather Name\tGender\tDate of Birth\n\t---------\t-----------\t------\t-------------");

        foreach (var student in studentList)
        {
            Console.WriteLine($"\t{student.Name}\t{student.FatherName}\t{student.Gender}\t{student.DOB.ToShortDateString()}\n");
        }

        Console.WriteLine("\nValues readed from the file successfully\n");
    }

    static void Update()
    {
        Console.WriteLine("");
    }
}

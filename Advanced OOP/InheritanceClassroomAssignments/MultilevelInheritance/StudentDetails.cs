using System;

namespace MultilevelInheritance;

public enum Department { Default, EEE, CSE, ECE }
public class StudentDetails : PersonalDetails, IMarkDetails
{
    private static int s_studentID = 1000;

    public string StudentID { get; set; }

    public Department Department { get; set; }

    public string Year { get; set; }

    public int Physics { get; set; }  // Property declaration only allowed

    public int Chemistry { get; set; }

    public int Maths { get; set; }

    public int Total { get; set; }

    public double Average { get; set; }

    public StudentDetails(string aadhaarID, string name, string fatherName, Gender gender, long phone, Department department, string year) : base(aadhaarID, name, fatherName, gender, phone)
    {
        s_studentID++;
        StudentID = $"SID{s_studentID}";
        Department = department;
        Year = year;
    }

    public StudentDetails(string aadhaarID, string studentID, string name, string fatherName, Gender gender, long phone, Department department) : base(aadhaarID, name, fatherName, gender, phone)
    {
        StudentID = studentID;
        Department = department;
    }

    public void ShowStudentDetails()
    {
        Console.WriteLine($"\n  Student ID: {StudentID}");
        ShowDetails();
        Console.WriteLine($"  Department: {Department}\n  Year: {Year}\n");
    }

    public void GetMarks(int physics, int chemistry, int maths)
    {
        Physics = physics;
        Chemistry = chemistry;
        Maths = maths;
    }

    public void Calculate()
    {
        Total = Physics + Chemistry + Maths;
        Average = Total / 3.0;
    }

    public void ShowMark()
    {
        Console.WriteLine($"\n  Physics: {Physics}\n  Chemistry: {Chemistry}\n  Maths: {Maths}\n  Average: {Average}");
    }


}

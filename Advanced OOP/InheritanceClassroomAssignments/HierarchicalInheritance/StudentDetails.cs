using System;

namespace HierarchicalInheritance;

public enum Department { Default, EEE, CSE, ECE }
public class StudentDetails : PersonalDetails
{
    private static int s_studentID = 1000;

    public string StudentID { get; set; }

    public Department Department { get; set; }

    public string Year { get; set; }

    public StudentDetails(string aadhaarID, string name, string fatherName, Gender gender, long phone, Department department, string year) : base(aadhaarID, name, fatherName, gender, phone)
    {
        s_studentID++;
        StudentID = $"SID{s_studentID}";
        Department = department;
        Year = year;
    }

    public void ShowStudentDetails()
    {
        Console.WriteLine($"\n  Student ID: {StudentID}");
        ShowDetails();
        Console.WriteLine($"  Department: {Department}\n  Year: {Year}\n");
    }
}


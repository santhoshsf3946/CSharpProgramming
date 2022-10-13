using System;

namespace PartialClasses
{
    public partial class StudentDetails
    {
        public StudentDetails(string aadhaarID, string name, string fatherName, Gender gender, long phone, Department department, string year)
        {
            s_studentID++;
            StudentID = $"SID{s_studentID}";
            Department = department;
            Year = year;
        }

        public void ShowStudentDetails()
        {
            Console.WriteLine($"\n  Student ID: {StudentID}");
            Console.WriteLine($"  Department: {Department}\n  Year: {Year}\n");
        }
    }
}

using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("Santhosh", "Iruthayaraj", 87324847832, new DateTime(2000, 8, 21), Gender.Male, 8, "SF3946", "IT", 3);

        employee.AttendanceList.Add(new Attendance(new DateTime(2022, 10, 3), 15));
        employee.AttendanceList.Add(new Attendance(new DateTime(2022, 10, 4), 20));
        employee.AttendanceList.Add(new Attendance(new DateTime(2022, 10, 5), 24));

        employee.ShowDetails();
        employee.LogAttendance();
        employee.CalculateSalary();
        employee.DisplaySalary();
    }
}

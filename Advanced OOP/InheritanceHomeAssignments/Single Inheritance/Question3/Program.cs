using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("Santhosh", "Iruthayaraj", Gender.Male, 9789429543, new DateTime(2000, 8, 21), "Chetpet", 20000, "September");

        employee.AttendanceList.Add(new Attendance(new DateTime(2022, 10, 3), 15));
        employee.AttendanceList.Add(new Attendance(new DateTime(2022, 10, 4), 20));
        employee.AttendanceList.Add(new Attendance(new DateTime(2022, 10, 5), 25));

        employee.ShowInfo();
    }
}

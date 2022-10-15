using System;
using System.Collections.Generic;

namespace Question3
{
    public class SalaryInfo : PersonalInfo
    {
        public double SalaryOfTheMonth { get; set; }
        
        public int Month { get; set; }
        
        public List<Attendance> AttendanceList { get; set; }

        public SalaryInfo(string name, string fatherName, long mobile, DateTime dOB, Gender gender, int month) : base(name, fatherName, mobile, dOB, gender)
        {
            Month = month;
            AttendanceList = new List<Attendance>();
        }

        public void LogAttendance()
        {
            Console.WriteLine("\nAttendance List\n");
            Console.WriteLine("\t  Date\t\tNumber of Hours worked\n\t  ----\t\t---------------------");

            foreach (var attendance in AttendanceList)
            {
                Console.WriteLine($"\t  {attendance.Date.ToShortDateString()}  \t{attendance.NumberOfHoursWorked}");
            }
            
            Console.WriteLine();
        }

        public void CalculateSalary()
        {
            SalaryOfTheMonth = 500 * DateTime.DaysInMonth(0001, Month);
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"\nYour Salary for the month is: {SalaryOfTheMonth}\n");
        }
    }
}
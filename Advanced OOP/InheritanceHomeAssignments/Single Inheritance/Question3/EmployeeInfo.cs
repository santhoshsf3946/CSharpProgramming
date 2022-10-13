using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public enum Gender { Default, Male, Female, Others }

    public class EmployeeInfo : SalaryInfo
    {
        private static int s_employeeID = 1000;

        public string EmployeeID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public long Mobile { get; set; }

        public DateTime DOB { get; set; }

        public string Branch { get; set; }

        public List<Attendance> AttendanceList = new List<Attendance>();

        public EmployeeInfo(string name, string fatherName, Gender gender, long mobile, DateTime dOB, string branch, double salaryOfTheMonth, string month) : base(salaryOfTheMonth, month)
        {
            EmployeeID = $"EID{++s_employeeID}";
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dOB;
            Branch = branch;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n  Name: {Name}\n  Father Name: {FatherName}\n  Gender: {Gender}\n  Mobile Number: {Mobile}\n  Date of Birth: {DOB.ToShortDateString()}\n  Branch Name: {Branch}\n  Salary of the Mont: {SalaryOfTheMonth}\n  Month: {Month}\n  Attendance List: ");

            Console.WriteLine("\t  Date\t\tNumber of days worked\n\t  ----\t\t---------------------");

            foreach (var attendance in AttendanceList)
            {
                Console.WriteLine($"\t  {attendance.Date.ToShortDateString()}  \t{attendance.NumberOfHoursWorked}");
            }
            
            Console.WriteLine();
        }
    }
}
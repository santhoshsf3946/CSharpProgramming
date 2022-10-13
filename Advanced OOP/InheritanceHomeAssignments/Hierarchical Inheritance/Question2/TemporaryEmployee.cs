using System;

namespace Question2
{
    public class TemporaryEmployee : SalaryInfo
    {
        private static int s_employeeID = 1000;

        private double _da = 0.2;

        private double _hra = 0.18;

        public double TotalSalary { get; set; }

        public TemporaryEmployee(string employeeID, string employeeType, double basicSalary, int month) : base(basicSalary, month)
        {
            EmployeeID = employeeID;
            EmployeeType = employeeType;
        }

        public string EmployeeID { get; set; }

        public string EmployeeType { get; set; }

        public void CalculateTotalSalary()
        {
            DateTime date = new DateTime();
            date.AddMonths(Month);
            TotalSalary = (BasicSalary + BasicSalary * _da + BasicSalary * _hra) * DateTime.DaysInMonth(0001, date.Month);
        }

        public void ShowSalary()
        {
            CalculateTotalSalary();
            Console.WriteLine($"\nTotal salary for Temporary Employee is:  {TotalSalary}");
        }
    }
}
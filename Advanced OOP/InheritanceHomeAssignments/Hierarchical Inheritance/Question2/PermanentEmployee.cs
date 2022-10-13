using System;

namespace Question2
{
    public class PermanentEmployee : SalaryInfo
    {
        private double _da = 0.2;

        private double _hra = 0.18;

        private double _pf = 0.1;

        public double TotalSalary { get; set; }

        public PermanentEmployee(string employeeID, string employeeType, double basicSalary, int month) : base(basicSalary, month)
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
            TotalSalary = (BasicSalary + BasicSalary * _da + BasicSalary * _hra - BasicSalary * _pf) * DateTime.DaysInMonth(0001, date.Month);
        }

        public void ShowSalary()
        {
            CalculateTotalSalary();
            Console.WriteLine($"\nTotal salary for Permanent Employee is:  {TotalSalary}");
        }
    }
}
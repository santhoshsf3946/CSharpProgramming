using System;

namespace Question3
{
    public class EmployeeInfo : SalaryInfo
    {
        public string EmployeeID { get; set; }
        
        public string Branch { get; set; }
        
        public int Floor { get; set; }
        
        public EmployeeInfo(string name, string fatherName, long mobile, DateTime dOB, Gender gender, int month, string employeeID, string branch, int floor) : base(name, fatherName, mobile, dOB, gender, month)
        {
            EmployeeID = employeeID;
            Branch = branch;
            Floor = floor;
        }

        public void ShowDetails()
        {
            Console.WriteLine("\nEmployee Details\n");
            Console.WriteLine($"\tEmployee ID: {EmployeeID}\n\tEmployee Name: {Name}\n\tEmployee Mobile Number: {Mobile}\n");
        }
    }
}

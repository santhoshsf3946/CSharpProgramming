using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class EmploymentDetails : StudentDetails
    {
        private static int s_employmentID = 1000;

        public string EmploymentID { get; set; }

        public DateTime RegisteredDate { get; set; }

        public EmploymentDetails(string aadhaarID, string studentID, string name, string fatherName, Gender gender, long phone, Department department) : base(aadhaarID, studentID, name, fatherName, gender, phone, department)
        {
            s_employmentID++;
            EmploymentID = $"EID{s_employmentID}";
            RegisteredDate = DateTime.Now;
        }

        public void ShowEmploymentDetails()
        {
            Console.WriteLine($"\n  Employment ID: {EmploymentID}\n  Registration Date: {RegisteredDate}\n");
        }
    }
}

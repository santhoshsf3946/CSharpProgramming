using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class StudentInfo : Personalnfo
    {
        private static int s_registerNumber = 1000;

        public string RegisterNumber { get; set; }

        public string Standard { get; set; }

        public string Branch { get; set; }

        public int AcademicYear { get; set; }

        public StudentInfo(string name, string fatherName, long phone, string mail, DateTime dOB, Gender gender, string standard, string branch, int academicYear) : base(name, fatherName, phone, mail, dOB, gender)
        {
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
            s_registerNumber++;
            RegisterNumber = $"SID{s_registerNumber}";
        }

        public void UpdateInfo(string name, string fatherName, long phone, string mail, DateTime dOB, Gender gender, string standard, string branch, int academicYear)
        {
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dOB;
            Gender = gender;  
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n  Register Number: {RegisterNumber}\n  Name: {Name}\n  Father Name: {FatherName}\n  Phone Number: {Phone}\n  Mail {Mail}\n  Date of Birth: {DOB.ToShortDateString()}\n  Gender: {Gender}\n  Standard: {Standard}\n  Branch: {Branch}\n  Acadamic Year: {AcademicYear}\n");
        }
    }
}

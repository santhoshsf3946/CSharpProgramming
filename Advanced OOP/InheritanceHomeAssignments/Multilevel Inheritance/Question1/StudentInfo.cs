using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class StudentInfo : PersonalInfo
    {
        public long RegisterNumber { get; set; }

        public string Standard { get; set; }

        public string Branch { get; set; }

        public int AcademicYear { get; set; }

        public StudentInfo(long registerNumber, string name, string fatherName, long phone, string mail, DateTime dOB, Gender gender, string standard, string branch, int academicYear) : base(name, fatherName, phone, mail, dOB, gender)
        {
            RegisterNumber = registerNumber;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
   
        }
    }
}

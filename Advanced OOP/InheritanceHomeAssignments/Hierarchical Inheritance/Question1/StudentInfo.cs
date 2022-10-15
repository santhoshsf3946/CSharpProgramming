using System;

namespace Question1
{
    public class StudentInfo : PersonalInfo
    {
        public string StudentID { get; set; }

        public string Degree { get; set; }

        public string Department { get; set; }

        public int Semester { get; set; }

        public StudentInfo(string studentID, string name, string fatherName, DateTime dOB, long phone, Gender gender, string mail, string degree, string department, int semester) : base(name, fatherName, dOB, phone, gender , mail)
        {
            StudentID = studentID;
            Degree = degree;
            Department = department;
            Semester = semester;
        }        
    }
}

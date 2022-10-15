using System;

namespace Question3
{
    public class RegisterApplication : UGInfo
    {
        public long RegisterNumber { get; set; }
        
        public int ExperienceInMonths { get; set; }
        
        public string FieldOfIntrest { get; set; }
        
        public RegisterApplication(string name, Gender gender, DateTime dOB, long phone, long registerNumber, int experienceInMonths, string fieldOfIntrest, string fatherName, string motherName, string permanantAddress, long uGMarksheetNumber, string degree, string branch) : base(name, gender, dOB, phone, fatherName, motherName, permanantAddress, uGMarksheetNumber, degree, branch)
        {
            RegisterNumber = registerNumber;
            ExperienceInMonths = experienceInMonths;
            FieldOfIntrest = fieldOfIntrest;
        }

        public void ShowDetails()
        {
            Console.WriteLine("\nStudent Info\n");
            Console.WriteLine($"\tName: {Name}\n\tGender: {Gender}\n\tUG Marksheet Number: {UGMarksheetNumber}\n\tDegree: {Degree}\n\t");
        }
    }
}

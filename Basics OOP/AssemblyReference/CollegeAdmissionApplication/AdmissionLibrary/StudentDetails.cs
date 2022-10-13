using System;

namespace AdmissionLibrary
{
    public class StudentDetails
    {
        // private string _name; // Field

        // public string Name { get { return _name; } set { nameof = value; } } // Propertty

        private static int s_registerNumber = 3000;

        public string RegisterNumber { get; }

        public string Name { get; set; } // Auto Prperty

        public string FatherName { get; set; }
        
        public DateTime DOB { get; set; }
        
        public string Gender { get; set; }
        
        public long Phone { get; set; }

        public string Mail { get; set; }
        
        public int Physics { get; set; }
        
        public int Chemistry { get; set; }
        
        public int Maths { get; set; }

        public StudentDetails(string name, string fatherName, DateTime dob, string gender, long phone, string mail, int physics, int chemistry, int maths) // Parameterized Constructor
        {
            s_registerNumber++;
            RegisterNumber = "SF" + s_registerNumber;
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            Phone = phone;
            Mail = mail;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public StudentDetails(string name, string fatherName, DateTime dob, string gender, long phone, string mail)
        {
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            Phone = phone;
            Mail = mail;
            Physics = 0;
            Chemistry = 0;
            Maths = 0;
        }

        public bool chechEligible(double cutOff)
        {
            double average = (double) (Physics + Chemistry + Maths) / 3.0;
            return average >= cutOff;
        }

        // ~Account () // Destructor
        // {

        // }
    }
}

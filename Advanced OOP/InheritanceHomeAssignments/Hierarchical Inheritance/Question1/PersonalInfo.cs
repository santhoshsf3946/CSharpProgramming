using System;

namespace Question1
{
    public enum Gender { Default, Male, Female, Others }
    public class PersonalInfo
    {
        public PersonalInfo(string name, string fatherName, DateTime dOB, long phone, Gender gender, string mail) 
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dOB;
            Gender = gender;
   
        }
        public string Name { get; set; }

        public string FatherName { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }
    }
}

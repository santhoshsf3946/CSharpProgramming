using System;

namespace Question2
{
    public enum Gender { Default, Male, Female, Others }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public long Mobile { get; set; }

        public DateTime DOB { get; set; }

        public string Mail { get; set; }
        
        public PersonalInfo(string name, Gender gender, DateTime dOB, long mobile, string mail) 
        {
            Name = name;
            Mobile = mobile;
            DOB = dOB;
            Gender = gender;
            Mail = mail;
        }
    }
}

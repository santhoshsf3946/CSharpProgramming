using System;

namespace Question3
{
    public enum Gender { Default, Male, Female, Others }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public long Mobile { get; set; }

        public DateTime DOB { get; set; }
		
		public PersonalInfo(string name, string fatherName, long mobile, DateTime dOB, Gender gender) 
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            DOB = dOB;
            Gender = gender;
        }
    }
}

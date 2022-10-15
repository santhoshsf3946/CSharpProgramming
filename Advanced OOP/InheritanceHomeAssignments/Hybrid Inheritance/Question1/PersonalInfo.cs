using System;

namespace Question1
{
    public enum Gender { Default, Male, Female, Others }
    public class PersonalInfo
    {

        public int RegisterNumber { get; set; }
        
        public string Name { get; set; }

        public string FatherName { get; set; }

        public long Phone { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }
		
		public PersonalInfo(int registerNumber, string name, string fatherName, long phone, DateTime dOB, Gender gender) 
        {
            RegisterNumber = registerNumber;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dOB;
            Gender = gender;
        }
    }
}

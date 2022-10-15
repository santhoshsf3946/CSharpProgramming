using System;

namespace Question3
{
    public enum Gender { Default, Male, Female, Others }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public long Phone { get; set; }

        public int PANNumber { get; set; }

        public PersonalInfo(int pANNumber, string name, Gender gender, DateTime dOB, long phone) 
        {
            PANNumber = pANNumber;
            Name = name;
            Gender = gender;
            DOB = dOB;
            Phone = phone;
        }
    }
}

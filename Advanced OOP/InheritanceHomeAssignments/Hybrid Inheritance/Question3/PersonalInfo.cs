using System;

namespace Question3
{
    public enum Gender { Default, Male, Female, Others }
    public class PersonalInfo : IFamilyInfo
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public long Phone { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string PermanantAddress { get; set; }

        public PersonalInfo(string name, Gender gender, DateTime dOB, long phone, string fatherName, string motherName, string permanantAddress) 
        {
            Name = name;
            Gender = gender;
            DOB = dOB;
            Phone = phone;
            FatherName = fatherName;
            MotherName = motherName;
            PermanantAddress = permanantAddress;
        }
    }
}

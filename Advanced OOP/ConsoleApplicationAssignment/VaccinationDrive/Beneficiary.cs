using System;

namespace VaccinationDrive
{
    public enum Gender { Default, Male, Female, Others }
    public class Beneficiary
    {
        private static int s_registerNumber = 1000;

        public string RegisterNumber { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public long Mobile { get; set; }

        public string City { get; set; }

        public int Age { get; set; }

        public Beneficiary(string name, Gender gender, long mobile, string city, int age)
        {
            s_registerNumber++;
            RegisterNumber = $"BID{s_registerNumber}";
            Name = name;
            Gender = gender;
            Mobile = mobile;
            City = city;
            Age = age;
        }

        public Beneficiary(string data)
        {
            string[] values = data.Split(',');
            s_registerNumber = int.Parse(values[0].Remove(0, 3));
            RegisterNumber = values[0];
            Name = values[1];
            Gender = Enum.Parse<Gender>(values[2]);
            Mobile = long.Parse(values[3]);
            City = values[4];
            Age = int.Parse(values[5]);
        }

        public void ShowMyDetails()
        {
            Console.WriteLine("\n  Beneficiary Details\n  -------------------");
            Console.WriteLine($"  Register Number: {RegisterNumber}\n  Name: {Name}\n  Gender: {Gender}\n  Age: {Age}\n  Mobile Number: {Mobile}\n  City: {City}");
        }
    }
}

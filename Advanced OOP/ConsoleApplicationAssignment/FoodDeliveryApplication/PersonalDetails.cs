using System;

namespace FoodDeliveryApplication
{
    public enum Gender { Default, Male, Female, Others }
    public class PersonalDetails
    { 
        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public long Mobile { get; set; }

        public DateTime DOB { get; set; }

        public string MailID { get; set; }

        public string Location { get; set; }
    }
}

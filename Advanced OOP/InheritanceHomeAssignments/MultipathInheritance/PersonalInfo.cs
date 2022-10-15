using System;

namespace MultipathInheritance
{
    public enum Gender { Default, Male, Female, Others }
    public interface PersonalInfo 
    {
        long AdharNumber { get; set; }

        string Name { get; set; }

        string FatherName { get; set; }

        long Phone { get; set; }

        DateTime DOB { get; set; }

        Gender Gender { get; set; }
    }
}

using System;
namespace MultipathInheritance;

public class Program
{
    public static void Main(string[] args)
    {
        PGCouncelling student = new PGCouncelling(){ 
            AdharNumber = 98424792748, 
            Name = "Santhosh", 
            FatherName = "Iruthayaraj", 
            Phone = 987989347, 
            DOB = new DateTime(2000, 8, 21),
            Gender = Gender.Male,
            HSCMarksheetNumber = 34938479847,
            Physics = 98,
            Chemistry = 87,
            Maths = 88,
            UGMarksheetNumber = 8374832724,
            Sem1Mark = 78,
            Sem2Mark = 99,
            Sem3Mark = 81,
            Sem4Mark = 94,
        };

        student.ShowInfo();
    }
}

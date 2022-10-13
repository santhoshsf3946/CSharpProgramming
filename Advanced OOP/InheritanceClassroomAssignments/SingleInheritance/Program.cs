using System;
namespace SingleInheritance;

public class Program
{
    public static void Main(string[] args)
    {
        // Base class object and method
        
        PersonalDetails personalDetails = new PersonalDetails("Santhosh", "Iruthayaraj", Gender.Male, 9789429543);

        personalDetails.ShowDetails();
        

        // Sub class object and method

        StudentDetails studentDetails = new StudentDetails("987428472438", "Santhosh", "Iruthayaraj", Gender.Male, 9789429543, Department.CSE, "Final Year");

        studentDetails.ShowStudentDetails();
    }
}

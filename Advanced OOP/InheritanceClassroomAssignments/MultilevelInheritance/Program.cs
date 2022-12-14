using System;
namespace MultilevelInheritance;

public class Program
{
    public static void Main(string[] args)
    {
        // // Base class object and method
        // Console.WriteLine("\nPersonal Details\n----------------");
                           
        // PersonalDetails personalDetails = new PersonalDetails("Santhosh", "Iruthayaraj", Gender.Male, 9789429543);

        // personalDetails.ShowDetails();
        

        // // Student sub class object and method
        // Console.WriteLine("\nStudent Details\n---------------");

        // StudentDetails studentDetails = new StudentDetails("987428472438", "Santhosh", "Iruthayaraj", Gender.Male, 9789429543, Department.CSE, "Final Year");

        // studentDetails.ShowStudentDetails();
        // studentDetails.GetMarks(90, 90, 90);
        // studentDetails.Calculate();
        // studentDetails.ShowMark();


        // // Customer sub class object and method
        

        // CustomerDetails customerDetails = new CustomerDetails("947283479248", "Karthi", "Surya", Gender.Male, 978427422);

        // customerDetails.Recharge();
        // Console.WriteLine("\nCustomer Details\n----------------");

        // customerDetails.ShowCustomerDetails();


        // Employment sub class object and method (Multilevel inheritance)

        EmploymentDetails employmentDetails = new EmploymentDetails("7823467834", "SID837", "Santhosh", "Iruthayaraj", Gender.Male, 9837429872, Department.CSE);

        employmentDetails.ShowStudentDetails();
        employmentDetails.GetMarks(90, 90, 90);
        employmentDetails.Calculate();
        employmentDetails.ShowMark();
        employmentDetails.ShowEmploymentDetails();
    }
}


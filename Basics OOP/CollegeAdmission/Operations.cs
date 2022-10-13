using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public static class Operations
    {
        static StudentDetails currentStudent = null;
        static List<StudentDetails> studentList = new List<StudentDetails>();
        public static void MainMenu()
        {
            int option;
            do
            {
                Console.WriteLine("Select option \n\t 1.Registration \n\t 2.Login \n\t 3.Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                    {
                        Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Exit");
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            } while (option != 3);
        }

        public static void Registration()
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your father's name: ");
            string fatherName = Console.ReadLine();

            Console.Write("Enter your date of birth (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            long phone = long.Parse(Console.ReadLine());

            Console.Write("Enter your mail: ");
            string mail = Console.ReadLine();

            Console.Write("Enter your physics mark: ");
            int physics = int.Parse(Console.ReadLine());

            Console.Write("Enter your chemistry mark: ");
            int chemistry = int.Parse(Console.ReadLine());

            Console.Write("Enter your maths mark: ");
            int maths = int.Parse(Console.ReadLine());

            StudentDetails student = new StudentDetails(name, fatherName, dob, gender, phone, mail, physics, chemistry, maths);

            studentList.Add(student);

            Console.WriteLine("Register number: " + student.RegisterNumber);
        }

        public static void Login()
        {
            Console.Write("Enter login ID: ");
            string registerNumber = Console.ReadLine();

            foreach (StudentDetails student in studentList)
            {
                if (student.RegisterNumber == registerNumber)
                {
                    Console.WriteLine("Login Successful !");
                    currentStudent = student;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("Select submenu option: ");
                Console.WriteLine("1.Show details\n2.Check Eligibility\n3.Logout");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Show details");
                        currentStudent.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Check eligibility");
                        if (currentStudent.chechEligible(75))
                        {
                            Console.WriteLine("You are eligible for admission");
                        }
                        else
                        {
                            Console.WriteLine("You are not elligible for admission");
                        }
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Logout successful !");
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            } while (choice != 3);
        }
    }
}

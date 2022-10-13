using System;

namespace StudentData
{
    public static class StudentInfo
    {
        public static string RegisterNumber;

        public static string Name { get; set; }
        
        static StudentInfo()
        {
            RegisterNumber = "SF3946";
            Name = "Santhosh";
        }

        public static void Display()
        {
            Console.WriteLine("Register Number: " + RegisterNumber);
            Console.WriteLine("Name: " + Name);
        }
    }
}

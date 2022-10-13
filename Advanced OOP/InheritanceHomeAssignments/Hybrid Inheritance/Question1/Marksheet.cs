using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Marksheet : TheoryExamMarks, ICalculate
    {

        public Marksheet(int registerNumber, string name, string fatherName, long phone, DateTime dOB, Gender gender, double[] sem1, double[] sem2, double[] sem3, double[] sem4, double[] sem5, double[] sem6, string marksheetNumber, DateTime dateOfIssues, double projectMark) : base(registerNumber, name, fatherName, phone, dOB, gender, sem1, sem2, sem3, sem4, sem5, sem6)
        {
            MarksheetNumber = marksheetNumber;
            DateOfIssues = dateOfIssues;
            ProjectMark = projectMark;
        }

        public string MarksheetNumber { get; set; }
        
        public DateTime DateOfIssues { get; set; }
        
        public double Total { get; set; }

        public double Average { get; set; }
        
        
        public double Percentage { get; set; }
        public double ProjectMark { get; set; }

        public void CalculateUG()
        {
            Total = TotalCalculator(Sem1) + TotalCalculator(Sem2) + TotalCalculator(Sem3) + TotalCalculator(Sem4) + TotalCalculator(Sem5) + TotalCalculator(Sem6);
            Average = Total / 36.0;
        }

        public void ShowUgMarkSheet()
        {
            Console.WriteLine("\n\tMarksheet");
            Console.WriteLine("\nRegister Number: " + RegisterNumber);
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine($"\nYour total mark: {Total}");
            Console.WriteLine($"\nYour average mark: {Average}");
        }

        private double TotalCalculator(double[] sem)
        {
            double total = 0;
            foreach (double mark in sem)
            {
                total +=mark;
            }
            return total;
        }
    }
}
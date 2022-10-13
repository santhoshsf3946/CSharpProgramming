using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class TheoryExamMarks : Personalnfo
    {
        public double[] Sem1 { get; set; }
        public double[] Sem2 { get; set; }
        public double[] Sem3 { get; set; }
        public double[] Sem4 { get; set; }
        public double[] Sem5 { get; set; }
        public double[] Sem6 { get; set; }
        
        public TheoryExamMarks(int registerNumber, string name, string fatherName, long phone, DateTime dOB, Gender gender, double[] sem1, double[] sem2, double[] sem3, double[] sem4, double[] sem5, double[] sem6) : base(registerNumber, name, fatherName, phone, dOB, gender)
        {
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;
            Sem5 = sem5;
            Sem6 = sem6;
        }
    }
}
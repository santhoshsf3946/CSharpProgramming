using System;

namespace MultipathInheritance
{
    public class PGCouncelling : HSCInfo, UGInfo
    {
        public long HSCMarksheetNumber { get; set; }

        public double Physics { get; set; }

        public double Chemistry { get; set; }

        public double Maths { get; set; }

        public double HSCTotalMarks { get; set; }

        public double HSCPercentage { get; set; }

        public long AdharNumber { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public long Phone { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }
        
        public long UGMarksheetNumber { get; set; }

        public double Sem1Mark { get; set; }

        public double Sem2Mark { get; set; }

        public double Sem3Mark { get; set; }

        public double Sem4Mark { get; set; }

        public double UGTotalMarks { get; set; }

        public double UGPercentage { get; set; }

        public void CalculateMarks()
        {
            HSCTotalMarks = Physics + Chemistry + Maths;
            UGTotalMarks = Sem1Mark + Sem2Mark + Sem3Mark + Sem4Mark;

            HSCPercentage = HSCTotalMarks / 3.0;
            UGPercentage = UGTotalMarks / 4.0;
        }

        public void ShowInfo()
        {
            CalculateMarks();
            Console.WriteLine($"\n\tHSC Marksheet number: {HSCMarksheetNumber}\tHSC Total Mark: {HSCTotalMarks}\tHSC Percentage: {HSCPercentage}");
            Console.WriteLine($"\n\tUG Marksheet number: {UGMarksheetNumber}\t\tUG Total Mark: {UGTotalMarks}\tUG Percentage: {UGPercentage}\n");
        }
    }
}
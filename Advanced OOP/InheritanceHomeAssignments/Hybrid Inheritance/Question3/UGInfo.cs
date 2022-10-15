using System;

namespace Question3
{
    public class UGInfo : PersonalInfo
    {
        public long UGMarksheetNumber { get; set; }
        
        public string Degree { get; set; }
        
        public string Branch { get; set; }
        
        public int[] sem1 { get; set; }

        public int[] sem2 { get; set; }

        public int[] sem3 { get; set; }

        public int[] sem4 { get; set; }

        public UGInfo(string name, Gender gender, DateTime dOB, long phone, string fatherName, string motherName, string permanantAddress, long uGMarksheetNumber, string degree, string branch) : base(name, gender, dOB, phone, fatherName, motherName, permanantAddress)
        {
            UGMarksheetNumber = uGMarksheetNumber;
            Degree = degree;
            Branch = branch;
        }

        public bool CheckEligiblity()
        {
            return CheckSemEligiblity(sem1) && CheckSemEligiblity(sem2) && CheckSemEligiblity(sem3) && CheckSemEligiblity(sem4);
        }

        private bool CheckSemEligiblity(int[] sem)
        {
            int total = 0;
            foreach (int item in sem)
            {
                total += item;
            }
            return total / sem.Length > 75;
        }
    }
}
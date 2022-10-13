using System;
namespace Question2
{
    public class AccountInfo : Personalnfo
    {
        private static int s_accountNumber = 37150000;

        public string AccountNumber { get; set; }

        public string BranchName { get; set; }

        public string IFSCCode { get; set; }

        public double Balance { get; set; }

        public AccountInfo(string name, string fatherName, long phone, string mail, DateTime dOB, Gender gender, string branchName, string iFSCCode, double balance) : base(name, fatherName, phone, mail, dOB, gender)
        {
            AccountNumber = $"HDFC{++s_accountNumber}";
            BranchName = branchName;
            IFSCCode = iFSCCode;
            Balance = balance;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n  Account Number: {AccountNumber}\n  Name: {Name}\n  Father Name: {FatherName}\n  Phone Number: {Phone}\n  Mail {Mail}\n  Date of Birth: {DOB.ToShortDateString()}\n  Gender: {Gender}\n  Branch Name: {BranchName}\n  IFSC Code: {IFSCCode}\n  Account Balance: {Balance}\n");
        }
    }
}
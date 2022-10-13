using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public enum Gender { Default, Male, Female, Others }

    public enum Department { Default, ECE, EEE, CSE }

    public class UserDetails
    {
        private static int s_registerationID = 3000;

        public string RegisterationID { get; set; }

        public string UserName { get; set; }

        public Gender Gender { get; set; }

        public Department Department { get; set; }

        public long MobileNumber { get; set; }

        public string MailID { get; set; }

        public double WalletBalance { get; set; }

        public UserDetails(string userName, Gender gender, Department department, long mobileNumber, string mailID, double walletBalance)
        {
            UserName = userName;
            Gender = gender;
            Department = department;
            MobileNumber = mobileNumber;
            MailID = mailID;
            s_registerationID++;
            WalletBalance = walletBalance;
            RegisterationID = $"SF{s_registerationID}";
        }

        public void ShowWalletBalance()
        {
            Console.WriteLine($"\nYor wallet balance is: {WalletBalance}");
        }
    }
}
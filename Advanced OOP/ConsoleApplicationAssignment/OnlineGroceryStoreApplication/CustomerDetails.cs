using System;

namespace OnlineGroceryStoreApplication
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        private static int s_customerID = 1000;

        public string CustomerID { get; }

        public double WalletBalance { get; set; }

        public void WalletRecharge()
        {
            Console.Write("\nEnter amount to recharge to recharge wallet: ");
            double amount = double.Parse(Console.ReadLine());
            WalletBalance += amount;
        }

        public CustomerDetails(string name, string fathername, Gender gender, long mobile, DateTime dob, string mailID) : base(name, fathername, gender, mobile, dob, mailID)
        {
            CustomerID = $"CID{++s_customerID}";
        }

        public CustomerDetails(string data)
        {
            string[] values = data.Split(',');
            s_customerID = int.Parse(values[0].Remove(0, 3));
            CustomerID = values[0];
            Name = values[1];
            FatherName = values[2];
            Gender = Enum.Parse<Gender>(values[3]);
            Mobile = long.Parse(values[4]);
            DOB = DateTime.Parse(values[5]);
            MailID = values[6];
            WalletBalance = double.Parse(values[7]);
        }

        public void ShowCustomerDetails()
        {
            Console.WriteLine("\nCustomer Details");
            Console.WriteLine("----------------");
            Console.WriteLine($"Customer ID: {CustomerID}\nCustomer Name: {Name}\nFather Name: {FatherName}\nGender: {Gender}\nMobile Number: {Mobile}\nDate of Birth: {DOB.ToString("dd/MM/yyyy")}\nMail ID: {MailID}\nWallet Balance: {WalletBalance}");
        }
    }
}

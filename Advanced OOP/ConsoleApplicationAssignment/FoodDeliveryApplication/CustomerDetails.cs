using System;

namespace FoodDeliveryApplication
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        private static int s_customerID = 1000;

        public string CustomerID { get; set; }

        public double WalletBalance { get; set; }

        public CustomerDetails(string name, string fatherName, Gender gender, long mobile, DateTime dob, string mailID, string location, double walletBalance)
        {
            CustomerID = $"CID{++s_customerID}";
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
            Location = location;
            WalletBalance = walletBalance;
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
            Location = values[7];
            WalletBalance = double.Parse(values[8]);
        }
        
        public void ShowCustomerDetails()
        {
            Console.WriteLine($"\n\tCustomer ID: {CustomerID}\n\tCustomer Name: {Name}\n\tFatherName: {FatherName}\n\tGender: {Gender}\n\tMobile Number: {Mobile}\n\tDate of Birth: {DOB.ToString("dd/MM/yyyy")}\n\tMail ID: {MailID}\n\tLocation: {Location}\n\tWallet Balance: {WalletBalance}");
        }

        public void WalletRecharge()
        {
            ShowWalletBalance();

            Console.Write("\nEnter amount to recharge your wallet: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount > 0)
            {
                WalletBalance += amount;
                Console.WriteLine("Wallet recharged successfully");
            }
            else
            {
                Console.WriteLine("\nInvalid amount");
            }
        }

        public void ShowWalletBalance()
        {
            Console.WriteLine($"\nYour available wallet balance is: {WalletBalance}");
        }
    }
}
